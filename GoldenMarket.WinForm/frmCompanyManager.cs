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
    public partial class frmCompanyManager : Form
    {
        public frmCompanyManager()
        {
            InitializeComponent();
        }

        public int CompanyId = 0;
        Business.Company.CompanyManager companyManager = new Business.Company.CompanyManager();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Company.Company company = new Model.Company.Company();
            company.Name = txtCompanyName.Text;
            company.Supplier = txtSupplierName.Text;
            company.Phone = txtPhone.Text;
            company.Mail = txtMail.Text;
            company.Address = txtAddress.Text;
            company.IsActive = chboxIsActive.Checked;

            if (CompanyId == 0)
            {
                Model.Company.Company c1 = companyManager.Get(txtCompanyName.Text);
                if (c1 != null && c1.Id > 0 && c1.Id != CompanyId)
                {
                    MessageBox.Show("Bu Firma Daha Önce Eklenmiştir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int check = companyManager.Add(company);
                if (check > 0)
                {
                    DialogResult dr = MessageBox.Show("Firma Başarıyla Eklendi.\nYeni Firma Eklemeye Devam Etmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Firma Eklenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Model.Company.Company c1 = companyManager.Get(txtCompanyName.Text);
                if (c1 != null && c1.Id > 0 && c1.Id != CompanyId)
                {
                    MessageBox.Show("Bu Firma Zaten Kayıtlı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                company.Id = CompanyId;
                bool check = companyManager.Update(company);

                if (check)
                {
                    MessageBox.Show("Firma Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Firma Güncellenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void frmCompanyManager_Load(object sender, EventArgs e)
        {
            if (CompanyId == 0)
            {
                this.Text = "Firma Ekle";
            }
            else
            {
                this.Text = "Firma Güncelle";
                Model.Company.Company company = companyManager.Get(CompanyId);
                txtCompanyName.Text = company.Name;
                txtSupplierName.Text = company.Supplier;
                txtPhone.Text = company.Phone;
                txtMail.Text = company.Mail;
                txtAddress.Text = company.Address;
                chboxIsActive.Checked = company.IsActive;
            }
        }

        public void Clear()
        {
            txtCompanyName.Text = "";
            txtSupplierName.Text = "";
            txtPhone.Text = "";
            txtMail.Text = "";
            txtAddress.Text = "";
            chboxIsActive.Checked = false;
        }
    }
}
