using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TablesForm tableform = new TablesForm();
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls.Clear();
            tableform.TopLevel = false;
            tableform.Dock = DockStyle.Fill; 
            mainPanel.Controls.Add(tableform);
            tableform.Show();
        }
    }
}
