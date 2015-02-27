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

                dataGridView.SuspendLayout();
                dataGridView.DataSource = mDataRepo.GetProcessedDataTable().DefaultView;
                dataGridView.Rows[0].Selected = false;

                //dataGridView.Update();
                //dataGridView.Refresh();
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
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            finally
            {
                dataGridView.ResumeLayout();
            }

            UpdateDetailedView(sel);
        }


        public void UpdateDetailedView(int Id)
        {
            //TODO: only clear and add nodes if selection has changed since last time

            try
            {
                treeView.BeginUpdate();
                treeView.Nodes.Clear();

                if (Id < 0)
                    return;

                treeView.Nodes.Add(new TreeNode("Detailed Packet Information"));

                TreeNode tNode;
                tNode = treeView.Nodes[0];

                XElement detailedInfoXml = mDataRepo.GetDetailedInformation(Id);
                if (detailedInfoXml != null)
                    AddNode(Id, detailedInfoXml, tNode);

                treeView.Nodes[0].Expand(); //Ensure root node is expanded

                //TODO: if option is set
                treeView.Nodes[0].ExpandAll(); //Expand everything
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
            finally
            {
                treeView.EndUpdate();
            }

        }


        private void AddNode(int Id, XElement xmlNode, TreeNode treeNode)
        {
            log.Debug(xmlNode.Name.ToString());
            TreeNode tNode;
            int i;

            foreach (XElement node in xmlNode.Elements())
            {
                XAttribute attr = node.Attribute("content");
                if(attr != null)
                {
                    
                    String str = attr.Value.ToString();
                    if (node.Name.ToString() == "frame_parent")
                        str = str + " " + Id.ToString() + ":";
                    i = treeNode.Nodes.Add(new TreeNode(str));
                    tNode = treeNode.Nodes[i];
                    if (tNode != null)
                    {
                        if(node.Name.ToString().Contains("_parent"))
                        {
                            tNode.BackColor = Color.LightGray;
                        }
                        AddNode(Id, node, tNode);
                    }
                }
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
            dataGridView.DoubleBuffered(true);
            treeView.DoubleBuffered(true);
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

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel;
            sel = dataGridView.SelectedRows[0].Index;
            UpdateDetailedView(sel);
        }





    }
}
