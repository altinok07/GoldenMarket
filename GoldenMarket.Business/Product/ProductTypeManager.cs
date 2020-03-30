using GoldenMarket.Core.Interface.Product;
using GoldenMarket.Core.Repository.Product;
using GoldenMarket.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Product
{
    public class ProductTypeManager : IProductType
    {
        private readonly IProductType _IProductType;
        public ProductTypeManager()
        {
            _IProductType = new ProductTypeRepository();
        }

        public int Add(ProductType entity)
        {
            return _IProductType.Add(entity);
        }

        public bool Delete(ProductType entity)
        {
            return _IProductType.Delete(entity);
        }

        public ProductType Get(int Id)
        {
            return _IProductType.Get(Id);
        }

        public GoldenMarket.Model.Product.ProductType Get(string Name)
        {
            return _IProductType.Get(Name);
        }

        public IEnumerable<ProductType> GetActive()
        {
            return _IProductType.GetActive();
        }

        public IEnumerable<ProductType> GetAll()
        {
            return _IProductType.GetAll();
        }

        public bool Update(ProductType entity)
        {
            return _IProductType.Update(entity);
        }
    }
}
