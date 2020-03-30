using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Interface.Product
{
    public interface IProduct : IBaseInterface<Model.Product.Product> 
    {
        Model.Product.Product Get(string Barcode);

        IEnumerable<Model.Product.Product> SearchByName(string text);

        IEnumerable<Model.Product.Product> SearchByCompany(string text);

        IEnumerable<Model.Product.Product> SearchByBarcode(string text);


    }
}
