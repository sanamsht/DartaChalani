using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DartaChalani
{
    public partial class MainPanel : UserControl
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        public void btn_Tippani_Click(object sender, EventArgs e)
        {
            TippaniDarta tduc = new TippaniDarta();
            SidePanel spuc = new SidePanel();
            Form1 frm = new Form1();
            frm = (Form1)this.FindForm();
            frm.mainPanel.Controls.Clear();
            frm.mainPanel.Controls.Add(tduc);
            frm.sidePanel.Show();
            frm.sidePanel.Controls.Add(spuc);
            this.Hide();
          
        }

           

        private void btnMainDarta_Click(object sender, EventArgs e)
        {
            PatraDarta tduc = new PatraDarta();
            SidePanel spuc = new SidePanel();
            Form1 frm = new Form1();
            frm = (Form1)this.FindForm();
            frm.mainPanel.Controls.Clear();
            frm.mainPanel.Controls.Add(tduc);
            frm.sidePanel.Show();
            frm.sidePanel.Controls.Add(spuc);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultancyDarta tduc = new ConsultancyDarta();
            SidePanel spuc = new SidePanel();
            Form1 frm = new Form1();
            frm = (Form1)this.FindForm();
            frm.mainPanel.Controls.Clear();
            frm.mainPanel.Controls.Add(tduc);
            frm.sidePanel.Show();
            frm.sidePanel.Controls.Add(spuc);
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Chalani tduc = new Chalani();
            SidePanel spuc = new SidePanel();
            Form1 frm = new Form1();
            frm = (Form1)this.FindForm();
            frm.mainPanel.Controls.Clear();
            frm.mainPanel.Controls.Add(tduc);
            frm.sidePanel.Show();
            frm.sidePanel.Controls.Add(spuc);
            this.Hide();
        }
    }
}
