// Review DM: Unused not deleted.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BankManager.Code;

namespace Repositories
{
    public partial class NewDebitor : Form
    {
        // Review DM: readonly string.
        private string _connectionString;
        private SqlDebitorRepository _debitorRepo;

        public NewDebitor()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            _debitorRepo = new SqlDebitorRepository(_connectionString);
        }

        private void btn_addNewDebitor_Click(object sender, EventArgs e)
        {
            try
            {
                // Review DM: new Debitor()
                Debitor newDebitor = new Debitor
                {
                    FirstName = txt_FirstName.Text,
                    LastName = txt_LastName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txt_PhoneNumber.Text,
                    UserId = CurrentUser.Id
                };

                DialogResult = _debitorRepo.AddDebitor(newDebitor) != -1 ? DialogResult.OK : DialogResult = DialogResult.No;
            }
            catch
            {
                DialogResult = DialogResult.No;
            }
        }
    }
}
