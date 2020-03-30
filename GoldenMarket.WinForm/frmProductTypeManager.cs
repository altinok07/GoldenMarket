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
    public partial class frmProductTypeManager : Form
    {
        public frmProductTypeManager()
        {
            InitializeComponent();
        }

        public int ProductTypeId = 0;
        Business.Product.ProductTypeManager productTypeManager = new Business.Product.ProductTypeManager();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Product.ProductType productType = new Model.Product.ProductType();
            productType.Name = txtProductType.Text;
            productType.IsActive = chboxIsActive.Checked;

            if (ProductTypeId == 0)
            {
                Model.Product.ProductType pt1 = productTypeManager.Get(txtProductType.Text);
                if (pt1 != null && pt1.Id > 0 && pt1.Id != ProductTypeId)
                {
                    MessageBox.Show("Bu Ürün Türü Daha Önce Eklenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int check = productTypeManager.Add(productType);
                if (check > 0)
                {
                    DialogResult dr = MessageBox.Show("Ürün Türü Başarıyla Eklendi.\nYeni Ürün Türü Eklemeye Devam Etmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Ürün Türü Eklenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Model.Product.ProductType pt1 = productTypeManager.Get(txtProductType.Text);
                if (pt1 != null && pt1.Id > 0 && pt1.Id != ProductTypeId)
                {
                    MessageBox.Show("Bu Ürün Türü Kullanılmakta", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                productType.Id = ProductTypeId;
                bool check = productTypeManager.Update(productType);
                if (check)
                {
                    MessageBox.Show("Ürün Türü Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ürün Türü Güncellenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void frmProductTypeManager_Load(object sender, EventArgs e)
        {
            if (ProductTypeId == 0)
            {
                this.Text = "Ürün Türü Ekle";                
            }
            else
            {
                this.Text = "Ürün Türü Güncelle";
                Model.Product.ProductType productType = productTypeManager.Get(ProductTypeId);
                txtProductType.Text = productType.Name;
                chboxIsActive.Checked = productType.IsActive;
            }
        }

        public void Clear()
        {
            txtProductType.Text = "";
            chboxIsActive.Checked = false;
        }
    }
}
