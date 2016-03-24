// Review DM: Unused not deleted.
using System;
using System.Collections.Generic;
using System.Collections;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Entities;
using Repositories;

namespace Repositories
{
    // Review DM: Logic cannot be on form so massively.
    public partial class MainForm : Form
    {
        #region Private fields
        private string _connectionString;
        private SqlDebitorRepository _debitorRepo;
        private SqlCreditRepository _creditRepo;
        private SqlPaymentRepository _paymentRepo;
        private SqlTypeOfCreditRepository _typeRepo;


        private DataGridView _dgvDebitors;
        private DataGridView _dgvCredits;
        private DataGridView _dgvPayments;
        // Review DM: Commented code in release.
        //private DataGridView _dgvBlackList;

        //Enum which is represent what data is in GridView in current moment (debitors by default)
        private DataInGrid _dataInGrid;
        #endregion

        #region Constructor
        // Review DM: Some of these may be done in properties of elements. 
        public MainForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager.ConnectionStrings["ConnectionToBank"].ConnectionString;
            // Review DM: Classes won't be garbage collected before the program exits.
            _debitorRepo = new SqlDebitorRepository(_connectionString);
            _creditRepo = new SqlCreditRepository(_connectionString);
            _paymentRepo = new SqlPaymentRepository(_connectionString);
            _typeRepo = new SqlTypeOfCreditRepository(_connectionString);

            //We are getting dataGrid views from each user control
            _dgvDebitors = (DataGridView)ucDebitorsGrid.Controls["dgvDebitors"];
            _dgvCredits = (DataGridView)ucCreditsGrid.Controls["dgvCredits"];
            _dgvPayments = (DataGridView)ucPaymentsGrid.Controls["dgvPayments"];
            // Review DM: Commented code in release.
            //_dgvBlackList = (DataGridView)ucBlackListGrid.Controls["dgvBlackList"];

            //By default only debitorsGridView is visible
            ucDebitorsGrid.Visible = true;
            ucCreditsGrid.Visible = ucPaymentsGrid.Visible = false;

            _dgvDebitors.CellDoubleClick += dgv_Data_CellDoubleClick;
            _dgvCredits.CellDoubleClick += dgv_Data_CellDoubleClick;

            _dgvDebitors.MouseClick += dgv_Data_MouseClick;
            _dgvCredits.MouseClick += dgv_Data_MouseClick;
            _dgvPayments.MouseClick += dgv_Data_MouseClick;

            _dgvDebitors.RowHeadersVisible = false;
            _dgvCredits.RowHeadersVisible = false;
            _dgvPayments.RowHeadersVisible = false;

            _dgvDebitors.ReadOnly = true;
            _dgvCredits.ReadOnly = true;
            _dgvPayments.ReadOnly = true;
        }
        #endregion

