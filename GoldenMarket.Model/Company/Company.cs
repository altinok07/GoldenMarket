using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Model.Company
{
    [Table("Company")]
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }

    }
}
