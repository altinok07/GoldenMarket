namespace GoldenMarket.WinForm
{
    partial class frmProductManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.coboxCompanyName = new System.Windows.Forms.ComboBox();
            this.coboxProductType = new System.Windows.Forms.ComboBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.chboxIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ürün Türü :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Barkod :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Alış Fiyatı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Satış Fiyatı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Durum :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(93, 17);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // coboxCompanyName
            // 
            this.coboxCompanyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coboxCompanyName.FormattingEnabled = true;
            this.coboxCompanyName.Location = new System.Drawing.Point(93, 88);
            this.coboxCompanyName.Name = "coboxCompanyName";
            this.coboxCompanyName.Size = new System.Drawing.Size(121, 21);
            this.coboxCompanyName.TabIndex = 3;
            // 
            // coboxProductType
            // 
            this.coboxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coboxProductType.FormattingEnabled = true;
            this.coboxProductType.Location = new System.Drawing.Point(93, 52);
            this.coboxProductType.Name = "coboxProductType";
            this.coboxProductType.Size = new System.Drawing.Size(121, 21);
            this.coboxProductType.TabIndex = 4;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(333, 17);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(121, 20);
            this.txtBarcode.TabIndex = 2;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(333, 48);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 20);
            this.txtPrice.TabIndex = 2;
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(333, 81);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(121, 20);
            this.txtSales.TabIndex = 2;
            // 
            // chboxIsActive
            // 
            this.chboxIsActive.AutoSize = true;
            this.chboxIsActive.Location = new System.Drawing.Point(91, 131);
            this.chboxIsActive.Name = "chboxIsActive";
            this.chboxIsActive.Size = new System.Drawing.Size(15, 14);
            this.chboxIsActive.TabIndex = 5;
            this.chboxIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(204, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 222);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chboxIsActive);
            this.Controls.Add(this.coboxProductType);
            this.Controls.Add(this.coboxCompanyName);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProductManager";
            this.Text = "frmProductManager";
            this.Load += new System.EventHandler(this.frmProductManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox coboxCompanyName;
        private System.Windows.Forms.ComboBox coboxProductType;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.CheckBox chboxIsActive;
        private System.Windows.Forms.Button btnSave;
    }
}