        #region MainForm Load event
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Default table is debitors so we show it when the form loads
            _dgvDebitors.DataSource = _debitorRepo.GetDebitors();
            _dataInGrid = DataInGrid.Debitors;
        }
        #endregion

        #region Clicks on dataGridViews
        private void dgv_Data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Double click on some debitor causes loading all credits fro that debitor
            if (_dataInGrid == DataInGrid.Debitors)
            {
                int debitorId = Convert.ToInt32(_dgvDebitors.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                _dataInGrid = DataInGrid.CreditsForDebitor;

                ucCreditsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucPaymentsGrid.Visible = false;
                _dgvCredits.DataSource = GetCustomCreditList(debitorId); 
                // Space's not required here.

            }
            //Double click on some credit causes loading all payments for that debitor
            else if(_dataInGrid == DataInGrid.AllCredits || _dataInGrid == DataInGrid.CreditsForDebitor)
            {
                // Review DM: This is hard to read. Repositories are for this.
                int creditId = Convert.ToInt32(_dgvCredits.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                _dataInGrid = DataInGrid.PaymentsForCredit;

                ucPaymentsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucCreditsGrid.Visible = false;
                _dgvPayments.DataSource = GetCustomPaymentList(creditId);
            }
        }
        
        private void dgv_Data_MouseClick(object sender, MouseEventArgs e)
        {
            //Right click on gridView - and we get the context menu
            if(e.Button == MouseButtons.Right)
            {
                cntxms_GridMenu.Show(grbx_Data, new Point(e.X, e.Y));
            }
        }
        #endregion

        #region Context menu actions
        private void showAllDebitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If there are debitors in grid view there is no sense to load them again
            if(_dataInGrid == DataInGrid.Debitors)
            {
                return;
            }
            else
            {
                ucDebitorsGrid.Visible = true;
                ucCreditsGrid.Visible = ucPaymentsGrid.Visible = false;
                _dgvDebitors.DataSource = _debitorRepo.GetDebitors();
                _dataInGrid = DataInGrid.Debitors;
            }
        }

        private void showAllCreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If there are credits in grid view there is no sense to load them again
            if (_dataInGrid == DataInGrid.AllCredits)
            {
                return;
            }
            else
            {
                _dataInGrid = DataInGrid.AllCredits;


                ucCreditsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucPaymentsGrid.Visible = false;
                _dgvCredits.DataSource = GetCustomCreditList();
            }
        }

        private void showAllPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dataInGrid == DataInGrid.Payments)
            {
                return;
            }
            else
            {
                _dataInGrid = DataInGrid.Payments;

                ucPaymentsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucCreditsGrid.Visible = false;
                _dgvPayments.DataSource = GetCustomPaymentList();
            }
        }

        private void newDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewDebitorToolStripMenuItem_Click(sender, e);
        }

        private void newCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNewCreditToolStripMenuItem_Click(sender, e);
        }

        private void passNewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPayment newPayment = new NewPayment();
            if (newPayment.ShowDialog() == DialogResult.OK)
            {
                ucPaymentsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucCreditsGrid.Visible = false;
                _dgvPayments.DataSource = GetCustomPaymentList();
                _dataInGrid = DataInGrid.Payments;
                MessageBox.Show("New payment was succesfully passed");
            }
            else
            {
                MessageBox.Show("New payment was not passed");
            }
        }
        #endregion

        #region Form closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult closeResult = MessageBox.Show("Are you sure want to close te application?", "BankManager", MessageBoxButtons.OKCancel);
            if(closeResult == DialogResult.OK)
            {
                e.Cancel = false;
            }
            // Review DM: Not required.
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region Main Menu actions
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewDebitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDebitor newDebitor = new NewDebitor();
            if(newDebitor.ShowDialog() == DialogResult.OK)
            {
                ucDebitorsGrid.Visible = true;
                ucCreditsGrid.Visible = ucPaymentsGrid.Visible = false;
                _dgvDebitors.DataSource = _debitorRepo.GetDebitors();
                _dataInGrid = DataInGrid.Debitors;
                MessageBox.Show("New debitor was succesfully added");
            }
            else
            {
                MessageBox.Show("New debitor was not added");
            }
        }

        private void openNewCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCredit openCredit = new OpenCredit();

            if(openCredit.ShowDialog()== DialogResult.OK)
            {
                ucCreditsGrid.Visible = true;
                ucDebitorsGrid.Visible = ucPaymentsGrid.Visible = false;
                _dgvCredits.DataSource = GetCustomCreditList();
                _dataInGrid = DataInGrid.AllCredits;
                MessageBox.Show("New credit was succesfully opened");
            }
            else
            {
                MessageBox.Show("New credit was not opened");
            }
        }

        private void newPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            passNewPaymentToolStripMenuItem_Click(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_debitorRepo.SaveTable() && _creditRepo.SaveTable() && _paymentRepo.SaveTable() && _typeRepo.SaveTable())
            {
                MessageBox.Show("Data was succesfully saved to .csv");
            }
            else
            {
                MessageBox.Show("Data was not saved");
            }
        }
        #endregion

        #region Serching for debitors
        private void btnSearchDebitors_Click(object sender, EventArgs e)
        {
            ucDebitorsGrid.Visible = true;
            ucCreditsGrid.Visible = ucPaymentsGrid.Visible = false;
            _dataInGrid = DataInGrid.SearchedDebitors;

            _dgvDebitors.DataSource = _debitorRepo.GetDebitors(txtSearchedFirstName.Text, txtSearchedLastName.Text, txtSearchedAddress.Text, txtSearchedPhone.Text);
            txtSearchedFirstName.Text = txtSearchedLastName.Text = txtSearchedAddress.Text = txtSearchedPhone.Text = String.Empty;
        }
        #endregion

        #region  Methods to get custom data
        private IEnumerable GetCustomCreditList(int debitorId = -1)
        {            
            IEnumerable<Debitor> debitors = _debitorRepo.GetDebitors();
            IEnumerable<TypeOfCredit> types = _typeRepo.GetTypes();
            //By default if debitorId == -1 we are searching for all credits in database otherwise we try to find credits for specified debitor
            IEnumerable<Credit> credits = debitorId == -1 ? _creditRepo.GetCredits() : _creditRepo.GetCredits(debitorId);


            var resultList = from credit in credits
                             join debitor in debitors on credit.DebitorId equals debitor.Id
                             join type in types on credit.TypeId equals type.Id
                             select new
                             {
                                 Id = credit.Id,
                                 FullName = string.Format("{0} {1}", debitor.FirstName, debitor.LastName),
                                 OpenDate = credit.OpenDate,
                                 Amount = credit.Amount,
                                 Balance = credit.Balance,
                                 CreditType = type.Type,
                                 State = credit.State,
                                 UserId = credit.UserId
                             };
            // Review DM: Missed space.
            var list = resultList.ToList();
            return list;
        }

        private IEnumerable GetCustomPaymentList(int creditId = -1)
        {
            IEnumerable<Debitor> debitors = _debitorRepo.GetDebitors();
            IEnumerable<Credit> credits = _creditRepo.GetCredits();
            //By default if creditId == -1 we are searching all payments and if ceditId is specified we try to find all payments for some credit
            IEnumerable<Payment> payments = creditId == -1 ? _paymentRepo.GetPayments() : _paymentRepo.GetPayments(creditId);

            var resultList = from payment in payments
                             join credit in credits on payment.CreditId equals credit.Id
                             join debitor in debitors on credit.DebitorId equals debitor.Id
                             select new
                             {
                                 PaymentId = payment.Id,
                                 CreditId = credit.Id,
                                 DebitorName = string.Format("{0} {1}", debitor.FirstName, debitor.LastName),
                                 PaymentAmount = payment.Amount,
                                 PaymentDate = payment.PaymentDate,
                                 CreditAmount = credit.Amount,
                                 CreditBalance = credit.Balance,
                                 CreditState = credit.State,
                                 UserId = payment.UserId
                             };
            // Review DM: Missed space.
            var list = resultList.ToList();
            return list;
        }
        #endregion
    }

    public enum DataInGrid
    {
        Debitors,
        SearchedDebitors,
        AllCredits,
        CreditsForDebitor,
        Payments,
        PaymentsForCredit
    }
}
