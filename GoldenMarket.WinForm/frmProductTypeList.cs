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
    public partial class frmProductTypeList : Form
    {
        public frmProductTypeList()
        {
            InitializeComponent();
        }

        private void frmProductTypeList_Load(object sender, EventArgs e)
        {
            dgvProductTypeList.AutoGenerateColumns = false;
            GetAllProductType();
        }

        private void dgvProductTypeList_DoubleClick(object sender, EventArgs e)
        {
            int ProductTypeId = Convert.ToInt32(dgvProductTypeList.Rows[dgvProductTypeList.CurrentRow.Index].Cells["Id"].Value);
            frmProductTypeManager ptm = new frmProductTypeManager();
            ptm.ProductTypeId = ProductTypeId;
            ptm.ShowDialog();
            GetAllProductType();
        }

        public void GetAllProductType()
        {
            Business.Product.ProductTypeManager ptm = new Business.Product.ProductTypeManager();
            dgvProductTypeList.DataSource = ptm.GetAll();
        }
    }
}
