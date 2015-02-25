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
            try
            {
                dataGridView.DataSource = mDataRepo.GetProcessedDataTable().DefaultView;
                
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            //dataGridView.Update();
            dataGridView.Refresh();
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


            /*
            int rowidx = dataGridView.Rows.Add();
            DataGridViewRow row = dataGridView.Rows[rowidx];
            row.Cells[0].Value = "2015/02/19 16:27:00.847";
            row.Cells[1].Value = "Slave";
            row.Cells[2].Value = "Master";
            row.Cells[3].Value = "Modbus/ASCII";
            row.Cells[4].Value = "17";
            row.Cells[5].Value = "Register Read [3A 33 32 30 33 30 30 30 31 30 30 31 44 41 32 0D 0A]";
            */
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
