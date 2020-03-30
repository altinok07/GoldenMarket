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
    public class ProductManager : IProduct
    {
        private readonly IProduct _IProduct;
        public ProductManager()
        {
            _IProduct = new ProductRepository();
        }

        public int Add(GoldenMarket.Model.Product.Product entity)
        {
            return _IProduct.Add(entity);
        }

        public bool Delete(GoldenMarket.Model.Product.Product entity)
        {
            return _IProduct.Delete(entity);
        }

        public GoldenMarket.Model.Product.Product Get(int Id)
        {
            return _IProduct.Get(Id);
        }

        public GoldenMarket.Model.Product.Product Get(string Barcode)
        {
            return _IProduct.Get(Barcode);
        }

        public IEnumerable<GoldenMarket.Model.Product.Product> GetActive()
        {
            return _IProduct.GetActive();
        }

        public IEnumerable<GoldenMarket.Model.Product.Product> GetAll()
        {
            return _IProduct.GetAll();
        }

        public IEnumerable<GoldenMarket.Model.Product.Product> SearchByBarcode(string text)
        {
            return _IProduct.SearchByBarcode(text);
        }

        public IEnumerable<GoldenMarket.Model.Product.Product> SearchByCompany(string text)
        {
            return _IProduct.SearchByCompany(text);
        }

        public IEnumerable<GoldenMarket.Model.Product.Product> SearchByName(string text)
        {
            return _IProduct.SearchByName(text);
        }

        public bool Update(GoldenMarket.Model.Product.Product entity)
        {
            return _IProduct.Update(entity);
        }
    }
}
