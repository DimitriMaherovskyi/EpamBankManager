namespace BankManager
{
    partial class CreditsGrid
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvCredits = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCredits
            // 
            this.dgvCredits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCredits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCredits.Location = new System.Drawing.Point(0, 0);
            this.dgvCredits.Name = "dgvCredits";
            this.dgvCredits.Size = new System.Drawing.Size(760, 360);
            this.dgvCredits.TabIndex = 0;
            // 
            // CreditsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCredits);
            this.Name = "CreditsGrid";
            this.Size = new System.Drawing.Size(760, 360);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCredits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCredits;
    }
}
