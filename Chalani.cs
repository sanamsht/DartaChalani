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
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace DartaChalani
{
    public partial class Chalani : UserControl
    {
        public readonly DataGridViewButtonColumn btn = new DataGridViewButtonColumn();

        public Chalani()
        {
            InitializeComponent();
            LoadGrid();
            dgvChalani.Columns.Add(btn);
            dgvChalani.Columns[0].HeaderText = "चलानी नं.";
            dgvChalani.Columns[0].Width = 75;
            dgvChalani.Columns[1].HeaderText = "चलानी मिति";
            dgvChalani.Columns[1].Width = 100;
            dgvChalani.Columns[3].HeaderText = "पत्र संख्या";
            dgvChalani.Columns[3].Width = 75;
            dgvChalani.Columns[4].HeaderText = "पत्र मिति";
            dgvChalani.Columns[4].Width = 100;
            dgvChalani.Columns[2].HeaderText = "आ.व.";
            dgvChalani.Columns[2].Width = 75;
            dgvChalani.Columns[5].HeaderText = "विषय";
            dgvChalani.Columns[5].Width =210;
            dgvChalani.Columns[6].HeaderText = "चलान गरिएको अफिस";
           dgvChalani.Columns[6].Width = 210;
            dgvChalani.Columns[7].HeaderText = "बोधार्थ";
           dgvChalani.Columns[7].Width = 210;
            //dgvChalani.Columns[8].HeaderText = "पत्र";
            //dgvChalani.Columns[8].Visible = false;
            dgvChalani.Columns[8].HeaderText = "कैफियत";
            dgvChalani.Columns[8].Width = 75;
        }
        SqlConnection con = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=DartaChalaniDB;Integrated Security=True");
        private static Chalani _instance;
        public static Control Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Chalani();
                return _instance;
            }
        }
        private void btnChaHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPanel mpuc = new MainPanel();
            Form1 frm;
            frm = (Form1)this.FindForm();
            frm.sidePanel.Hide();
            frm.mainPanel.Controls.Add(mpuc);
        }

        private void btnChaAddNew_Click(object sender, EventArgs e)
        {
            using (var anc = new AddNewChalani(this))
            {
                anc.btnTDAdd.Text = "Add";
                anc.ShowDialog();

            }
        }

        public void LoadGrid()
        {
            AllMethods am = new AllMethods();
            am.LoadChalaniGrid(dgvChalani);
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "View";

            //SqlCommand cmd = new SqlCommand("select ChalaniNo,ChalaniDate, FiscalYear,ReferenceNo,PatraDate, Subject, OfficeName, Bodhartha, Remarks from tblChalani", con);

            //SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);

            //dgvChalani.DataSource = dt;
            
                   

            
        }
        

       

        public void form_Refresh()
        {
            Form1 frm = new Form1();
            frm.Refresh();

        }
        public int chalNo = 0;
        DartaChalaniDBEntities1 _db = new DartaChalaniDBEntities1();
        private void dgvViewBtnClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            chalNo = Convert.ToInt32(dgvChalani.CurrentRow.Cells[1].Value);
            try {
                tblChalani tb = _db.tblChalanis.Where(s => s.ChalaniNo == chalNo).FirstOrDefault();
                AddNewChalani anc = new AddNewChalani(this);
                anc.Show();
                anc.tbChanaliNo.Text = dgvChalani.CurrentRow.Cells[1].Value.ToString();
                anc.tbChanaliNo.Enabled = false;
                anc.DPChalani.Text = dgvChalani.CurrentRow.Cells[2].Value.ToString();
                anc.DPChalani.Enabled = false;
                anc.cbFiscalYear.SelectedItem = dgvChalani.CurrentRow.Cells[3].Value.ToString();
                anc.cbFiscalYear.Enabled = false;
                anc.tbReference.Text = dgvChalani.CurrentRow.Cells[4].Value.ToString();
                anc.tbReference.Enabled = false;
                anc.DPPatra.Text = dgvChalani.CurrentRow.Cells[5].Value.ToString();
                anc.DPPatra.Enabled = false;
                anc.tbSubject.Text = dgvChalani.CurrentRow.Cells[6].Value.ToString();
                anc.tbSubject.Enabled = false;
                anc.tbOffice.Text = dgvChalani.CurrentRow.Cells[7].Value.ToString();
                anc.tbOffice.Enabled = false;
                anc.tbCC.Text = dgvChalani.CurrentRow.Cells[8].Value.ToString();
                anc.tbCC.Enabled = false;
                anc.button1.Enabled = false;
                anc.llFilename.Text = tb.File;

                anc.tbRemarks.Text = dgvChalani.CurrentRow.Cells[9].Value.ToString();
                anc.tbRemarks.Enabled = false;


                anc.btnTDAdd.Text = "Edit";
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
            
            }

        private void tbChaSearch_TextChanged(object sender, EventArgs e)
        {


            if (tbChaSearch.Text != "")
            {
                
                List<tblChalani> lst = _db.tblChalanis.Where(x =>  x.ChalaniDate.Contains(tbChaSearch.Text) || x.Subject.Contains(tbChaSearch.Text) || x.OfficeName.Contains(tbChaSearch.Text) || x.Bodhartha.Contains(tbChaSearch.Text) || x.Remarks.Contains(tbChaSearch.Text)).ToList();
                dgvChalani.DataSource = lst;
            }
            else
            {
                LoadGrid();
            }
        }
        int chaNo = 0;
        private void btnChaSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
