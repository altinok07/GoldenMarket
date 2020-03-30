using GoldenMarket.Core.Interface.Company;
using GoldenMarket.Core.Repository.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Company
{
    public class CompanyManager : ICompany
    {
        private readonly ICompany _ICompany;

        public CompanyManager()
        {
            _ICompany = new CompanyRepository();
        }
        public int Add(GoldenMarket.Model.Company.Company entity)
        {
            return _ICompany.Add(entity);
        }

        public bool Delete(GoldenMarket.Model.Company.Company entity)
        {
            return _ICompany.Delete(entity);
        }

        public GoldenMarket.Model.Company.Company Get(int Id)
        {
            return _ICompany.Get(Id);
        }

        public GoldenMarket.Model.Company.Company Get(string Name)
        {
            return _ICompany.Get(Name);
        }

        public IEnumerable<GoldenMarket.Model.Company.Company> GetActive()
        {
            return _ICompany.GetActive();
        }

        public IEnumerable<GoldenMarket.Model.Company.Company> GetAll()
        {
            return _ICompany.GetAll();
        }

        public bool Update(GoldenMarket.Model.Company.Company entity)
        {
            return _ICompany.Update(entity);
        }
    }
}
