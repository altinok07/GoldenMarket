using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoldenMarket.WinForm
{
    public partial class frmProductManager : Form
    {
        public frmProductManager()
        {
            InitializeComponent();
        }

        public int ProductId = 0;
        Business.Product.ProductManager productManager = new Business.Product.ProductManager();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Product.Product product = new Model.Product.Product();
            product.Name = txtProductName.Text;
            product.CompanyId = Convert.ToInt32(coboxCompanyName.SelectedValue);
            product.ProductTypeId = Convert.ToInt32(coboxProductType.SelectedValue);
            product.Barcode = txtBarcode.Text;
            product.PurchasePrice = Convert.ToDecimal(txtPrice.Text);
            product.SalePrice = Convert.ToDecimal(txtSales.Text);
            product.IsActive = chboxIsActive.Checked;


            if (ProductId == 0)
            {
                Model.Product.Product p1 = productManager.Get(txtBarcode.Text);
                if (p1 != null && p1.Id > 0 && p1.Id != ProductId)
                {
                    MessageBox.Show("Bu Ürün Daha Önce Eklenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int check = productManager.Add(product);
                if (check > 0)
                {
                    DialogResult dr = MessageBox.Show("Ürün Başarıyla Eklendi.\nYeni Ürün Eklemeye Devam Etmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (dr == DialogResult.Yes)
                    {
                        Clear();
                    }
                    else
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Eklenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Model.Product.Product p1 = productManager.Get(txtBarcode.Text);
                if (p1 != null && p1.Id > 0 && p1.Id != ProductId)
                {
                    MessageBox.Show("Bu Barkod Kullanılmakta", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                product.Id = ProductId;
                bool check = productManager.Update(product);
                if (check)
                {
                    MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün Güncellenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }                                 
        }

        private void frmProductManager_Load(object sender, EventArgs e)
        {
             
            GetProductType();

            if (ProductId == 0)
            {
                this.Text = "Ürün Ekle";
            }

            else
            {
                this.Text = "Ürün Güncelle";
                Model.Product.Product product = productManager.Get(ProductId);
                txtProductName.Text = product.Name;
                coboxCompanyName.SelectedValue = product.CompanyId;
                coboxProductType.SelectedValue = product.ProductTypeId;
                txtBarcode.Text = product.Barcode;
                txtPrice.Text = product.PurchasePrice.ToString();
                txtSales.Text = product.SalePrice.ToString();
                chboxIsActive.Checked = product.IsActive;
            }

        }

        public void GetCompanies()
        {
            Business.Company.CompanyManager company = new Business.Company.CompanyManager();
            coboxCompanyName.DataSource = company.GetAll();
            coboxCompanyName.DisplayMember = "Name";
            coboxCompanyName.ValueMember = "Id";
        }

        public void GetProductType()
        {
            Business.Product.ProductTypeManager productType = new Business.Product.ProductTypeManager();
            coboxProductType.DataSource = productType.GetAll();
            coboxProductType.DisplayMember = "Name";
            coboxProductType.ValueMember = "Id";
        }

        public void Clear()
        {
            txtProductName.Text = "";
            coboxCompanyName.SelectedValue = "";
            coboxProductType.SelectedValue = "";
            txtBarcode.Text = "";
            txtPrice.Text = "";
            txtSales.Text = "";
            chboxIsActive.Checked = false;
        }
    }
}
