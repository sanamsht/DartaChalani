using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace DartaChalani.SubModules
{
    public partial class AddNewChalani : Form
    {
        private readonly Chalani _chalani;
        public AddNewChalani(Chalani chalani)
        {
            InitializeComponent();
            cbFiscalYear.SelectedItem = "2078/79";
            _chalani = chalani;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;

                llFilename.Text = filename;

            }
        }
        DartaChalaniDBEntities1 _db = new DartaChalaniDBEntities1();
        int _id = 0;    
        private void btnTDAdd_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            if (btnTDAdd.Text == "Add")
            {
                AllMethods am = new AllMethods();
                //string fy = Convert.ToString(cbFiscalYear.SelectedItem);
                am.InsertChalani(DPChalani.Text, cbFiscalYear.SelectedItem, tbReference.Text, DPPatra.Text, tbSubject.Text, tbOffice.Text, tbCC.Text, llFilename.Text, tbRemarks.Text);

                _chalani.LoadGrid();
                //   DataTable dt = new DataTable();




                this.Close();
            }
            else if (btnTDAdd.Text=="Edit")
                {
                btnTDAdd.Text = "Update";
                DPChalani.Enabled = true;
                cbFiscalYear.Enabled = true;
                tbReference.Enabled = true;
                DPPatra.Enabled = true;
                tbSubject.Enabled = true;
                tbOffice.Enabled = true;
                tbCC.Enabled = true;
                button1.Enabled = true;
                tbRemarks.Enabled = true;



            }
            else
            {
                _id = Convert.ToInt32(tbChanaliNo.Text);    
                tblChalani tb = _db.tblChalanis.Where(s => s.ChalaniNo == _id).FirstOrDefault();
                tb.ChalaniDate =    DPChalani.Text;
                tb.FiscalYear = cbFiscalYear.SelectedItem.ToString();
                tb.ReferenceNo = tbReference.Text;
                tb.PatraDate = DPPatra.Text;
                tb.Subject=tbSubject.Text;
                tb.OfficeName = tbOffice.Text;  
                tb.Bodhartha=tbCC.Text; 
                tb.File=llFilename.Text;
                tb.Remarks=tbRemarks.Text;
                _db.SaveChanges();
                this.Hide();
               
                _chalani.LoadGrid();
                

            }
            
        }

        private void llFilename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string filename = llFilename.Text;
            System.Diagnostics.Process.Start(filename);
        }
    }
}
