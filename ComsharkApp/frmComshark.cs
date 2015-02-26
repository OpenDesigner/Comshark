using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comshark
{
    public partial class frmComshark : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        DataRepository mDataRepo;

        private delegate void InsertPacketDelegate(ICommPacket packet);
        //public delegate void OnCommPacketReceived(object sender, CommPacketReceivedEventArgs e);
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
            int row = -1;
            int sel = -1;
            try
            {
                //save state of datagridview
                row = dataGridView.FirstDisplayedScrollingRowIndex;
                sel = dataGridView.SelectedRows[0].Index;

                dataGridView.DataSource = mDataRepo.GetProcessedDataTable().DefaultView;
                dataGridView.Rows[0].Selected = false;
                
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            //dataGridView.Update();
            dataGridView.Refresh();
            if (row < dataGridView.Rows.Count && sel < dataGridView.Rows.Count)
            {
                if(true) //(Settings.Instance.Follow) 
                {
                    dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.Rows.Count - 1;
                }
                else
                {
                    //if keep current view
                    dataGridView.FirstDisplayedScrollingRowIndex = row;
                }
                dataGridView.Rows[sel].Selected = true;
            }
        }

        public frmComshark()
        {
            mDataRepo = new DataRepository();
            InitializeComponent();
            CommPort.Instance.CommPacketReceived += OnCommPacketReceived;
            mDataRepo.DataRepositoryChange += OnDataRepositoryChange;
        }


        private void frmComshark_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            mDataRepo.TestInsert();
            try
            {
                dataGridView.DataSource = mDataRepo.GetProcessedDataTable().DefaultView;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }





    }
}
