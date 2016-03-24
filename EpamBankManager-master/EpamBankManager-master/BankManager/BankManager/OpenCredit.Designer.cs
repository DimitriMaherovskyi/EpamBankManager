namespace Repositories
{
    partial class OpenCredit
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
            this.lblDebitors = new System.Windows.Forms.Label();
            this.lblOpenDate = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.dgvDebitors = new System.Windows.Forms.DataGridView();
            this.dtpCreditOpenDate = new System.Windows.Forms.DateTimePicker();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.txtCreditBalance = new System.Windows.Forms.TextBox();
            this.txtCreditState = new System.Windows.Forms.TextBox();
            this.btnOpenNewCredit = new System.Windows.Forms.Button();
            this.lblTypeId = new System.Windows.Forms.Label();
            this.txtTypeId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDebitors
            // 
            this.lblDebitors.AutoSize = true;
            this.lblDebitors.Location = new System.Drawing.Point(31, 32);
            this.lblDebitors.Name = "lblDebitors";
            this.lblDebitors.Size = new System.Drawing.Size(46, 13);
            this.lblDebitors.TabIndex = 0;
            this.lblDebitors.Text = "Debitors";
            // 
            // lblOpenDate
            // 
            this.lblOpenDate.AutoSize = true;
            this.lblOpenDate.Location = new System.Drawing.Point(31, 143);
            this.lblOpenDate.Name = "lblOpenDate";
            this.lblOpenDate.Size = new System.Drawing.Size(56, 13);
            this.lblOpenDate.TabIndex = 1;
            this.lblOpenDate.Text = "OpenDate";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(31, 180);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(31, 219);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(31, 280);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 4;
            this.lblState.Text = "State";
            // 
            // dgvDebitors
            // 
            this.dgvDebitors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDebitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDebitors.Location = new System.Drawing.Point(125, 12);
            this.dgvDebitors.MultiSelect = false;
            this.dgvDebitors.Name = "dgvDebitors";
            this.dgvDebitors.ReadOnly = true;
            this.dgvDebitors.Size = new System.Drawing.Size(458, 113);
            this.dgvDebitors.TabIndex = 5;
            this.dgvDebitors.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDebitors_CellEnter);
            // 
            // dtpCreditOpenDate
            // 
            this.dtpCreditOpenDate.Location = new System.Drawing.Point(125, 143);
            this.dtpCreditOpenDate.Name = "dtpCreditOpenDate";
            this.dtpCreditOpenDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreditOpenDate.TabIndex = 6;
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Location = new System.Drawing.Point(125, 180);
            this.txtCreditAmount.MaxLength = 12;
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(147, 20);
            this.txtCreditAmount.TabIndex = 7;
            this.txtCreditAmount.TextChanged += new System.EventHandler(this.txtCreditAmount_TextChanged);
            // 
            // txtCreditBalance
            // 
            this.txtCreditBalance.Location = new System.Drawing.Point(125, 215);
            this.txtCreditBalance.Name = "txtCreditBalance";
            this.txtCreditBalance.ReadOnly = true;
            this.txtCreditBalance.Size = new System.Drawing.Size(147, 20);
            this.txtCreditBalance.TabIndex = 8;
            // 
            // txtCreditState
            // 
            this.txtCreditState.Location = new System.Drawing.Point(125, 277);
            this.txtCreditState.Name = "txtCreditState";
            this.txtCreditState.ReadOnly = true;
            this.txtCreditState.Size = new System.Drawing.Size(147, 20);
            this.txtCreditState.TabIndex = 9;
            this.txtCreditState.Text = "Active";
            // 
            // btnOpenNewCredit
            // 
            this.btnOpenNewCredit.Location = new System.Drawing.Point(483, 270);
            this.btnOpenNewCredit.Name = "btnOpenNewCredit";
            this.btnOpenNewCredit.Size = new System.Drawing.Size(100, 27);
            this.btnOpenNewCredit.TabIndex = 10;
            this.btnOpenNewCredit.Text = "Open Credit";
            this.btnOpenNewCredit.UseVisualStyleBackColor = true;
            this.btnOpenNewCredit.Click += new System.EventHandler(this.btnOpenNewCredit_Click);
            // 
            // lblTypeId
            // 
            this.lblTypeId.AutoSize = true;
            this.lblTypeId.Location = new System.Drawing.Point(31, 249);
            this.lblTypeId.Name = "lblTypeId";
            this.lblTypeId.Size = new System.Drawing.Size(40, 13);
            this.lblTypeId.TabIndex = 11;
            this.lblTypeId.Text = "TypeId";
            // 
            // txtTypeId
            // 
            this.txtTypeId.Location = new System.Drawing.Point(125, 246);
            this.txtTypeId.Name = "txtTypeId";
            this.txtTypeId.Size = new System.Drawing.Size(147, 20);
            this.txtTypeId.TabIndex = 12;
            // 
            // OpenCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 333);
            this.Controls.Add(this.txtTypeId);
            this.Controls.Add(this.lblTypeId);
            this.Controls.Add(this.btnOpenNewCredit);
            this.Controls.Add(this.txtCreditState);
            this.Controls.Add(this.txtCreditBalance);
            this.Controls.Add(this.txtCreditAmount);
            this.Controls.Add(this.dtpCreditOpenDate);
            this.Controls.Add(this.dgvDebitors);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblOpenDate);
            this.Controls.Add(this.lblDebitors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpenCredit";
            this.Text = "OpenCredit";
            this.Load += new System.EventHandler(this.OpenCredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDebitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDebitors;
        private System.Windows.Forms.Label lblOpenDate;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridView dgvDebitors;
        private System.Windows.Forms.DateTimePicker dtpCreditOpenDate;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.TextBox txtCreditBalance;
        private System.Windows.Forms.TextBox txtCreditState;
        private System.Windows.Forms.Button btnOpenNewCredit;
        private System.Windows.Forms.Label lblTypeId;
        private System.Windows.Forms.TextBox txtTypeId;
    }
}