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

        DataRepository mDataRepo;

        public frmComshark()
        {
            mDataRepo = new DataRepository();
            InitializeComponent();
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
                MessageBox.Show("Error");
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



    }
}
