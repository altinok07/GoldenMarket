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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            frmProductList frmProductList = new frmProductList();
            frmProductList.ShowDialog();
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            frmCustomerList frmCustomerList = new frmCustomerList();
            frmCustomerList.ShowDialog();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductManager frmProductManager = new frmProductManager();
            frmProductManager.ShowDialog();
        }

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            frmCompanyManager frmCompanyManager = new frmCompanyManager();
            frmCompanyManager.ShowDialog();
        }

        private void btnGetCompanies_Click(object sender, EventArgs e)
        {
            frmCompanyList frmCompanyList = new frmCompanyList();
            frmCompanyList.ShowDialog();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerManager frmCustomerManager = new frmCustomerManager();
            frmCustomerManager.ShowDialog();
        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            frmProductTypeManager productTypeManager = new frmProductTypeManager();
            productTypeManager.ShowDialog();
        }

        private void btnGetProductTypes_Click(object sender, EventArgs e)
        {
            frmProductTypeList productTypeList = new frmProductTypeList();
            productTypeList.ShowDialog();
        }

        private void btnAddSalesman_Click(object sender, EventArgs e)
        {
            frmSalesmanManager salesmanManager = new frmSalesmanManager();
            salesmanManager.ShowDialog();
        }

        private void btnGetSalesman_Click(object sender, EventArgs e)
        {
            frmSalesmanList salesmanList = new frmSalesmanList();
            salesmanList.ShowDialog();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmSalesScreen salesScreen = new frmSalesScreen();
            salesScreen.ShowDialog();
        }
    }
}
