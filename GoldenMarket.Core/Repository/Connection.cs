using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Core.Repository
{
    public class Connection
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Server=.\SQLEXPRESS;Database=GoldenMarket;Trusted_Connection=True;");
        }
    }
}
