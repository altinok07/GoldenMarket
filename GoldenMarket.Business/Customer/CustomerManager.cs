using GoldenMarket.Core.Interface.Customer;
using GoldenMarket.Core.Repository.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Customer
{
    public class CustomerManager : ICustomer
    {
        private readonly ICustomer _ICustomer;
        public CustomerManager()
        {
            _ICustomer = new CustomerRepository();
        }

        public int Add(GoldenMarket.Model.Customer.Customer entity)
        {
            return _ICustomer.Add(entity);
        }

        public bool Delete(GoldenMarket.Model.Customer.Customer entity)
        {
            return _ICustomer.Delete(entity);
        }

        public GoldenMarket.Model.Customer.Customer Get(int Id)
        {
            return _ICustomer.Get(Id);
        }

        public IEnumerable<GoldenMarket.Model.Customer.Customer> GetActive()
        {
            return _ICustomer.GetActive();
        }

        public IEnumerable<GoldenMarket.Model.Customer.Customer> GetAll()
        {
            return _ICustomer.GetAll();
        }

        public IEnumerable<GoldenMarket.Model.Customer.Customer> SearchByName(string text)
        {
            return _ICustomer.SearchByName(text);
        }

        public IEnumerable<GoldenMarket.Model.Customer.Customer> SearchByPhone(string text)
        {
            return _ICustomer.SearchByPhone(text);
        }

        public bool Update(GoldenMarket.Model.Customer.Customer entity)
        {
            return _ICustomer.Update(entity);
        }
    }
}
