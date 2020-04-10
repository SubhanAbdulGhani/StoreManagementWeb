namespace StoreManagementSystem
{
    partial class FrmDetailSalesContract
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUserMaster = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDetailSalesContract = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBuyer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSalesContractDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.brnApprove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSalesContract)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.brnApprove);
            this.panel1.Controls.Add(this.cmbApprovedBy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbUserMaster);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvDetailSalesContract);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbBuyer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpSalesContractDate);
            this.panel1.Location = new System.Drawing.Point(25, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 507);
            this.panel1.TabIndex = 0;
            // 
            // cmbApprovedBy
            // 
            this.cmbApprovedBy.FormattingEnabled = true;
            this.cmbApprovedBy.Location = new System.Drawing.Point(470, 133);
            this.cmbApprovedBy.Name = "cmbApprovedBy";
            this.cmbApprovedBy.Size = new System.Drawing.Size(121, 21);
            this.cmbApprovedBy.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(467, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Approved By :";
            // 
            // cmbUserMaster
            // 
            this.cmbUserMaster.FormattingEnabled = true;
            this.cmbUserMaster.Location = new System.Drawing.Point(28, 133);
            this.cmbUserMaster.Name = "cmbUserMaster";
            this.cmbUserMaster.Size = new System.Drawing.Size(121, 21);
            this.cmbUserMaster.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(68, 445);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDetailSalesContract
            // 
            this.dgvDetailSalesContract.AllowUserToAddRows = false;
            this.dgvDetailSalesContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailSalesContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Weight,
            this.Price,
            this.TotalAmount});
            this.dgvDetailSalesContract.Location = new System.Drawing.Point(31, 172);
            this.dgvDetailSalesContract.Name = "dgvDetailSalesContract";
            this.dgvDetailSalesContract.Size = new System.Drawing.Size(560, 256);
            this.dgvDetailSalesContract.TabIndex = 8;
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.Name = "Weight";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(628, 319);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(628, 275);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prepared By :";
            // 
            // cmbBuyer
            // 
            this.cmbBuyer.FormattingEnabled = true;
            this.cmbBuyer.Location = new System.Drawing.Point(470, 50);
            this.cmbBuyer.Name = "cmbBuyer";
            this.cmbBuyer.Size = new System.Drawing.Size(121, 21);
            this.cmbBuyer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buyer :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Contract Date :";
            // 
            // dtpSalesContractDate
            // 
            this.dtpSalesContractDate.Location = new System.Drawing.Point(28, 50);
            this.dtpSalesContractDate.Name = "dtpSalesContractDate";
            this.dtpSalesContractDate.Size = new System.Drawing.Size(200, 20);
            this.dtpSalesContractDate.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(259, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(253, 47);
            this.label4.TabIndex = 11;
            this.label4.Text = "SALES CONTRACT";
            // 
            // brnApprove
            // 
            this.brnApprove.Location = new System.Drawing.Point(485, 445);
            this.brnApprove.Name = "brnApprove";
            this.brnApprove.Size = new System.Drawing.Size(106, 43);
            this.brnApprove.TabIndex = 14;
            this.brnApprove.Text = "Approve";
            this.brnApprove.UseVisualStyleBackColor = true;
            this.brnApprove.Click += new System.EventHandler(this.brnApprove_Click);
            // 
            // FrmDetailSalesContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetailSalesContract";
            this.Text = "DETAIL SALES CONTRACT";
            this.Load += new System.EventHandler(this.FrmDetailSalesContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailSalesContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSalesContractDate;
        private System.Windows.Forms.ComboBox cmbBuyer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetailSalesContract;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbUserMaster;
        private System.Windows.Forms.ComboBox cmbApprovedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button brnApprove;
    }
}