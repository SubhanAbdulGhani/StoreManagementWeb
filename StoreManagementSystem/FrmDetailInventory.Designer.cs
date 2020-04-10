namespace StoreManagementSystem
{
    partial class FrmDetailInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtUpdatedBy = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpUpdatedDate = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpUpdatedDate);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtUpdatedBy);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.txtProductID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ProductID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(97, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 367);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(184, 47);
            this.label1.TabIndex = 9;
            this.label1.Text = "INVENTORY";
            // 
            // ProductID
            // 
            this.ProductID.AutoSize = true;
            this.ProductID.Location = new System.Drawing.Point(43, 89);
            this.ProductID.Name = "ProductID";
            this.ProductID.Size = new System.Drawing.Size(55, 13);
            this.ProductID.TabIndex = 10;
            this.ProductID.Text = "ProductID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Updated Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Updated By";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(131, 89);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(279, 20);
            this.txtProductID.TabIndex = 14;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(131, 135);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(279, 20);
            this.txtQuantity.TabIndex = 15;
            // 
            // txtUpdatedBy
            // 
            this.txtUpdatedBy.Location = new System.Drawing.Point(131, 228);
            this.txtUpdatedBy.Name = "txtUpdatedBy";
            this.txtUpdatedBy.Size = new System.Drawing.Size(279, 20);
            this.txtUpdatedBy.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(149, 291);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 36);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpUpdatedDate
            // 
            this.dtpUpdatedDate.Location = new System.Drawing.Point(131, 175);
            this.dtpUpdatedDate.Name = "dtpUpdatedDate";
            this.dtpUpdatedDate.Size = new System.Drawing.Size(206, 20);
            this.dtpUpdatedDate.TabIndex = 20;
            // 
            // FrmDetailInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(689, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDetailInventory";
            this.Text = "FrmDetailInventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtUpdatedBy;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProductID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpUpdatedDate;
    }
}