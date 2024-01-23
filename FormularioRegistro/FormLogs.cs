using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormularioRegistro
{
    public partial class FormLogs : Form
    {
        public FormLogs()
        {
            InitializeComponent();
        }
        public static string directorio = "";
        
        private void Logs_Load(object sender, EventArgs e)
        {
            List<String> parentDir = new List<string>();
            parentDir.AddRange(Directory.GetFiles(directorio, "*.*"));
            foreach (String s in parentDir)
            {
                FileInfo f = new FileInfo(s);
                TreeNode subItems = new TreeNode(f.Name);
                treeVLogs.Nodes.Add(subItems);
            }

        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            richTBLogs.Text = File.ReadAllText(directorio + "/" + treeVLogs.SelectedNode.Text);
        }
    }
}
