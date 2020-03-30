using Dapper;
using Dapper.Contrib.Extensions;
using GoldenMarket.Core.Interface.Product;
using GoldenMarket.Model.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository.Product
{
    public class ProductTypeRepository : IProductType
    {
        public int Add(ProductType entity)
        {
            using (var con = Connection.GetConnection())
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Delete(ProductType entity)
        {
            throw new NotImplementedException();
        }

        public ProductType Get(int ProductTypeId)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Get<Model.Product.ProductType>(ProductTypeId);
            }
        }

        public Model.Product.ProductType Get(string Name)
        {
            string Query = @"SELECT * FROM Product Where Name = @Name";
            DynamicParameters p = new DynamicParameters();
            p.Add("@Name", Name);
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.ProductType>(Query, p).FirstOrDefault();
            }
        }

        public IEnumerable<ProductType> GetActive()
        {
            string Query = @"SELECT * FROM ProductType WHERE IsActive = 1;";
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.ProductType>(Query);
            }
        }

        public IEnumerable<ProductType> GetAll()
        {
            using (var con = Connection.GetConnection())
            {
                return con.GetAll<Model.Product.ProductType>();
            }
        }

        public bool Update(ProductType entity)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Update(entity);
            }
        }
    }
}
