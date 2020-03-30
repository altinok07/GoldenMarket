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
    public partial class frmCompanyList : Form
    {
        public frmCompanyList()
        {
            InitializeComponent();
        }        

        private void frmCompanyList_Load(object sender, EventArgs e)
        {
            dgvCompanyList.AutoGenerateColumns = false;
            GetAllCompanies();
        }

        public void GetAllCompanies()
        {
            Business.Company.CompanyManager cm = new Business.Company.CompanyManager();
            dgvCompanyList.DataSource = cm.GetAll();
        }

        private void dgvCompanyList_DoubleClick(object sender, EventArgs e)
        {
            int CompanyId = Convert.ToInt32(dgvCompanyList.Rows[dgvCompanyList.CurrentRow.Index].Cells["Id"].Value);
            frmCompanyManager fcm = new frmCompanyManager();
            fcm.CompanyId = CompanyId;
            fcm.ShowDialog();
            GetAllCompanies();

        }
    }
}
