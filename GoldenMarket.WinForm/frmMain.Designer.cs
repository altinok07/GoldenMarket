namespace GoldenMarket.WinForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.genelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışılanFirmalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetCompanies = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddProductType = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetProductTypes = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetInvoice = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnSalesman = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSalesman = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGetSalesman = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genelToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.çalışılanFirmalarToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.stokİşlemleriToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // genelToolStripMenuItem
            // 
            this.genelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSettings,
            this.btnExit});
            this.genelToolStripMenuItem.Name = "genelToolStripMenuItem";
            this.genelToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.genelToolStripMenuItem.Text = "Genel";
            // 
            // btnSettings
            // 
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(111, 22);
            this.btnSettings.Text = "Ayarlar";
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 22);
            this.btnExit.Text = "Çıkış";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCustomer,
            this.btnGetCustomers});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(166, 22);
            this.btnAddCustomer.Text = "Müşteri Ekle";
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnGetCustomers
            // 
            this.btnGetCustomers.Name = "btnGetCustomers";
            this.btnGetCustomers.Size = new System.Drawing.Size(166, 22);
            this.btnGetCustomers.Text = "Müşterileri Listele";
            this.btnGetCustomers.Click += new System.EventHandler(this.btnGetCustomers_Click);
            // 
            // çalışılanFirmalarToolStripMenuItem
            // 
            this.çalışılanFirmalarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCompany,
            this.btnGetCompanies,
            this.toolStripMenuItem1,
            this.btnSalesman});
            this.çalışılanFirmalarToolStripMenuItem.Name = "çalışılanFirmalarToolStripMenuItem";
            this.çalışılanFirmalarToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.çalışılanFirmalarToolStripMenuItem.Text = "Çalışılan Firmalar";
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(180, 22);
            this.btnAddCompany.Text = "Firma Ekle";
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // btnGetCompanies
            // 
            this.btnGetCompanies.Name = "btnGetCompanies";
            this.btnGetCompanies.Size = new System.Drawing.Size(180, 22);
            this.btnGetCompanies.Text = "Firmaları Listele";
            this.btnGetCompanies.Click += new System.EventHandler(this.btnGetCompanies_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.satışYapToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Satış İşlemi";
            // 
            // satışYapToolStripMenuItem
            // 
            this.satışYapToolStripMenuItem.Name = "satışYapToolStripMenuItem";
            this.satışYapToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.satışYapToolStripMenuItem.Text = "Satış Yap";
            // 
            // stokİşlemleriToolStripMenuItem
            // 
            this.stokİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddProduct,
            this.btnGetProducts,
            this.btnAddProductType,
            this.btnGetProductTypes});
            this.stokİşlemleriToolStripMenuItem.Name = "stokİşlemleriToolStripMenuItem";
            this.stokİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.stokİşlemleriToolStripMenuItem.Text = "Ürün İşlemleri";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 22);
            this.btnAddProduct.Text = "Ürün Ekle";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(180, 22);
            this.btnGetProducts.Text = "Ürünleri Listele";
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(180, 22);
            this.btnAddProductType.Text = "Ürün Türü Ekle";
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // btnGetProductTypes
            // 
            this.btnGetProductTypes.Name = "btnGetProductTypes";
            this.btnGetProductTypes.Size = new System.Drawing.Size(180, 22);
            this.btnGetProductTypes.Text = "Ürün Türü Listele";
            this.btnGetProductTypes.Click += new System.EventHandler(this.btnGetProductTypes_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddInvoice,
            this.btnGetInvoice});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // btnAddInvoice
            // 
            this.btnAddInvoice.Name = "btnAddInvoice";
            this.btnAddInvoice.Size = new System.Drawing.Size(159, 22);
            this.btnAddInvoice.Text = "Fatura Ekle";
            // 
            // btnGetInvoice
            // 
            this.btnGetInvoice.Name = "btnGetInvoice";
            this.btnGetInvoice.Size = new System.Drawing.Size(159, 22);
            this.btnGetInvoice.Text = "Faturaları Listele";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımdaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkımdaToolStripMenuItem
            // 
            this.hakkımdaToolStripMenuItem.Name = "hakkımdaToolStripMenuItem";
            this.hakkımdaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.hakkımdaToolStripMenuItem.Text = "Hakkımda";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnSalesman
            // 
            this.btnSalesman.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSalesman,
            this.btnGetSalesman});
            this.btnSalesman.Name = "btnSalesman";
            this.btnSalesman.Size = new System.Drawing.Size(180, 22);
            this.btnSalesman.Text = "Plasiyerler";
            // 
            // btnAddSalesman
            // 
            this.btnAddSalesman.Name = "btnAddSalesman";
            this.btnAddSalesman.Size = new System.Drawing.Size(180, 22);
            this.btnAddSalesman.Text = "Plasiyer Ekle";
            this.btnAddSalesman.Click += new System.EventHandler(this.btnAddSalesman_Click);
            // 
            // btnGetSalesman
            // 
            this.btnGetSalesman.Name = "btnGetSalesman";
            this.btnGetSalesman.Size = new System.Drawing.Size(180, 22);
            this.btnGetSalesman.Text = "Plasiyerleri Listele";
            this.btnGetSalesman.Click += new System.EventHandler(this.btnGetSalesman_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 520);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem genelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSettings;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddCustomer;
        private System.Windows.Forms.ToolStripMenuItem btnGetCustomers;
        private System.Windows.Forms.ToolStripMenuItem çalışılanFirmalarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddCompany;
        private System.Windows.Forms.ToolStripMenuItem btnGetCompanies;
        private System.Windows.Forms.ToolStripMenuItem stokİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddProduct;
        private System.Windows.Forms.ToolStripMenuItem btnGetProducts;
        private System.Windows.Forms.ToolStripMenuItem btnAddProductType;
        private System.Windows.Forms.ToolStripMenuItem btnGetProductTypes;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAddInvoice;
        private System.Windows.Forms.ToolStripMenuItem btnGetInvoice;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnSalesman;
        private System.Windows.Forms.ToolStripMenuItem btnAddSalesman;
        private System.Windows.Forms.ToolStripMenuItem btnGetSalesman;
    }
}

