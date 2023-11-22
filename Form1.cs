using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DartaChalani.SubModules;


namespace DartaChalani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = Convert.ToString(DateTime.Now);

            // sidePanel.Hide();
          
            MainPanel mpuc = new MainPanel();
            mainPanel.Controls.Add(mpuc);

            
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

       

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartUp sup = new StartUp();
            
            sup.ShowDialog();
        }

        public void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            //cp.MdiParent = this;
           
            cp.ShowDialog();
          

        }

        
      
    }
}
    