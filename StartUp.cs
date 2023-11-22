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
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
                Environment.Exit(1);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "bridge" && txtPass.Text == "123")
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
