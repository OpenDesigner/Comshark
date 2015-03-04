using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Unme.Common;
using System.Runtime.InteropServices;

namespace Comshark
{
    public partial class frmPacketList : DockContent
    {
        private bool mAutoFollow = true;
        private bool mAutoSelectLatest = false;
        private bool mKeepSelectedInView = false;
        private bool mColourise = false;
        private DataGridViewCellStyle mDefaultCellStyle;

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public event EventHandler<PacketSelectionEventArgs> PacketSelectionEvent;

        public frmPacketList()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            dataGridView.DoubleBuffered(true);
        }

        internal static class NativeWindowAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITE = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        private void frmPacketList_Load(object sender, EventArgs e)
        {
            /* Fix for flickering */
            int style = NativeWindowAPI.GetWindowLong(this.Handle, NativeWindowAPI.GWL_EXSTYLE);
            style |= NativeWindowAPI.WS_EX_COMPOSITE;
            NativeWindowAPI.SetWindowLong(this.Handle, NativeWindowAPI.GWL_EXSTYLE, style);

            dataGridView.CellFormatting += CellFormatting;
            mDefaultCellStyle = dataGridView.DefaultCellStyle;
        }

        public void UpdateList()
        {
            
            //dataGridView.Invalidate();
            //dataGridView.Update();
            dataGridView.Refresh();
        }

        public void UpdateList(DataView dataview)
        {
            int row = -1;
            int sel = -1;
            log.Debug("OnDataRepositoryChange");
            try
            {
                dataGridView.SuspendLayout();
                //save state of datagridview, visible row and selected row
                if (dataGridView.SelectedRows.Count > 0)
                {
                    row = dataGridView.FirstDisplayedScrollingRowIndex;
                    sel = dataGridView.SelectedRows[0].Index;
                }

                dataGridView.DataSource = dataview;
                if(dataGridView.Rows.Count > 0)
                    dataGridView.Rows[0].Selected = false;

                if (mAutoSelectLatest)
                {
                    sel = dataGridView.Rows.Count - 2;
                    dataGridView.Rows[sel].Selected = true;
                }
                else
                {
                    if (sel >= 0 && dataGridView.Rows.Count > 0)
                        dataGridView.Rows[sel].Selected = true;
                }


                if (dataGridView.Rows.Count > 0)
                {
                    if (KeepSelectedInView)
                    {
                        if(sel >= 0)
                            dataGridView.FirstDisplayedScrollingRowIndex = sel;
                    }
                    else
                    {
                        if (mAutoFollow)
                        {
                            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
                        }
                        else
                        {
                            //if keep current view
                            if (row < dataGridView.Rows.Count)
                                dataGridView.FirstDisplayedScrollingRowIndex = row;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            finally
            {
                dataGridView.ResumeLayout();
            }
        }

        private void CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (mColourise)
            {
                Color BackgroundColour = Color.Empty;
                Color TextColour = Color.Empty;
                try
                {
                    BackgroundColour = ColorTranslator.FromHtml(this.dataGridView.Rows[e.RowIndex].Cells["BackgroundColour"].Value.ToString());
                    TextColour = ColorTranslator.FromHtml(this.dataGridView.Rows[e.RowIndex].Cells["TextColour"].Value.ToString());
                }
                catch (Exception ex)
                {

                }

                dataGridView.SuspendLayout();
                if (BackgroundColour != Color.Empty)
                {
                    this.dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = BackgroundColour;
                }

                if (TextColour != Color.Empty)
                {
                    this.dataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = TextColour;
                }
                dataGridView.ResumeLayout();
            }
            else
            {
                //restore defaults
                //this.dataGridView.Rows[e.RowIndex].DefaultCellStyle = mDefaultCellStyle;
            }
        }

        public int SelectedIndex
        {
            get
            {
                if (dataGridView.SelectedRows.Count > 0)
                    return dataGridView.SelectedRows[0].Index;
                else
                    return -1;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PacketSelectionEvent.Raise(this, new PacketSelectionEventArgs(SelectedIndex));
        }

        public bool AutoFollow
        {
            get
            {
                return mAutoFollow;
            }

            set
            {
                mAutoFollow = value;
            }
        }

        public bool AutoSelectLatest
        {
            get
            {
                return mAutoSelectLatest;
            }

            set
            {
                mAutoSelectLatest = value;
            }
        }

        public bool KeepSelectedInView
        {
            get
            {
                return mKeepSelectedInView;
            }

            set
            {
                mKeepSelectedInView = value;
            }
        }

        public bool Colourise
        {
            get
            {
                return mColourise;
            }

            set
            {
                mColourise = value;
                if (!mColourise)
                {
                    dataGridView.DefaultCellStyle = mDefaultCellStyle;
                    dataGridView.RowsDefaultCellStyle = mDefaultCellStyle;
                }
                
                dataGridView.Invalidate();
                dataGridView.Refresh();
            }
        }
    }


    public class PacketSelectionEventArgs : EventArgs
    {

        private readonly int mFrameId;

        internal PacketSelectionEventArgs(int frameId)
        {
            mFrameId = frameId;
        }

        /// <summary>
        /// Gets the packet.
        /// </summary>
        /// <value>The packet.</value>
        public int FrameId
        {
            get { return mFrameId; }
        }
    }
   
}

