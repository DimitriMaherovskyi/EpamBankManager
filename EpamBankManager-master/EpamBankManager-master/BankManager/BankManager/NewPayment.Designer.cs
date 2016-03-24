namespace Repositories
{
    partial class NewPayment
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
            this.lblCredits = new System.Windows.Forms.Label();
            this.dgvCredits = new System.Windows.Forms.DataGridView();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.lblPaymentAmount = new System.Windows.Forms.Label();
            this.btnPassPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(12, 34);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(39, 13);
            this.lblCredits.TabIndex = 0;
            this.lblCredits.Text = "Credits";
            // 
            // dgvCredits
            // 
            this.dgvCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredits.Location = new System.Drawing.Point(115, 12);
            this.dgvCredits.MultiSelect = false;
            this.dgvCredits.Name = "dgvCredits";
            this.dgvCredits.ReadOnly = true;
            this.dgvCredits.Size = new System.Drawing.Size(588, 113);
            this.dgvCredits.TabIndex = 6;
            this.dgvCredits.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCredits_CellEnter);
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(115, 154);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPaymentDate.TabIndex = 7;
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(12, 161);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(74, 13);
            this.lblPaymentDate.TabIndex = 8;
            this.lblPaymentDate.Text = "Payment Date";
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(115, 197);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(138, 20);
            this.txtPaymentAmount.TabIndex = 9;
            // 
            // lblPaymentAmount
            // 
            this.lblPaymentAmount.AutoSize = true;
            this.lblPaymentAmount.Location = new System.Drawing.Point(12, 204);
            this.lblPaymentAmount.Name = "lblPaymentAmount";
            this.lblPaymentAmount.Size = new System.Drawing.Size(87, 13);
            this.lblPaymentAmount.TabIndex = 10;
            this.lblPaymentAmount.Text = "Payment Amount";
            // 
            // btnPassPayment
            // 
            this.btnPassPayment.Location = new System.Drawing.Point(603, 231);
            this.btnPassPayment.Name = "btnPassPayment";
            this.btnPassPayment.Size = new System.Drawing.Size(100, 27);
            this.btnPassPayment.TabIndex = 11;
            this.btnPassPayment.Text = "Pass Payment";
            this.btnPassPayment.UseVisualStyleBackColor = true;
            this.btnPassPayment.Click += new System.EventHandler(this.btnPassPayment_Click);
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 270);
            this.Controls.Add(this.btnPassPayment);
            this.Controls.Add(this.lblPaymentAmount);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.dgvCredits);
            this.Controls.Add(this.lblCredits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPayment";
            this.Text = "NewPayment";
            this.Load += new System.EventHandler(this.NewPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.DataGridView dgvCredits;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.Label lblPaymentAmount;
        private System.Windows.Forms.Button btnPassPayment;
    }
}