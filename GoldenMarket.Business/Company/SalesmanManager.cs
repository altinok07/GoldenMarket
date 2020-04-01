using GoldenMarket.Core.Interface.Company;
using GoldenMarket.Core.Repository.Company;
using GoldenMarket.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Company
{
    public class SalesmanManager : ISalesman
    {
        private readonly ISalesman _ISalesman;
        public SalesmanManager()
        {
            _ISalesman = new SalesmanRepository();
        }

        public int Add(Salesman entity)
        {
            return _ISalesman.Add(entity);    
        }

        public bool Delete(Salesman entity)
        {
            return _ISalesman.Delete(entity);
        }

        public Salesman Get(int Id)
        {
            return _ISalesman.Get(Id);
        }

        public IEnumerable<Salesman> GetActive()
        {
            return _ISalesman.GetActive();
        }

        public IEnumerable<Salesman> GetAll()
        {
            return _ISalesman.GetAll();
        }

        public IEnumerable<Salesman> SearchByCompany(string text)
        {
            return _ISalesman.SearchByCompany(text);
        }

        public IEnumerable<Salesman> SearchByName(string text)
        {
            return _ISalesman.SearchByName(text);
        }

        public bool Update(Salesman entity)
        {
            return _ISalesman.Update(entity);
        }
    }
}
