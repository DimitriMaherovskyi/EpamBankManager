namespace Repositories
{
    partial class NewDebitor
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
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.btn_addNewDebitor = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(143, 26);
            this.txt_FirstName.MaxLength = 50;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(169, 20);
            this.txt_FirstName.TabIndex = 0;
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(143, 138);
            this.txt_PhoneNumber.MaxLength = 12;
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(169, 20);
            this.txt_PhoneNumber.TabIndex = 1;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(143, 64);
            this.txt_LastName.MaxLength = 50;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(169, 20);
            this.txt_LastName.TabIndex = 2;
            // 
            // btn_addNewDebitor
            // 
            this.btn_addNewDebitor.Location = new System.Drawing.Point(237, 164);
            this.btn_addNewDebitor.Name = "btn_addNewDebitor";
            this.btn_addNewDebitor.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewDebitor.TabIndex = 3;
            this.btn_addNewDebitor.Text = "Add Debitor";
            this.btn_addNewDebitor.UseVisualStyleBackColor = true;
            this.btn_addNewDebitor.Click += new System.EventHandler(this.btn_addNewDebitor_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(20, 28);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(99, 13);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "Debitors First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(20, 68);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 13);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Debitors Last Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(20, 141);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(120, 13);
            this.lblPhoneNumber.TabIndex = 6;
            this.lblPhoneNumber.Text = "Debitors Phone Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 108);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(87, 13);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Debitors Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(143, 104);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(169, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // NewDebitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 199);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btn_addNewDebitor);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.txt_PhoneNumber);
            this.Controls.Add(this.txt_FirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewDebitor";
            this.Text = "NewDebitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Button btn_addNewDebitor;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
    }
}