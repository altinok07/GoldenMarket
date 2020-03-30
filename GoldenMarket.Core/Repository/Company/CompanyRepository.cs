using Dapper;
using Dapper.Contrib.Extensions;
using GoldenMarket.Core.Interface.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository.Company
{
    public class CompanyRepository : ICompany
    {
        public int Add(Model.Company.Company entity)
        {
            using (var con = Connection.GetConnection())
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Delete(Model.Company.Company entity)
        {
            throw new NotImplementedException();
        }

        public Model.Company.Company Get(int CompanyId)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Get<Model.Company.Company>(CompanyId);
            }
        }

        public Model.Company.Company Get(string Name)
        {
            string Query = @"SELECT * FROM Company Where Name = @Name";
            DynamicParameters p = new DynamicParameters();
            p.Add("@Name",Name);
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Company.Company>(Query,p).FirstOrDefault();
            }
        }

        public IEnumerable<Model.Company.Company> GetActive()
        {
            string Query = @"SELECT * FROM Company WHERE IsActive = 1;";
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Company.Company>(Query);
            }
        }

        public IEnumerable<Model.Company.Company> GetAll()
        {
            using (var con = Connection.GetConnection())
            {
                return con.GetAll<Model.Company.Company>();
            }
        }

        public bool Update(Model.Company.Company entity)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Update(entity);
            }
        }
    }
}
