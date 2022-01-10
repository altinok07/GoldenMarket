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
    public partial class frmSalesScreen : Form
    {
        public frmSalesScreen()
        {
            InitializeComponent();
        }
       
        private void frmSalesScreen_Load(object sender, EventArgs e)
        {
            GetCustomers();
            GetProducts();

        }

        public void GetCustomers()
        {
            Business.Customer.CustomerManager customers = new Business.Customer.CustomerManager();
            coboxCustomer.DataSource = customers.GetAll();
            coboxCustomer.DisplayMember = "Name";
            coboxCustomer.ValueMember = "Id";
        }

        public void GetProducts()
        {
            Business.Product.ProductManager products = new Business.Product.ProductManager();
            coboxProducts.DataSource = products.GetAll();
            coboxProducts.DisplayMember = "Name";
            coboxProducts.ValueMember = "Id";
        }
    }
}
