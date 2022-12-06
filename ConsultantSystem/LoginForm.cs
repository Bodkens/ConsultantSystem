using DataLayer;
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
namespace ConsultantSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (!(loginTextBox.Text.Length > 0 && passwordTextBox.Text.Length > 0))
            {
                MessageBox.Show("Please Enter login and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (!LoginManager.TryLogin(loginTextBox.Text, passwordTextBox.Text))
            {
                MessageBox.Show("Failed to login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            string? login = LoginManager.consultant?.Login;
            Log log = new Log(login == null ? "undefined" : login, "Login");
            log.WriteLog();
            this.Hide();
            ConsultantForm consultantForm = new ConsultantForm();
            consultantForm.ShowDialog();
            this.Close();


        }
    }
}
