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
    public partial class OpenCredit : Form
    {
        private readonly string _connectionString;
        private SqlDebitorRepository _debitorRepo;
        private SqlCreditRepository _creditRepo;
        private int _currentDebitorId;

        public OpenCredit()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            _debitorRepo = new SqlDebitorRepository(_connectionString);
            _creditRepo = new SqlCreditRepository(_connectionString);

            // Review DM: May be done in dgv properties.
            dgvDebitors.RowHeadersVisible = false;
        }

        private void OpenCredit_Load(object sender, EventArgs e)
        {
            dgvDebitors.DataSource = _debitorRepo.GetDebitors();
        }

        private void btnOpenNewCredit_Click(object sender, EventArgs e)
        {
            try
            {
                // Review DM: new Credit()
                Credit newCredit = new Credit
                {
                    DebitorId = _currentDebitorId,
                    OpenDate = dtpCreditOpenDate.Value,
                    Amount = Convert.ToDecimal(txtCreditAmount.Text),
                    TypeId = int.Parse(txtTypeId.Text),
                    UserId = CurrentUser.Id
                };

                DialogResult = _creditRepo.OpenNewCredit(newCredit) != -1 ? DialogResult.OK : DialogResult.No;
            }
            catch
            {
                DialogResult = DialogResult.No;
            }
        }

        private void dgvDebitors_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _currentDebitorId = Convert.ToInt32(dgvDebitors.Rows[e.RowIndex].Cells["Id"].Value.ToString());
        }

        private void txtCreditAmount_TextChanged(object sender, EventArgs e)
        {
            txtCreditBalance.Text = txtCreditAmount.Text;
        }
    }
}
