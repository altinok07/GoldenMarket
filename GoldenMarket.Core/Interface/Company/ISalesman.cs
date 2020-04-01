using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface.Company
{
    public interface ISalesman : IBaseInterface<Model.Company.Salesman>
    {
        IEnumerable<Model.Company.Salesman> SearchByName(string text);
        IEnumerable<Model.Company.Salesman> SearchByCompany(string text);
    }
}
