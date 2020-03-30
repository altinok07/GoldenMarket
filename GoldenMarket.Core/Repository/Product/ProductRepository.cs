using Dapper;
using Dapper.Contrib.Extensions;
using GoldenMarket.Core.Interface.Product;
using GoldenMarket.Model.Product;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository.Product
{
    public class ProductRepository : IProduct
    {
        public int Add(Model.Product.Product entity)
        {
            using (var con = Connection.GetConnection())
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Delete(Model.Product.Product entity)
        {
            throw new NotImplementedException();
        }

        public Model.Product.Product Get(int ProductId)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Get<Model.Product.Product>(ProductId);
            }
        }

        public Model.Product.Product Get(string Barcode)
        {
            string Query = @"SELECT * FROM Product Where Barcode = @Barcode";
            DynamicParameters p = new DynamicParameters();
            p.Add("@Barcode",Barcode);
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.Product>(Query, p).FirstOrDefault();
            }
        }

        public IEnumerable<Model.Product.Product> GetActive()
        {
            string Query = @"SELECT * FROM Product WHERE IsActive = 1;";
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.Product>(Query);
            }
        }

        public IEnumerable<Model.Product.Product> GetAll()
        {
            using (var con = Connection.GetConnection())
            {
                string Query = @"SELECT
                                *
                                FROM
                                Product p
                                LEFT JOIN
                                ProductType pt
                                ON
                                p.ProductTypeId = pt.Id
                                LEFT JOIN
                                Company c
                                ON
                                p.CompanyId = c.Id
                                ";
                return con.Query<Model.Product.Product, Model.Product.ProductType, Model.Company.Company, Model.Product.Product>(Query,
                    (p, pt, c) =>
                    {
                        p.ProductType = pt;
                        p.Company = c;
                        return p;
                    }
                    , splitOn: "Id");
            }
             
        }

        public IEnumerable<Model.Product.Product> SearchByBarcode(string text)
        {
            string Query = @"SELECT
                                *
                                FROM
                                Product p
                                LEFT JOIN
                                ProductType pt
                                ON
                                p.ProductTypeId = pt.Id
                                LEFT JOIN
                                Company c
                                ON
                                p.CompanyId = c.Id
                                WHERE p.Barcode = @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.Product, Model.Product.ProductType, Model.Company.Company, Model.Product.Product>(Query,
                     (p, pt, c) =>
                     {
                         p.ProductType = pt;
                         p.Company = c;
                         return p;
                     }
                     , new { text }
                     , splitOn: "Id");
            }

        }

        public IEnumerable<Model.Product.Product> SearchByCompany(string text)
        {
            string s = "%" + text + "%";
            string Query = @"SELECT
                                *
                                FROM
                                Product p
                                LEFT JOIN
                                ProductType pt
                                ON
                                p.ProductTypeId = pt.Id
                                LEFT JOIN
                                Company c
                                ON
                                p.CompanyId = c.Id
                                WHERE c.Name like @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.Product, Model.Product.ProductType, Model.Company.Company, Model.Product.Product>(Query,
                     (p, pt, c) =>
                     {
                         p.ProductType = pt;
                         p.Company = c;
                         return p;
                     }
                     , new { text = s }
                     , splitOn: "Id");
            }

        }

        public IEnumerable<Model.Product.Product> SearchByName(string text)
        {
            string s = "%"+text+"%";
            string Query = @"SELECT
                                *
                                FROM
                                Product p
                                LEFT JOIN
                                ProductType pt
                                ON
                                p.ProductTypeId = pt.Id
                                LEFT JOIN
                                Company c
                                ON
                                p.CompanyId = c.Id
                                WHERE p.Name like @text";
          

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Product.Product, Model.Product.ProductType, Model.Company.Company, Model.Product.Product>(Query,
                     (p, pt, c) =>
                     {
                         p.ProductType = pt;
                         p.Company = c;
                         return p;
                     }
                     , new { text = s }
                     , splitOn: "Id");
            }
        }

        public bool Update(Model.Product.Product entity)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Update(entity);
            }
        }
    }
}
