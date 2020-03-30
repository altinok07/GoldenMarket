using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface.Customer
{
    public interface ICustomer : IBaseInterface<Model.Customer.Customer>
    {
        IEnumerable<Model.Customer.Customer> SearchByName(string text);
        IEnumerable<Model.Customer.Customer> SearchByPhone(string text);


    }
}
