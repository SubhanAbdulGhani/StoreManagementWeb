namespace StoreManagementSystem
{
    partial class FrmDetailPurchaseContract
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.cmbApprovedBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUserMaster = new System.Windows.Forms.ComboBox();
            this.dtpPurchaseContractDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvPurchaseContract = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSeller = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseContract)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.cmbApprovedBy);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbUserMaster);
            this.panel1.Controls.Add(this.dtpPurchaseContractDate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.dgvPurchaseContract);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbSeller);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(68, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 672);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(265, 601);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(98, 37);
            this.btnApprove.TabIndex = 15;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // cmbApprovedBy
            // 
            this.cmbApprovedBy.FormattingEnabled = true;
            this.cmbApprovedBy.Location = new System.Drawing.Point(433, 138);
            this.cmbApprovedBy.Name = "cmbApprovedBy";
            this.cmbApprovedBy.Size = new System.Drawing.Size(104, 21);
            this.cmbApprovedBy.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 112);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Approved By :";
            // 
            // cmbUserMaster
            // 
            this.cmbUserMaster.FormattingEnabled = true;
            this.cmbUserMaster.Location = new System.Drawing.Point(41, 138);
            this.cmbUserMaster.Name = "cmbUserMaster";
            this.cmbUserMaster.Size = new System.Drawing.Size(137, 21);
            this.cmbUserMaster.TabIndex = 12;
            // 
            // dtpPurchaseContractDate
            // 
            this.dtpPurchaseContractDate.Location = new System.Drawing.Point(41, 58);
            this.dtpPurchaseContractDate.Name = "dtpPurchaseContractDate";
            this.dtpPurchaseContractDate.Size = new System.Drawing.Size(200, 20);
            this.dtpPurchaseContractDate.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(566, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(566, 324);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 601);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 37);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(71, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(146, 37);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPurchaseContract
            // 
            this.dgvPurchaseContract.AllowUserToAddRows = false;
            this.dgvPurchaseContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Weight,
            this.Price,
            this.TotalAmount});
            this.dgvPurchaseContract.Location = new System.Drawing.Point(41, 192);
            this.dgvPurchaseContract.Name = "dgvPurchaseContract";
            this.dgvPurchaseContract.Size = new System.Drawing.Size(506, 362);
            this.dgvPurchaseContract.TabIndex = 6;
            this.dgvPurchaseContract.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 31);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Seller :-";
            // 
            // cmbSeller
            // 
            this.cmbSeller.FormattingEnabled = true;
            this.cmbSeller.Location = new System.Drawing.Point(433, 57);
            this.cmbSeller.Name = "cmbSeller";
            this.cmbSeller.Size = new System.Drawing.Size(104, 21);
            this.cmbSeller.TabIndex = 2;
            this.cmbSeller.SelectedIndexChanged += new System.EventHandler(this.cmbSeller_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 112);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prepared By :-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purchase Contract Date :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(255, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10);
            this.label4.Size = new System.Drawing.Size(310, 47);
            this.label4.TabIndex = 12;
            this.label4.Text = "PURCHASE CONTRACT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmDetailPurchaseContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetailPurchaseContract";
            this.Text = "DETAIL PURCHASE CONTRACT";
            this.Load += new System.EventHandler(this.FrmDetailPurchaseContract_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvPurchaseContract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSeller;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpPurchaseContractDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.ComboBox cmbUserMaster;
        private System.Windows.Forms.ComboBox cmbApprovedBy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnApprove;
    }
}