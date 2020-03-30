using Dapper;
using Dapper.Contrib.Extensions;
using GoldenMarket.Core.Interface.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository.Customer
{
    public class CustomerRepository : ICustomer
    {
        public int Add(Model.Customer.Customer entity)
        {
            using (var con = Connection.GetConnection())
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Delete(Model.Customer.Customer entity)
        {
            throw new NotImplementedException();
        }

        public Model.Customer.Customer Get(int CustomerId)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Get<Model.Customer.Customer>(CustomerId);
            }
        }

        public IEnumerable<Model.Customer.Customer> GetActive()
        {
            string Query = @"SELECT * FROM Customer WHERE IsActive = 1;";
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Customer.Customer>(Query);
            }
        }

        public IEnumerable<Model.Customer.Customer> GetAll()
        {
            using (var con = Connection.GetConnection())
            {
                return con.GetAll<Model.Customer.Customer>();
            }
        }

        public IEnumerable<Model.Customer.Customer> SearchByName(string text)
        {
            string s = "%" + text + "%";
            string Query = @"SELECT
                                *
                                FROM
                                Customer
                                WHERE Name like @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Customer.Customer>(Query, 
                    new { text = s});
            }
        }

        public IEnumerable<Model.Customer.Customer> SearchByPhone(string text)
        {
            string s = "%" + text + "%";
            string Query = @"SELECT
                                * 
                                FROM
                                Customer
                                WHERE Phone like @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Customer.Customer>(Query,
                    new { text = s });
            }
        }

        public bool Update(Model.Customer.Customer entity)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Update(entity);
            }
        }
    }
}
