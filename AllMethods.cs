using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace DartaChalani
{
    class AllMethods
    {

        SqlConnection con = new SqlConnection("Data Source=DELL\\SQLEXPRESS;Initial Catalog=DartaChalaniDB;Integrated Security=True");

        public bool Openconnection()
        {
            try
            {
               // con = new SqlConnection("Data Source=DELLPRASAD\\SQL2021;Integrated Security=True; Database = DartaChalani");
                 con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=DELLPRASAD\\SQL2021;Integrated Security=True; Database = DartaChalani");
                con.Close();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }

        }

        public void InsertChalani (string chaDate, object FY, string RefNo, string Pdate, string Subject, string OffName, string Bodh, string FileName, string Remarks )
        {
            Openconnection();
            SqlCommand cmd = new SqlCommand("insert into tblChalani values('" + chaDate+"','" + FY+"','" + RefNo+"','" + Pdate+"','" + Subject+"','" + OffName+"','" + Bodh+"','" + FileName+"','" + Remarks+"')", con);
            cmd.ExecuteNonQuery();
            this.CloseConnection();
        }

        public void LoadChalaniGrid (DataGridView dgv)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select ChalaniNo,ChalaniDate, FiscalYear,ReferenceNo,PatraDate, Subject, OfficeName, Bodhartha, Remarks from tblChalani order by ChalaniNo DESC";
            Openconnection();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //SqlDataReader objReader = cmd.ExecuteReader();
            DataTable dt = new DataTable();


            sda.Fill(dt);
            dgv.DataSource = dt;

        }

    }
}
