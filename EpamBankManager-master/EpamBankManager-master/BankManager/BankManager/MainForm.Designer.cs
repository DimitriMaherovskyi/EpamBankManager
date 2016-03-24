namespace Repositories
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbx_Data = new System.Windows.Forms.GroupBox();
            this.ucDebitorsGrid = new BankManager.DebitorsGrid();
            this.ucCreditsGrid = new BankManager.CreditsGrid();
            this.ucPaymentsGrid = new BankManager.PaymentsGrid();
            this.cntxms_GridMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAllDebitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewDebitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openNewCreditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passNewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSearchForDebitor = new System.Windows.Forms.GroupBox();
            this.btnSearchDebitors = new System.Windows.Forms.Button();
            this.lblSearchedPhone = new System.Windows.Forms.Label();
            this.txtSearchedPhone = new System.Windows.Forms.TextBox();
            this.lblSearchedAddress = new System.Windows.Forms.Label();
            this.txtSearchedAddress = new System.Windows.Forms.TextBox();
            this.lblSearchedLastName = new System.Windows.Forms.Label();
            this.txtSearchedLastName = new System.Windows.Forms.TextBox();
            this.lblSearchedFirstName = new System.Windows.Forms.Label();
            this.txtSearchedFirstName = new System.Windows.Forms.TextBox();
            this.grbx_Data.SuspendLayout();
            this.cntxms_GridMenu.SuspendLayout();
            this.ms_main.SuspendLayout();
            this.grbSearchForDebitor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_Data
            // 
            this.grbx_Data.Controls.Add(this.ucDebitorsGrid);
            this.grbx_Data.Controls.Add(this.ucCreditsGrid);
            this.grbx_Data.Controls.Add(this.ucPaymentsGrid);
            this.grbx_Data.Location = new System.Drawing.Point(12, 82);
            this.grbx_Data.Name = "grbx_Data";
            this.grbx_Data.Size = new System.Drawing.Size(830, 366);
            this.grbx_Data.TabIndex = 0;
            this.grbx_Data.TabStop = false;
            this.grbx_Data.Text = "Data";
            // 
            // ucDebitorsGrid
            // 
            this.ucDebitorsGrid.Location = new System.Drawing.Point(0, 14);
            this.ucDebitorsGrid.Name = "ucDebitorsGrid";
            this.ucDebitorsGrid.Size = new System.Drawing.Size(830, 360);
            this.ucDebitorsGrid.TabIndex = 3;
            // 
            // ucCreditsGrid
            // 
            this.ucCreditsGrid.Location = new System.Drawing.Point(0, 14);
            this.ucCreditsGrid.Name = "ucCreditsGrid";
            this.ucCreditsGrid.Size = new System.Drawing.Size(830, 360);
            this.ucCreditsGrid.TabIndex = 2;
            // 
            // ucPaymentsGrid
            // 
            this.ucPaymentsGrid.Location = new System.Drawing.Point(0, 14);
            this.ucPaymentsGrid.Name = "ucPaymentsGrid";
            this.ucPaymentsGrid.Size = new System.Drawing.Size(830, 360);
            this.ucPaymentsGrid.TabIndex = 1;
            // 
            // cntxms_GridMenu
            // 
            this.cntxms_GridMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllDebitorsToolStripMenuItem,
            this.showAllCreditsToolStripMenuItem,
            this.showAllPaymentsToolStripMenuItem,
            this.newDebitorToolStripMenuItem,
            this.newCreditToolStripMenuItem,
            this.newPaymentToolStripMenuItem});
            this.cntxms_GridMenu.Name = "cntxms_GridMenu";
            this.cntxms_GridMenu.Size = new System.Drawing.Size(174, 136);
            // 
            // showAllDebitorsToolStripMenuItem
            // 
            this.showAllDebitorsToolStripMenuItem.Name = "showAllDebitorsToolStripMenuItem";
            this.showAllDebitorsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllDebitorsToolStripMenuItem.Text = "Show all debitors";
            this.showAllDebitorsToolStripMenuItem.Click += new System.EventHandler(this.showAllDebitorsToolStripMenuItem_Click);
            // 
            // showAllCreditsToolStripMenuItem
            // 
            this.showAllCreditsToolStripMenuItem.Name = "showAllCreditsToolStripMenuItem";
            this.showAllCreditsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllCreditsToolStripMenuItem.Text = "Show all credits";
            this.showAllCreditsToolStripMenuItem.Click += new System.EventHandler(this.showAllCreditsToolStripMenuItem_Click);
            // 
            // showAllPaymentsToolStripMenuItem
            // 
            this.showAllPaymentsToolStripMenuItem.Name = "showAllPaymentsToolStripMenuItem";
            this.showAllPaymentsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.showAllPaymentsToolStripMenuItem.Text = "Show all payments";
            this.showAllPaymentsToolStripMenuItem.Click += new System.EventHandler(this.showAllPaymentsToolStripMenuItem_Click);
            // 
            // newDebitorToolStripMenuItem
            // 
            this.newDebitorToolStripMenuItem.Name = "newDebitorToolStripMenuItem";
            this.newDebitorToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newDebitorToolStripMenuItem.Text = "New debitor";
            this.newDebitorToolStripMenuItem.Click += new System.EventHandler(this.newDebitorToolStripMenuItem_Click);
            // 
            // newCreditToolStripMenuItem
            // 
            this.newCreditToolStripMenuItem.Name = "newCreditToolStripMenuItem";
            this.newCreditToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newCreditToolStripMenuItem.Text = "New credit";
            this.newCreditToolStripMenuItem.Click += new System.EventHandler(this.newCreditToolStripMenuItem_Click);
            // 
            // newPaymentToolStripMenuItem
            // 
            this.newPaymentToolStripMenuItem.Name = "newPaymentToolStripMenuItem";
            this.newPaymentToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.newPaymentToolStripMenuItem.Text = "New payment";
            this.newPaymentToolStripMenuItem.Click += new System.EventHandler(this.newPaymentToolStripMenuItem_Click);
            // 
            // ms_main
            // 
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.debitorsToolStripMenuItem,
            this.creditsToolStripMenuItem,
            this.paymentsToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(884, 24);
            this.ms_main.TabIndex = 1;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // debitorsToolStripMenuItem
            // 
            this.debitorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewDebitorToolStripMenuItem});
            this.debitorsToolStripMenuItem.Name = "debitorsToolStripMenuItem";
            this.debitorsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.debitorsToolStripMenuItem.Text = "Debitors";
            // 
            // addNewDebitorToolStripMenuItem
            // 
            this.addNewDebitorToolStripMenuItem.Name = "addNewDebitorToolStripMenuItem";
            this.addNewDebitorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addNewDebitorToolStripMenuItem.Text = "Add new debitor";
            this.addNewDebitorToolStripMenuItem.Click += new System.EventHandler(this.addNewDebitorToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openNewCreditToolStripMenuItem});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // openNewCreditToolStripMenuItem
            // 
            this.openNewCreditToolStripMenuItem.Name = "openNewCreditToolStripMenuItem";
            this.openNewCreditToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openNewCreditToolStripMenuItem.Text = "Open new credit";
            this.openNewCreditToolStripMenuItem.Click += new System.EventHandler(this.openNewCreditToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passNewPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // passNewPaymentToolStripMenuItem
            // 
            this.passNewPaymentToolStripMenuItem.Name = "passNewPaymentToolStripMenuItem";
            this.passNewPaymentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.passNewPaymentToolStripMenuItem.Text = "Pass new payment";
            this.passNewPaymentToolStripMenuItem.Click += new System.EventHandler(this.passNewPaymentToolStripMenuItem_Click);
            // 
            // grbSearchForDebitor
            // 
            this.grbSearchForDebitor.Controls.Add(this.btnSearchDebitors);
            this.grbSearchForDebitor.Controls.Add(this.lblSearchedPhone);
            this.grbSearchForDebitor.Controls.Add(this.txtSearchedPhone);
            this.grbSearchForDebitor.Controls.Add(this.lblSearchedAddress);
            this.grbSearchForDebitor.Controls.Add(this.txtSearchedAddress);
            this.grbSearchForDebitor.Controls.Add(this.lblSearchedLastName);
            this.grbSearchForDebitor.Controls.Add(this.txtSearchedLastName);
            this.grbSearchForDebitor.Controls.Add(this.lblSearchedFirstName);
            this.grbSearchForDebitor.Controls.Add(this.txtSearchedFirstName);
            this.grbSearchForDebitor.Location = new System.Drawing.Point(12, 27);
            this.grbSearchForDebitor.Name = "grbSearchForDebitor";
            this.grbSearchForDebitor.Size = new System.Drawing.Size(830, 49);
            this.grbSearchForDebitor.TabIndex = 2;
            this.grbSearchForDebitor.TabStop = false;
            this.grbSearchForDebitor.Text = "Search Debitors";
            // 
            // btnSearchDebitors
            // 
            this.btnSearchDebitors.Location = new System.Drawing.Point(724, 16);
            this.btnSearchDebitors.Name = "btnSearchDebitors";
            this.btnSearchDebitors.Size = new System.Drawing.Size(100, 23);
            this.btnSearchDebitors.TabIndex = 8;
            this.btnSearchDebitors.Text = "Go";
            this.btnSearchDebitors.UseVisualStyleBackColor = true;
            this.btnSearchDebitors.Click += new System.EventHandler(this.btnSearchDebitors_Click);
            // 
            // lblSearchedPhone
            // 
            this.lblSearchedPhone.AutoSize = true;
            this.lblSearchedPhone.Location = new System.Drawing.Point(535, 21);
            this.lblSearchedPhone.Name = "lblSearchedPhone";
            this.lblSearchedPhone.Size = new System.Drawing.Size(38, 13);
            this.lblSearchedPhone.TabIndex = 7;
            this.lblSearchedPhone.Text = "Phone";
            // 
            // txtSearchedPhone
            // 
            this.txtSearchedPhone.Location = new System.Drawing.Point(579, 18);
            this.txtSearchedPhone.Name = "txtSearchedPhone";
            this.txtSearchedPhone.Size = new System.Drawing.Size(109, 20);
            this.txtSearchedPhone.TabIndex = 6;
            // 
            // lblSearchedAddress
            // 
            this.lblSearchedAddress.AutoSize = true;
            this.lblSearchedAddress.Location = new System.Drawing.Point(368, 21);
            this.lblSearchedAddress.Name = "lblSearchedAddress";
            this.lblSearchedAddress.Size = new System.Drawing.Size(45, 13);
            this.lblSearchedAddress.TabIndex = 5;
            this.lblSearchedAddress.Text = "Address";
            // 
            // txtSearchedAddress
            // 
            this.txtSearchedAddress.Location = new System.Drawing.Point(419, 18);
            this.txtSearchedAddress.Name = "txtSearchedAddress";
            this.txtSearchedAddress.Size = new System.Drawing.Size(109, 20);
            this.txtSearchedAddress.TabIndex = 4;
            // 
            // lblSearchedLastName
            // 
            this.lblSearchedLastName.AutoSize = true;
            this.lblSearchedLastName.Location = new System.Drawing.Point(184, 21);
            this.lblSearchedLastName.Name = "lblSearchedLastName";
            this.lblSearchedLastName.Size = new System.Drawing.Size(58, 13);
            this.lblSearchedLastName.TabIndex = 3;
            this.lblSearchedLastName.Text = "Last Name";
            // 
            // txtSearchedLastName
            // 
            this.txtSearchedLastName.Location = new System.Drawing.Point(248, 18);
            this.txtSearchedLastName.Name = "txtSearchedLastName";
            this.txtSearchedLastName.Size = new System.Drawing.Size(109, 20);
            this.txtSearchedLastName.TabIndex = 2;
            // 
            // lblSearchedFirstName
            // 
            this.lblSearchedFirstName.AutoSize = true;
            this.lblSearchedFirstName.Location = new System.Drawing.Point(6, 21);
            this.lblSearchedFirstName.Name = "lblSearchedFirstName";
            this.lblSearchedFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblSearchedFirstName.TabIndex = 1;
            this.lblSearchedFirstName.Text = "First Name";
            // 
            // txtSearchedFirstName
            // 
            this.txtSearchedFirstName.Location = new System.Drawing.Point(70, 18);
            this.txtSearchedFirstName.Name = "txtSearchedFirstName";
            this.txtSearchedFirstName.Size = new System.Drawing.Size(109, 20);
            this.txtSearchedFirstName.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 475);
            this.Controls.Add(this.grbSearchForDebitor);
            this.Controls.Add(this.ms_main);
            this.Controls.Add(this.grbx_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ms_main;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Bank Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbx_Data.ResumeLayout(false);
            this.cntxms_GridMenu.ResumeLayout(false);
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.grbSearchForDebitor.ResumeLayout(false);
            this.grbSearchForDebitor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_Data;
        private System.Windows.Forms.ContextMenuStrip cntxms_GridMenu;
        private System.Windows.Forms.ToolStripMenuItem showAllDebitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCreditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllPaymentsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openNewCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passNewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDebitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCreditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPaymentToolStripMenuItem;
        private BankManager.DebitorsGrid ucDebitorsGrid;
        private BankManager.CreditsGrid ucCreditsGrid;
        private BankManager.PaymentsGrid ucPaymentsGrid;
        private System.Windows.Forms.GroupBox grbSearchForDebitor;
        private System.Windows.Forms.Label lblSearchedFirstName;
        private System.Windows.Forms.TextBox txtSearchedFirstName;
        private System.Windows.Forms.Label lblSearchedPhone;
        private System.Windows.Forms.TextBox txtSearchedPhone;
        private System.Windows.Forms.Label lblSearchedAddress;
        private System.Windows.Forms.TextBox txtSearchedAddress;
        private System.Windows.Forms.Label lblSearchedLastName;
        private System.Windows.Forms.TextBox txtSearchedLastName;
        private System.Windows.Forms.Button btnSearchDebitors;
    }
}

