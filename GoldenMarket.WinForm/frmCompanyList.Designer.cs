namespace GoldenMarket.WinForm
{
    partial class frmCompanyList
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
            this.dgvCompanyList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompanyList
            // 
            this.dgvCompanyList.AllowUserToAddRows = false;
            this.dgvCompanyList.AllowUserToDeleteRows = false;
            this.dgvCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FName,
            this.Supplier,
            this.Phone,
            this.Mail,
            this.Address});
            this.dgvCompanyList.Location = new System.Drawing.Point(12, 12);
            this.dgvCompanyList.Name = "dgvCompanyList";
            this.dgvCompanyList.ReadOnly = true;
            this.dgvCompanyList.RowHeadersVisible = false;
            this.dgvCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanyList.Size = new System.Drawing.Size(660, 426);
            this.dgvCompanyList.TabIndex = 0;
            this.dgvCompanyList.DoubleClick += new System.EventHandler(this.dgvCompanyList_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Firma No";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FName
            // 
            this.FName.DataPropertyName = "Name";
            this.FName.HeaderText = "Firma Adı";
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Tedarikçi Firma";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Telefon No";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "Mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // frmCompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvCompanyList);
            this.Name = "frmCompanyList";
            this.Text = "frmCompanyList";
            this.Load += new System.EventHandler(this.frmCompanyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompanyList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
    }
}