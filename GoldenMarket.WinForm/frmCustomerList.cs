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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            dgvCustomerList.AutoGenerateColumns = false;
            GetAllCustomers();
        }

        public void GetAllCustomers()
        {
            Business.Customer.CustomerManager cm = new Business.Customer.CustomerManager();
            dgvCustomerList.DataSource = cm.GetAll();

        }

        private void dgvCustomerList_DoubleClick(object sender, EventArgs e)
        {
            int CustomerId = Convert.ToInt32(dgvCustomerList.Rows[dgvCustomerList.CurrentRow.Index].Cells["Id"].Value);
            frmCustomerManager fcm = new frmCustomerManager();
            fcm.CustomerId = CustomerId;
            fcm.ShowDialog();
            GetAllCustomers();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (rbName.Checked)
                {
                    dgvCustomerList.DataSource = new Business.Customer.CustomerManager().SearchByName(txtSearch.Text.ToString());
                    if (dgvCustomerList.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız Müşteri Bulunamadı...\nArama Tercihini Kontrol Ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Text = "";
                    }
                }
                else
                {
                    dgvCustomerList.DataSource = new Business.Customer.CustomerManager().SearchByPhone(txtSearch.Text.ToString());
                    if (dgvCustomerList.Rows.Count == 0)
                    {
                        MessageBox.Show("Aradığınız Müşteri Bulunamadı...\nArama Tercihini Kontrol Ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSearch.Text = "";
                    }
                }
            }
        }
    }
}
