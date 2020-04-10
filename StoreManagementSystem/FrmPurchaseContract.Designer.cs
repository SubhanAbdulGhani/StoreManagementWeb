namespace StoreManagementSystem
{
    partial class FrmPurchaseContract
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
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dgvPurchaseContract = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseContract)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.dgvPurchaseContract);
            this.panel1.Location = new System.Drawing.Point(64, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 392);
            this.panel1.TabIndex = 0;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(509, 329);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(158, 39);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(278, 329);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(158, 39);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(31, 329);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(158, 39);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvPurchaseContract
            // 
            this.dgvPurchaseContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseContract.Location = new System.Drawing.Point(31, 12);
            this.dgvPurchaseContract.Name = "dgvPurchaseContract";
            this.dgvPurchaseContract.Size = new System.Drawing.Size(636, 284);
            this.dgvPurchaseContract.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(310, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "PURCHASE CONTRACT";
            // 
            // FrmPurchaseContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPurchaseContract";
            this.Text = "PURCHASE CONTRACT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPurchaseContract_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dgvPurchaseContract;
        private System.Windows.Forms.Label label1;
    }
}