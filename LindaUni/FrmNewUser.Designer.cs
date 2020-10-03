
namespace LindaUni
{
    partial class FrmNewUser
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.dateDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.comboUseType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(80, 36);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(140, 38);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "&UserName";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(226, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(639, 45);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(226, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(639, 45);
            this.txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Password";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(226, 239);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(639, 45);
            this.txtLastName.TabIndex = 5;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(77, 239);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(137, 38);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "&Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(226, 185);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(639, 45);
            this.txtFirstName.TabIndex = 4;
            this.txtFirstName.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(77, 192);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(143, 38);
            this.lblFirstName.TabIndex = 8;
            this.lblFirstName.Text = "&First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(226, 134);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(639, 45);
            this.txtPassword2.TabIndex = 3;
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Location = new System.Drawing.Point(1, 138);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(219, 38);
            this.lblPassword2.TabIndex = 10;
            this.lblPassword2.Text = "P&assword (Again)";
            // 
            // dateDOB
            // 
            this.dateDOB.Location = new System.Drawing.Point(226, 291);
            this.dateDOB.Name = "dateDOB";
            this.dateDOB.Size = new System.Drawing.Size(452, 45);
            this.dateDOB.TabIndex = 6;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(55, 296);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(165, 38);
            this.lblDOB.TabIndex = 13;
            this.lblDOB.Text = "&Date of Birth";
            // 
            // comboUseType
            // 
            this.comboUseType.FormattingEnabled = true;
            this.comboUseType.Items.AddRange(new object[] {
            "View",
            "Edit"});
            this.comboUseType.Location = new System.Drawing.Point(226, 343);
            this.comboUseType.Name = "comboUseType";
            this.comboUseType.Size = new System.Drawing.Size(452, 46);
            this.comboUseType.TabIndex = 7;
            this.comboUseType.SelectedIndexChanged += new System.EventHandler(this.comboUseType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 38);
            this.label1.TabIndex = 15;
            this.label1.Text = "User &Type";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(685, 420);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 70);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(40, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 70);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmNewUser
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(906, 524);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUseType);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.dateDOB);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.lblPassword2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FrmNewUser";
            this.Text = "Create New User";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.DateTimePicker dateDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.ComboBox comboUseType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}