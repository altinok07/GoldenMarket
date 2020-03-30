namespace GoldenMarket.WinForm
{
    partial class frmProductTypeList
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
            this.dgvProductTypeList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductTypeList
            // 
            this.dgvProductTypeList.AllowUserToAddRows = false;
            this.dgvProductTypeList.AllowUserToDeleteRows = false;
            this.dgvProductTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductTypeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PTName,
            this.IsActive});
            this.dgvProductTypeList.Location = new System.Drawing.Point(12, 12);
            this.dgvProductTypeList.Name = "dgvProductTypeList";
            this.dgvProductTypeList.ReadOnly = true;
            this.dgvProductTypeList.RowHeadersVisible = false;
            this.dgvProductTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductTypeList.Size = new System.Drawing.Size(307, 284);
            this.dgvProductTypeList.TabIndex = 0;
            this.dgvProductTypeList.DoubleClick += new System.EventHandler(this.dgvProductTypeList_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PTName
            // 
            this.PTName.DataPropertyName = "Name";
            this.PTName.HeaderText = "Ürün Türü";
            this.PTName.Name = "PTName";
            this.PTName.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.DataPropertyName = "IsActive";
            this.IsActive.HeaderText = "Durum";
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // frmProductTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 308);
            this.Controls.Add(this.dgvProductTypeList);
            this.Name = "frmProductTypeList";
            this.Text = "frmProductTypeList";
            this.Load += new System.EventHandler(this.frmProductTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductTypeList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductTypeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
    }
}