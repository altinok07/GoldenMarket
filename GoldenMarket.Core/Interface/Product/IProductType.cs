using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface.Product
{
    public interface IProductType : IBaseInterface<Model.Product.ProductType>
    {
        Model.Product.ProductType Get(string Name);
    }
}
