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
using System.Runtime.InteropServices;

namespace Comshark
{
    public partial class frmPacketDetails : DockContent
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmPacketDetails()
        {
            InitializeComponent();
            treeView.DoubleBuffered(true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
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

        private void frmPacketDetails_Load(object sender, EventArgs e)
        {
            /* Fix for treeview flickering */
            int style = NativeWindowAPI.GetWindowLong(this.Handle, NativeWindowAPI.GWL_EXSTYLE);
            style |= NativeWindowAPI.WS_EX_COMPOSITE;
            NativeWindowAPI.SetWindowLong(this.Handle, NativeWindowAPI.GWL_EXSTYLE, style);
        }

        public void UpdateDetails(int frameId, XElement xmlDetails)
        {

            log.DebugFormat("UpdateDetailedView FrameId={0}", frameId);
            //TODO: only clear and add nodes if selection has changed since last time

            try
            {
                treeView.SuspendLayout();
                treeView.BeginUpdate();

                treeView.Nodes.Clear();

                if (frameId < 0)
                {
                    treeView.Nodes.Add(new TreeNode("No Packet Selected!"));
                    throw new Exception("No Packet Selected");
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
                treeView.ResumeLayout();
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


        /*
         * protected override void OnPaint(PaintEventArgs e)
{
    if (GetStyle(ControlStyles.UserPaint))
    {
        Message m = new Message();
        m.HWnd = Handle;
        m.Msg = WM_PRINTCLIENT;
        m.WParam = e.Graphics.GetHdc();
        m.LParam = (IntPtr)PRF_CLIENT;
        DefWndProc(ref m);
        e.Graphics.ReleaseHdc(m.WParam);
    }
    base.OnPaint(e);
}
         */
    }
}
