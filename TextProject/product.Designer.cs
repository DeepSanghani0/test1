
namespace TextProject
{
    partial class product
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
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.Label();
            this.gp = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtpMDate = new System.Windows.Forms.DateTimePicker();
            this.labelMDate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.labelPName = new System.Windows.Forms.Label();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.labelPId = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.labeldesignation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(27, 50);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(500, 235);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProduct_RowHeaderMouseClick);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(397, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(35, 13);
            this.username.TabIndex = 1;
            this.username.Text = "label1";
            // 
            // gp
            // 
            this.gp.Controls.Add(this.btnDelete);
            this.gp.Controls.Add(this.btnUpdate);
            this.gp.Controls.Add(this.btnInsert);
            this.gp.Controls.Add(this.dtpMDate);
            this.gp.Controls.Add(this.labelMDate);
            this.gp.Controls.Add(this.txtPrice);
            this.gp.Controls.Add(this.labelPrice);
            this.gp.Controls.Add(this.txtProductName);
            this.gp.Controls.Add(this.labelPName);
            this.gp.Controls.Add(this.txtPId);
            this.gp.Controls.Add(this.labelPId);
            this.gp.Location = new System.Drawing.Point(68, 309);
            this.gp.Name = "gp";
            this.gp.Size = new System.Drawing.Size(445, 129);
            this.gp.TabIndex = 2;
            this.gp.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(265, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(57, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(166, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(67, 96);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(57, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtpMDate
            // 
            this.dtpMDate.Location = new System.Drawing.Point(277, 46);
            this.dtpMDate.Name = "dtpMDate";
            this.dtpMDate.Size = new System.Drawing.Size(136, 20);
            this.dtpMDate.TabIndex = 7;
            // 
            // labelMDate
            // 
            this.labelMDate.AutoSize = true;
            this.labelMDate.Location = new System.Drawing.Point(190, 54);
            this.labelMDate.Name = "labelMDate";
            this.labelMDate.Size = new System.Drawing.Size(45, 13);
            this.labelMDate.TabIndex = 6;
            this.labelMDate.Text = "MDate :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(67, 51);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(29, 54);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(40, 13);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Price : ";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(277, 9);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(136, 20);
            this.txtProductName.TabIndex = 3;
            // 
            // labelPName
            // 
            this.labelPName.AutoSize = true;
            this.labelPName.Location = new System.Drawing.Point(190, 16);
            this.labelPName.Name = "labelPName";
            this.labelPName.Size = new System.Drawing.Size(81, 13);
            this.labelPName.TabIndex = 2;
            this.labelPName.Text = "ProductName : ";
            // 
            // txtPId
            // 
            this.txtPId.Location = new System.Drawing.Point(67, 17);
            this.txtPId.Name = "txtPId";
            this.txtPId.ReadOnly = true;
            this.txtPId.Size = new System.Drawing.Size(100, 20);
            this.txtPId.TabIndex = 1;
            // 
            // labelPId
            // 
            this.labelPId.AutoSize = true;
            this.labelPId.Location = new System.Drawing.Point(29, 20);
            this.labelPId.Name = "labelPId";
            this.labelPId.Size = new System.Drawing.Size(32, 13);
            this.labelPId.TabIndex = 0;
            this.labelPId.Text = "PId : ";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(49, 13);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // labeldesignation
            // 
            this.labeldesignation.AutoSize = true;
            this.labeldesignation.Location = new System.Drawing.Point(450, 9);
            this.labeldesignation.Name = "labeldesignation";
            this.labeldesignation.Size = new System.Drawing.Size(63, 13);
            this.labeldesignation.TabIndex = 4;
            this.labeldesignation.Text = "Designation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Designation : ";
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeldesignation);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gp);
            this.Controls.Add(this.username);
            this.Controls.Add(this.dgvProduct);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.gp.ResumeLayout(false);
            this.gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.GroupBox gp;
        private System.Windows.Forms.Label labelPId;
        private System.Windows.Forms.Label labelMDate;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label labelPName;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtpMDate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Label labeldesignation;
        private System.Windows.Forms.Label label1;
    }
}