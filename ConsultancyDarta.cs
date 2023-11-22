using DartaChalani.SubModules;
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
    public partial class ConsultancyDarta : UserControl
    {
        public ConsultancyDarta()
        {
            InitializeComponent();
            
        }
        private static ConsultancyDarta _instance;
        public static Control Instance
        {
            
            get
            {
                if (_instance == null)
                    _instance = new ConsultancyDarta();
                
                return _instance;
            }
        }

        private void btnCDHome_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainPanel mpuc = new MainPanel();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.sidePanel.Hide();
            frm.mainPanel.Controls.Add(mpuc);


        }

        private void btnCDAddNew_Click(object sender, EventArgs e)
        {
            AddNewConsultancyDarta ancd = new AddNewConsultancyDarta();
            ancd.ShowDialog();

        }
    }
}
