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

namespace Comshark
{
    public partial class frmPacketList : DockContent
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public event EventHandler<PacketSelectionEventArgs> PacketSelectionEvent;

        public frmPacketList()
        {
            InitializeComponent();
        }

        private void frmPacketList_Load(object sender, EventArgs e)
        {
            dataGridView.DoubleBuffered(true);
        }

        public void UpdateList(DataView dataview)
        {
            int row = -1;
            int sel = -1;
            log.Debug("OnDataRepositoryChange");
            try
            {
                //save state of datagridview
                row = dataGridView.FirstDisplayedScrollingRowIndex;
                if(dataGridView.SelectedRows.Count > 0)
                    sel = dataGridView.SelectedRows[0].Index;

                dataGridView.SuspendLayout();
                dataGridView.DataSource = dataview;
                //if(dataGridView.Rows.Count > 0)
                //    dataGridView.Rows[0].Selected = false;

                //dataGridView.Update();
                //dataGridView.Refresh();
                
                if (row < dataGridView.Rows.Count && sel < dataGridView.Rows.Count)
                {
                    if (true) //(Settings.Instance.Follow) 
                    {
                        dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
                    }
                    else
                    {
                        //if keep current view
                        dataGridView.FirstDisplayedScrollingRowIndex = row;
                    }
                    if(sel >= 0 && dataGridView.SelectedRows.Count > 0)
                        dataGridView.Rows[sel].Selected = true;
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
