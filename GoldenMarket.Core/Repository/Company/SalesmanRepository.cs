using Dapper;
using Dapper.Contrib.Extensions;
using GoldenMarket.Core.Interface.Company;
using GoldenMarket.Model.Company;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository.Company
{
    public class SalesmanRepository : ISalesman
    {
        public int Add(Salesman entity)
        {
            using (var con = Connection.GetConnection())
            {
                return (int)con.Insert(entity);
            }
        }

        public bool Delete(Salesman entity)
        {
            throw new NotImplementedException();
        }

        public Salesman Get(int SalesmanId)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Get<Model.Company.Salesman>(SalesmanId);
            }
        }

        public IEnumerable<Salesman> GetActive()
        {
            string Query = @"SELECT * FROM Salesman WHERE IsActive = 1;";
            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Company.Salesman>(Query);
            }
        }

        public IEnumerable<Salesman> GetAll()
        {
            using (var con = Connection.GetConnection())
            {
                string Query = @"SELECT
                                *
                                FROM
                                Salesman s
                                LEFT JOIN
                                Company c
                                ON
                                s.CompanyId = c.Id
                                ";

                return con.Query<Model.Company.Salesman, Model.Company.Company, Model.Company.Salesman>(Query,
                    (s, c) =>
                    {
                        s.Company = c;
                        return s;
                    }
                    , splitOn: "Id");
            }
        }

        public IEnumerable<Salesman> SearchByCompany(string text)
        {
            string st = "%" + text + "%";
            string Query = @"SELECT
                                *
                                FROM
                                Salesman s
                                LEFT JOIN
                                Company c
                                ON
                                s.CompanyId = c.Id
                                WHERE c.Name like @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Company.Salesman, Model.Company.Company, Model.Company.Salesman>(Query,
                    (s, c) =>
                    {
                        s.Company = c;
                        return s;
                    }
                    , new {text = st}
                    ,splitOn:"Id");
            }
        }

        public IEnumerable<Salesman> SearchByName(string text)
        {
            string st = "%" + text + "%";
            string Query = @"SELECT
                                *
                                FROM
                                Salesman s
                                LEFT JOIN
                                Company c
                                ON
                                s.CompanyId = c.Id
                                WHERE s.Name like @text";

            using (var con = Connection.GetConnection())
            {
                return con.Query<Model.Company.Salesman, Model.Company.Company, Model.Company.Salesman>(Query,
                    (s, c) =>
                    {
                        s.Company = c;
                        return s;
                    }
                    , new { text = st }
                    , splitOn: "Id");
            }
        }

        public bool Update(Salesman entity)
        {
            using (var con = Connection.GetConnection())
            {
                return con.Update(entity);
            }
        }
    }
}
