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
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false; //Veritabanında ki kolonları kendimiz oluşturmak için 
            //GetAllProducts();
        }


        public void GetAllProducts()
        {
            Business.Product.ProductManager pm = new Business.Product.ProductManager();
            dataGridView1.DataSource = pm.GetAll();
        }

        public void GetActiveProducts()
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int ProductId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value);
            frmProductManager fpm = new frmProductManager();
            fpm.ProductId = ProductId;
            fpm.ShowDialog();
            GetAllProducts();

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbName.Checked)
                {                    
                    dataGridView1.DataSource = new Business.Product.ProductManager().SearchByName(txtSearch.Text.ToString());
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız Ürün Bulunamadı...\nArama Tercihini Kontrol Ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Text = "";
                    }
                }
                else if(rbCompany.Checked )
                {
                    dataGridView1.DataSource = new Business.Product.ProductManager().SearchByCompany(txtSearch.Text.ToString());
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız Ürün Bulunamadı...\nArama Tercihini Kontrol Ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Text = "";
                    }

                }
                else
                {
                    dataGridView1.DataSource = new Business.Product.ProductManager().SearchByBarcode(txtSearch.Text.ToString());
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız Ürün Bulunamadı...\nArama Tercihini Kontrol Ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Text = "";
                    }
                }                
            }
        }
    }
}
