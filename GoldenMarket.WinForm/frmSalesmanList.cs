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
    public partial class frmSalesmanList : Form
    {
        public frmSalesmanList()
        {
            InitializeComponent();
        }

        private void frmSalesmanList_Load(object sender, EventArgs e)
        {
            dgvSalesmenList.AutoGenerateColumns = false;
        }

        public void GetAllSalesman()
        {
            Business.Company.SalesmanManager pm = new Business.Company.SalesmanManager();
            dgvSalesmenList.DataSource = pm.GetAll();
        }

        private void dgvSalesmenList_DoubleClick(object sender, EventArgs e)
        {
            int SalesmanId = Convert.ToInt32(dgvSalesmenList.Rows[dgvSalesmenList.CurrentRow.Index].Cells["Id"].Value);
            frmSalesmanManager fsm = new frmSalesmanManager();
            fsm.SalesmanId = SalesmanId;
            fsm.ShowDialog();
        }
    }
}
