namespace GoldenMarket.WinForm
{
    partial class frmSalesScreen
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
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coboxCustomer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coboxProducts = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Barkodu: ";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(103, 41);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(148, 20);
            this.txtBarcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı:";
            // 
            // coboxCustomer
            // 
            this.coboxCustomer.FormattingEnabled = true;
            this.coboxCustomer.Location = new System.Drawing.Point(402, 36);
            this.coboxCustomer.Name = "coboxCustomer";
            this.coboxCustomer.Size = new System.Drawing.Size(159, 21);
            this.coboxCustomer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Adı:";
            // 
            // coboxProducts
            // 
            this.coboxProducts.FormattingEnabled = true;
            this.coboxProducts.Location = new System.Drawing.Point(402, 69);
            this.coboxProducts.Name = "coboxProducts";
            this.coboxProducts.Size = new System.Drawing.Size(159, 21);
            this.coboxProducts.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(575, 201);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(427, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 33);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Kapat";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(262, 366);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 33);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(94, 366);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(104, 33);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Satışı Tamamla";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmSalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 426);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.coboxProducts);
            this.Controls.Add(this.coboxCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesScreen";
            this.Text = "frmSalesScreen";
            this.Load += new System.EventHandler(this.frmSalesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox coboxCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox coboxProducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnDelete;
    }
}