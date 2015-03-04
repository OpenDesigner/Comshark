using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WeifenLuo.WinFormsUI.Docking;

namespace Comshark
{
    public partial class frmComshark : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        DataRepository mDataRepo;
        frmPacketDetails mFormPacketDetails;
        frmPacketList mFormPacketList;

        private delegate void InsertPacketDelegate(ICommPacket packet);
        //public delegate void OnCommPacketReceived(object sender, CommPacketReceivedEventArgs e);


        public frmComshark()
        {
            InitializeComponent();

            dockPanel.DocumentStyle = DocumentStyle.DockingWindow;

            mFormPacketDetails = new frmPacketDetails();
            mFormPacketDetails.Show(dockPanel, DockState.DockBottom);

            mFormPacketList = new frmPacketList();
            mFormPacketList.Show(dockPanel, DockState.Document);

            mDataRepo = new DataRepository();
            CommPort.Instance.CommPacketReceived += OnCommPacketReceived;
            mDataRepo.DataRepositoryChange += OnDataRepositoryChange;
            mFormPacketList.PacketSelectionEvent += OnPacketSelectionChange;
        }


        private void frmComshark_Load(object sender, EventArgs e)
        {

            menuItemToggleColourise.Checked = mFormPacketList.Colourise;
            menuItemToggleAutoScroll.Checked = mFormPacketList.AutoFollow;
            menuItemToggleAutoSelectLatest.Checked = mFormPacketList.AutoSelectLatest;
            menuItemToggleKeepSelectedInView.Checked = mFormPacketList.KeepSelectedInView;
        }

        protected void OnCommPacketReceived(object sender, CommPacketReceivedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new InsertPacketDelegate(mDataRepo.InsertPacket), e.Packet);
            }
            else
            {
                mDataRepo.InsertPacket(e.Packet);
            }
        }


        protected void OnDataRepositoryChange(object sender, EventArgs e)
        {
            mFormPacketList.UpdateList(mDataRepo.GetProcessedDataTable().DefaultView);
            mFormPacketDetails.UpdateDetails(mFormPacketList.SelectedIndex, mDataRepo.GetDetailedInformation(mFormPacketList.SelectedIndex));
            
        }


        protected void OnPacketSelectionChange(object sender, PacketSelectionEventArgs e)
        {
            mFormPacketDetails.UpdateDetails(e.FrameId, mDataRepo.GetDetailedInformation(e.FrameId));
        }


        private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProperties prop = new frmProperties();
            prop.Show();
        }


        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommPort.Instance.Open();
        }


        private void tsbtnProperties_Click(object sender, EventArgs e)
        {
            frmProperties prop = new frmProperties();
            prop.Show();
        }


        private void tsbtnConnect_Click(object sender, EventArgs e)
        {
            CommPort.Instance.Open();
        }


        private void tsbtnDisconnect_Click(object sender, EventArgs e)
        {
            CommPort.Instance.Close();
        }

        private void OnChangeToolbarVisibility_Click(object sender, EventArgs e)
        {
            if(sender == menuItemToggleMainToolbar)
            {
                if(menuItemToggleMainToolbar.Checked)
                {
                    tsMain.Visible = true;
                }
                else
                {
                    tsMain.Visible = false;
                }
            }
            else if (sender == menuItemToggleFilterToolbar)
            {
                if (menuItemToggleFilterToolbar.Checked)
                {
                    tsFilter.Visible = true;
                }
                else
                {
                    tsFilter.Visible = false;
                }
            }
        }

        private void menuItemToggleAutoScroll_Click(object sender, EventArgs e)
        {
            mFormPacketList.AutoFollow = menuItemToggleAutoScroll.Checked;
        }

        private void menuItemToggleKeepSelectedInView_Click(object sender, EventArgs e)
        {
            mFormPacketList.KeepSelectedInView = menuItemToggleKeepSelectedInView.Checked;
        }

        private void menuItemToggleAutoSelectLatest_Click(object sender, EventArgs e)
        {
            mFormPacketList.AutoSelectLatest = menuItemToggleAutoSelectLatest.Checked;
        }

        private void menuItemToggleColourise_Click(object sender, EventArgs e)
        {
            mFormPacketList.Colourise = menuItemToggleColourise.Checked;
        }

    }
}
