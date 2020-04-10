namespace StoreManagementSystem
{
    partial class FrmDetailProduct
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
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbProductCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(60, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 375);
            this.panel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(308, 299);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 33);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(151, 299);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(108, 33);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(151, 223);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(208, 20);
            this.txtColor.TabIndex = 7;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(151, 168);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(208, 20);
            this.txtType.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // cmbProductCategory
            // 
            this.cmbProductCategory.FormattingEnabled = true;
            this.cmbProductCategory.Location = new System.Drawing.Point(151, 18);
            this.cmbProductCategory.Name = "cmbProductCategory";
            this.cmbProductCategory.Size = new System.Drawing.Size(208, 21);
            this.cmbProductCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Category :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(244, 9);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10);
            this.label5.Size = new System.Drawing.Size(165, 47);
            this.label5.TabIndex = 10;
            this.label5.Text = "PRODUCTS";
            // 
            // FrmDetailProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 471);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetailProduct";
            this.Text = "DETAIL PRODUCTS";
            this.Load += new System.EventHandler(this.FrmDetailProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbProductCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}