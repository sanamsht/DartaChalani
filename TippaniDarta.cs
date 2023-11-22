using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DartaChalani.SubModules;


namespace DartaChalani
{
    public partial class TippaniDarta : UserControl
    {
        public TippaniDarta()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mpuc = new MainPanel();
            Form1 frm ;
            frm = (Form1)this.FindForm();
            frm.sidePanel.Hide();
            frm.mainPanel.Controls.Add(mpuc);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewDarta antd = new AddNewDarta();
            
            antd.ShowDialog();
                
        }
    }
}
