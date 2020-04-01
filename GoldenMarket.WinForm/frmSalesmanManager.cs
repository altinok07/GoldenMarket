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
    public partial class frmSalesmanManager : Form
    {
        public frmSalesmanManager()
        {
            InitializeComponent();
        }

        public int SalesmanId = 0;
        Business.Company.SalesmanManager salesmanManager = new Business.Company.SalesmanManager();


        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Company.Salesman salesman = new Model.Company.Salesman();
            salesman.Name = txtSalesmanName.Text;
            salesman.Phone = txtSalesmanPhone.Text;
            salesman.Mail = txtSalesmanMail.Text;
            salesman.CompanyId = Convert.ToInt32(coboxSalesmanCompany.SelectedValue);
            salesman.IsActive = chboxIsActive.Checked;

            if (SalesmanId == 0)
            {
                int check = salesmanManager.Add(salesman);
                if (check > 0)
                {
                    DialogResult dr = MessageBox.Show("Plasiyer Başarıyla Eklendi.\nYeni Plasiyer Eklemeye Devam Etmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Plasiyer Eklenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            else
            {
                salesman.Id = SalesmanId;
                bool check = salesmanManager.Update(salesman);
                if (check)
                {
                    MessageBox.Show("Plasiyer Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Plasiyer Güncellenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void frmSalesmanManager_Load(object sender, EventArgs e)
        {
            GetCompanies();

            if (SalesmanId == 0)
            {
                this.Text = "Plasiyer Ekle";
            }
            else
            {
                this.Text = "Plasiyer Güncelle";
                Model.Company.Salesman salesman = salesmanManager.Get(SalesmanId);
                txtSalesmanName.Text = salesman.Name;
                txtSalesmanPhone.Text = salesman.Phone;
                txtSalesmanMail.Text = salesman.Mail;
                coboxSalesmanCompany.SelectedValue = salesman.CompanyId;
                chboxIsActive.Checked = salesman.IsActive;
            }


        }

        public void GetCompanies()
        {
            Business.Company.CompanyManager company = new Business.Company.CompanyManager();
            coboxSalesmanCompany.DataSource = company.GetAll();
            coboxSalesmanCompany.DisplayMember = "Name";
            coboxSalesmanCompany.ValueMember = "Id";
        }


        public void Clear()
        {
            txtSalesmanName.Text = "";
            txtSalesmanPhone.Text = "";
            txtSalesmanMail.Text = "";
            coboxSalesmanCompany.Text = "";
            chboxIsActive.Checked = false;
        }





    }
}
