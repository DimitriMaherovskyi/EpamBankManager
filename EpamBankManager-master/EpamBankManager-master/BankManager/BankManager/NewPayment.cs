// Review DM: Unused not deleted.
using System;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using Repositories;
using Entities;
using BankManager.Code;


namespace Repositories
{
    public partial class NewPayment : Form
    {
        private readonly string _connectionString;
        private SqlPaymentRepository _paymentRepo;
        private SqlCreditRepository _creditRepo;
        private SqlDebitorRepository _debitorRepo;
        private SqlTypeOfCreditRepository _typeRepo;
        // Review DM: No access identifier.
        int _currentCreditId;

        public NewPayment()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            _paymentRepo = new SqlPaymentRepository(_connectionString);
            _creditRepo = new SqlCreditRepository(_connectionString);
            _debitorRepo = new SqlDebitorRepository(_connectionString);
            _typeRepo = new SqlTypeOfCreditRepository(_connectionString);

            dgvCredits.RowHeadersVisible = false;
        }

        // Review DM: This has to be in method, not event.
        private void NewPayment_Load(object sender, EventArgs e)
        {
            IEnumerable<Credit> credits = _creditRepo.GetCredits();
            IEnumerable<Debitor> debitors = _debitorRepo.GetDebitors();
            IEnumerable<TypeOfCredit> types = _typeRepo.GetTypes();

            var resultList = from credit in credits
                             join debitor in debitors on credit.DebitorId equals debitor.Id
                             join type in types on credit.TypeId equals type.Id
                             where credit.State == "Active"
                             select new
                             {
                                 Id = credit.Id,
                                 FullName = string.Format("{0} {1}", debitor.FirstName, debitor.LastName),
                                 OpenDate = credit.OpenDate,
                                 Amount = credit.Amount,
                                 Balance = credit.Balance,
                                 CreditType = type.Type,
                                 State = credit.State
                             };
            // Review DM: Missed space.
            var list = resultList.ToList();

            dgvCredits.DataSource = list;
        }

        private void btnPassPayment_Click(object sender, EventArgs e)
        {
            try
            {
                Payment newPayment = new Payment
                {
                    CreditId = _currentCreditId,
                    PaymentDate = dtpPaymentDate.Value,
                    Amount = Convert.ToDecimal(txtPaymentAmount.Text),
                    UserId = CurrentUser.Id
                };
                // Review DM: Too much space.


                DialogResult = _paymentRepo.PassPayment(newPayment) != -1 ? DialogResult.OK : DialogResult.No;
            }
            catch
            {
                DialogResult = DialogResult.No;
            }
        }

        private void dgvCredits_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _currentCreditId = Convert.ToInt32(dgvCredits.Rows[e.RowIndex].Cells["Id"].Value.ToString());
        }
    }
}
