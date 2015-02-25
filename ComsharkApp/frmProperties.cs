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
    public partial class frmProperties : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public frmProperties()
        {
            InitializeComponent();

            
        }

        private void frmProperties_Load(object sender, EventArgs e)
        {
            LoadPropertyGroups();
            LoadPropertyGrid();
        }

        public void LoadPropertyGrid()
        {
            TreeNode node = treeViewPropertyGroups.SelectedNode;
            if(node != null)
            {
                log.Debug(String.Format("Selected node {0}", node.Text));
                if (node.Text == "Interface 1")
                {
                    propertyGrid.SelectedObject = Settings.Instance;
                }
                else
                {
                    propertyGrid.SelectedObject = null;
                }
            }
        }

        public void LoadPropertyGroups()
        {
            TreeNode categoryNode;
            TreeNode groupNode;

            log.Info("Loading property groups from xml file");

            try
            {

                XElement xml = XElement.Load("comshark.xml");
                foreach (XElement category in xml.Descendants("Category"))
                {
                    categoryNode = treeViewPropertyGroups.Nodes.Add(category.Attribute("name").Value);
                    
                    foreach (XElement group in category.Descendants("Group"))
                    {
                        
                        groupNode = categoryNode.Nodes.Add(group.Attribute("name").Value);
                        
                        foreach (XElement area in group.Descendants("Area"))
                        {
                            groupNode.Nodes.Add(area.Attribute("name").Value);
                        }
                    }
                     
                }

                treeViewPropertyGroups.ExpandAll();
            }
            catch (System.Xml.XmlException e)
            {
                log.Error(e.Message);
            }
        }

        private void treeViewPropertyGroups_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadPropertyGrid();
        }
    }
}
