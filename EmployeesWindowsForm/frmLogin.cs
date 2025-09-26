using EmployeeBusinessLaye;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace EmployeesWindowsForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString();
        }

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }




        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string Password = txtPassword.Text;

            if (clsUser.IsUserExists(UserName, Password))
            {
                frmDashBoard frmDash = new frmDashBoard();
                this.Hide();
                frmDash.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password!!");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pibGithub_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/mohamedabass1", UseShellExecute = true });
        }

        private void pibLinkedIn_Click(object sender, EventArgs e)
        {

        }
    }
}
