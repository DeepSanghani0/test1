
namespace TextProject
{
    partial class register
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
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.labelDesignation = new System.Windows.Forms.Label();
            this.cmbPermission = new System.Windows.Forms.ComboBox();
            this.labelpermission = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cmbinsertedby = new System.Windows.Forms.ComboBox();
            this.labelinsertedby = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Items.AddRange(new object[] {
            "M D",
            "C T O",
            "P M",
            "T L",
            "S D",
            "Trainee"});
            this.cmbDesignation.Location = new System.Drawing.Point(329, 240);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(222, 21);
            this.cmbDesignation.TabIndex = 19;
            // 
            // labelDesignation
            // 
            this.labelDesignation.AutoSize = true;
            this.labelDesignation.Location = new System.Drawing.Point(226, 248);
            this.labelDesignation.Name = "labelDesignation";
            this.labelDesignation.Size = new System.Drawing.Size(63, 13);
            this.labelDesignation.TabIndex = 18;
            this.labelDesignation.Text = "Designation";
            // 
            // cmbPermission
            // 
            this.cmbPermission.FormattingEnabled = true;
            this.cmbPermission.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbPermission.Location = new System.Drawing.Point(329, 199);
            this.cmbPermission.Name = "cmbPermission";
            this.cmbPermission.Size = new System.Drawing.Size(222, 21);
            this.cmbPermission.TabIndex = 17;
            // 
            // labelpermission
            // 
            this.labelpermission.AutoSize = true;
            this.labelpermission.Location = new System.Drawing.Point(226, 208);
            this.labelpermission.Name = "labelpermission";
            this.labelpermission.Size = new System.Drawing.Size(66, 13);
            this.labelpermission.TabIndex = 16;
            this.labelpermission.Text = "Permission : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(329, 160);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 15;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(226, 167);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(62, 13);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password : ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(329, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(329, 73);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(217, 20);
            this.txtName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(226, 80);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Name : ";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(329, 368);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 20;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cmbinsertedby
            // 
            this.cmbinsertedby.FormattingEnabled = true;
            this.cmbinsertedby.Items.AddRange(new object[] {
            "M D",
            "C T O",
            "P M",
            "T L",
            "S D",
            "Trainee"});
            this.cmbinsertedby.Location = new System.Drawing.Point(329, 283);
            this.cmbinsertedby.Name = "cmbinsertedby";
            this.cmbinsertedby.Size = new System.Drawing.Size(222, 21);
            this.cmbinsertedby.TabIndex = 22;
            // 
            // labelinsertedby
            // 
            this.labelinsertedby.AutoSize = true;
            this.labelinsertedby.Location = new System.Drawing.Point(226, 291);
            this.labelinsertedby.Name = "labelinsertedby";
            this.labelinsertedby.Size = new System.Drawing.Size(56, 13);
            this.labelinsertedby.TabIndex = 21;
            this.labelinsertedby.Text = "Insertedby";
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbinsertedby);
            this.Controls.Add(this.labelinsertedby);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.labelDesignation);
            this.Controls.Add(this.cmbPermission);
            this.Controls.Add(this.labelpermission);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labelName);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label labelDesignation;
        private System.Windows.Forms.ComboBox cmbPermission;
        private System.Windows.Forms.Label labelpermission;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cmbinsertedby;
        private System.Windows.Forms.Label labelinsertedby;
    }
}