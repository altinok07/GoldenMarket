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
    public partial class frmCustomerManager : Form
    {
        public frmCustomerManager()
        {
            InitializeComponent();
        }

        public int CustomerId = 0;
        Business.Customer.CustomerManager customerManager = new Business.Customer.CustomerManager();

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.Customer.Customer customer = new Model.Customer.Customer();
            customer.Name = txtCustomerName.Text;
            customer.Phone = txtPhone.Text;
            customer.Mail = txtMail.Text;
            customer.Address = txtAddress.Text;
            customer.IsActive = chboxIsActive.Checked;

            if (CustomerId == 0)
            {
                int check = customerManager.Add(customer);
                if (check > 0)
                {
                    DialogResult dr = MessageBox.Show("Müşteri Başarıyla Eklendi.\nYeni Müşteri Eklemeye Devam Etmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
                    MessageBox.Show("Müşteri Eklenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                customer.Id = CustomerId;
                bool check = customerManager.Update(customer);
                if (check)
                {
                    MessageBox.Show("Müşteri Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Müşteri Güncellenemedi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void frmCustomerManager_Load(object sender, EventArgs e)
        {
            if (CustomerId == 0)
            {
                this.Text = "Müşteri Ekle";
            }
            else
            {
                this.Text = "Müşteri GÜncelle";
                Model.Customer.Customer customer = customerManager.Get(CustomerId);
                txtCustomerName.Text = customer.Name;
                txtPhone.Text = customer.Phone;
                txtMail.Text = customer.Mail;
                txtAddress.Text = customer.Address;
                chboxIsActive.Checked = customer.IsActive;
            }
        }

        public void Clear()
        {
            txtCustomerName.Text = "";
            txtPhone.Text = "";
            txtMail.Text = "";
            txtAddress.Text = "";
            chboxIsActive.Checked = false;
        }
    }
}
