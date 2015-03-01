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
using System.Xml.Linq;

namespace Comshark
{
    public partial class frmPacketDetails : DockContent
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmPacketDetails()
        {
            InitializeComponent();
        }

        private void frmPacketDetails_Load(object sender, EventArgs e)
        {
            treeView.DoubleBuffered(true);
        }

        public void UpdateDetails(int frameId, XElement xmlDetails)
        {

            log.DebugFormat("UpdateDetailedView FrameId={0}", frameId);
            //TODO: only clear and add nodes if selection has changed since last time

            try
            {
                treeView.BeginUpdate();
                treeView.Nodes.Clear();

                if (frameId < 0)
                {
                    treeView.Nodes.Add(new TreeNode("No Packet Selected!"));
                    return;
                }

                treeView.Nodes.Add(new TreeNode("Detailed Packet Information"));

                TreeNode tNode;
                tNode = treeView.Nodes[0];

                if (xmlDetails != null)
                    AddNode(frameId, xmlDetails, tNode);

                treeView.Nodes[0].Expand(); //Ensure root node is expanded

                //TODO: if option is set
                //treeView.Nodes[0].ExpandAll(); //Expand everything
            }
            catch (Exception e)
            {
                log.Error(e.Message);
            }
            finally
            {
                treeView.EndUpdate();
                //log.Debug("UpdateDetailedView - Done.");
            }

        }


        private void AddNode(int Id, XElement xmlNode, TreeNode treeNode)
        {
            //log.Debug(xmlNode.Name.ToString());
            TreeNode tNode;
            int i;
            try
            {
                foreach (XElement node in xmlNode.Elements())
                {
                    XAttribute attr = node.Attribute("content");
                    if (attr != null)
                    {

                        String str = attr.Value.ToString();
                        if (node.Name.ToString() == "frame_parent")
                            str = str + " " + Id.ToString() + ":";
                        i = treeNode.Nodes.Add(new TreeNode(str));
                        tNode = treeNode.Nodes[i];
                        if (tNode != null)
                        {
                            if (node.Name.ToString().Contains("_parent"))
                            {
                                tNode.BackColor = Color.LightGray;
                            }
                            AddNode(Id, node, tNode);
                        }
                        if (node.Attribute("expand") != null)
                        {
                            if (node.Attribute("expand").Value == "true")
                            {
                                tNode.Expand();
                            }
                            else if (node.Attribute("expand").Value == "false")
                            {
                                tNode.Collapse();
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                log.Error(e.Message);
            }
        }
    }
}
