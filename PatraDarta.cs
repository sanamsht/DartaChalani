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
    public partial class PatraDarta : UserControl
    {
        public PatraDarta()
        {
            InitializeComponent();
        }

        private static PatraDarta _instance;
        public static Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PatraDarta();
                return _instance;
            }
        }

        private void btnPDHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mpuc = new MainPanel();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.sidePanel.Hide();
            frm.mainPanel.Controls.Add(mpuc);
        }

        private void btnPDAddNew_Click(object sender, EventArgs e)
        {
            AddNewFileDarta anfd = new AddNewFileDarta();
            anfd.ShowDialog();
        }
    }
}
