// Review DM: Unsorted. Unused not deleted.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Repositories;
using System.Configuration;
using BankManager.Code;

namespace BankManager
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepo;
        // Review DM: Missed space.
        public LoginForm()
        {
            _userRepo = new SqlUserRepository(ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = Encryptor.ComputeHash(txtPassword.Text);
            User user = _userRepo.GetUser(login, password);

            if(user == null)
            {
                MessageBox.Show(this, "Invalid user name or password", "Authentification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentUser.Initialize(user);
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
