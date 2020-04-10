namespace StoreManagementSystem
{
    partial class frmRawMaterial
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
            this.btnEditRawMaterial = new System.Windows.Forms.Button();
            this.btnDeleteRawMaterial = new System.Windows.Forms.Button();
            this.btnAddRawMaterial = new System.Windows.Forms.Button();
            this.dgvRawMaterial = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEditRawMaterial);
            this.panel1.Controls.Add(this.btnDeleteRawMaterial);
            this.panel1.Controls.Add(this.btnAddRawMaterial);
            this.panel1.Controls.Add(this.dgvRawMaterial);
            this.panel1.Location = new System.Drawing.Point(80, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 330);
            this.panel1.TabIndex = 0;
            // 
            // btnEditRawMaterial
            // 
            this.btnEditRawMaterial.Location = new System.Drawing.Point(355, 283);
            this.btnEditRawMaterial.Name = "btnEditRawMaterial";
            this.btnEditRawMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnEditRawMaterial.TabIndex = 3;
            this.btnEditRawMaterial.Text = "Edit";
            this.btnEditRawMaterial.UseVisualStyleBackColor = true;
            this.btnEditRawMaterial.Click += new System.EventHandler(this.btnUpdateRawMaterial_Click);
            // 
            // btnDeleteRawMaterial
            // 
            this.btnDeleteRawMaterial.Location = new System.Drawing.Point(215, 283);
            this.btnDeleteRawMaterial.Name = "btnDeleteRawMaterial";
            this.btnDeleteRawMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRawMaterial.TabIndex = 2;
            this.btnDeleteRawMaterial.Text = "Delete";
            this.btnDeleteRawMaterial.UseVisualStyleBackColor = true;
            this.btnDeleteRawMaterial.Click += new System.EventHandler(this.btnDeleteRawMaterial_Click);
            // 
            // btnAddRawMaterial
            // 
            this.btnAddRawMaterial.Location = new System.Drawing.Point(51, 283);
            this.btnAddRawMaterial.Name = "btnAddRawMaterial";
            this.btnAddRawMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAddRawMaterial.TabIndex = 1;
            this.btnAddRawMaterial.Text = "Add";
            this.btnAddRawMaterial.UseVisualStyleBackColor = true;
            this.btnAddRawMaterial.Click += new System.EventHandler(this.btnAddRawMaterial_Click);
            // 
            // dgvRawMaterial
            // 
            this.dgvRawMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRawMaterial.Location = new System.Drawing.Point(19, 18);
            this.dgvRawMaterial.Name = "dgvRawMaterial";
            this.dgvRawMaterial.Size = new System.Drawing.Size(465, 252);
            this.dgvRawMaterial.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(210, 29);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(240, 47);
            this.label1.TabIndex = 6;
            this.label1.Text = "RAW MATERIAL";
            // 
            // frmRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "frmRawMaterial";
            this.Text = "RAW MATERIAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRawMaterial_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRawMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditRawMaterial;
        private System.Windows.Forms.Button btnDeleteRawMaterial;
        private System.Windows.Forms.Button btnAddRawMaterial;
        private System.Windows.Forms.DataGridView dgvRawMaterial;
        private System.Windows.Forms.Label label1;
    }
}