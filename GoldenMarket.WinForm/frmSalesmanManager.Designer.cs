namespace GoldenMarket.WinForm
{
    partial class frmSalesmanManager
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
            this.txtSalesmanName = new System.Windows.Forms.TextBox();
            this.txtSalesmanPhone = new System.Windows.Forms.TextBox();
            this.txtSalesmanMail = new System.Windows.Forms.TextBox();
            this.coboxSalesmanCompany = new System.Windows.Forms.ComboBox();
            this.chboxIsActive = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plasiyer Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Firma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Durum:";
            // 
            // txtSalesmanName
            // 
            this.txtSalesmanName.Location = new System.Drawing.Point(127, 30);
            this.txtSalesmanName.Name = "txtSalesmanName";
            this.txtSalesmanName.Size = new System.Drawing.Size(130, 20);
            this.txtSalesmanName.TabIndex = 2;
            // 
            // txtSalesmanPhone
            // 
            this.txtSalesmanPhone.Location = new System.Drawing.Point(127, 78);
            this.txtSalesmanPhone.Name = "txtSalesmanPhone";
            this.txtSalesmanPhone.Size = new System.Drawing.Size(130, 20);
            this.txtSalesmanPhone.TabIndex = 2;
            // 
            // txtSalesmanMail
            // 
            this.txtSalesmanMail.Location = new System.Drawing.Point(375, 30);
            this.txtSalesmanMail.Name = "txtSalesmanMail";
            this.txtSalesmanMail.Size = new System.Drawing.Size(130, 20);
            this.txtSalesmanMail.TabIndex = 2;
            // 
            // coboxSalesmanCompany
            // 
            this.coboxSalesmanCompany.FormattingEnabled = true;
            this.coboxSalesmanCompany.Location = new System.Drawing.Point(375, 78);
            this.coboxSalesmanCompany.Name = "coboxSalesmanCompany";
            this.coboxSalesmanCompany.Size = new System.Drawing.Size(130, 21);
            this.coboxSalesmanCompany.TabIndex = 3;
            // 
            // chboxIsActive
            // 
            this.chboxIsActive.AutoSize = true;
            this.chboxIsActive.Location = new System.Drawing.Point(179, 131);
            this.chboxIsActive.Name = "chboxIsActive";
            this.chboxIsActive.Size = new System.Drawing.Size(15, 14);
            this.chboxIsActive.TabIndex = 4;
            this.chboxIsActive.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSalesmanManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 211);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chboxIsActive);
            this.Controls.Add(this.coboxSalesmanCompany);
            this.Controls.Add(this.txtSalesmanMail);
            this.Controls.Add(this.txtSalesmanPhone);
            this.Controls.Add(this.txtSalesmanName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesmanManager";
            this.Text = "frmSalesmanManager";
            this.Load += new System.EventHandler(this.frmSalesmanManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalesmanName;
        private System.Windows.Forms.TextBox txtSalesmanPhone;
        private System.Windows.Forms.TextBox txtSalesmanMail;
        private System.Windows.Forms.ComboBox coboxSalesmanCompany;
        private System.Windows.Forms.CheckBox chboxIsActive;
        private System.Windows.Forms.Button btnSave;
    }
}