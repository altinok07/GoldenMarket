using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface.Company
{
    public interface ICompany : IBaseInterface<Model.Company.Company>
    {
        Model.Company.Company Get(string Name);
    }
}
