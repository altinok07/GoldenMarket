using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Model.Company
{
    [Table("Salesman")]
    public class Salesman
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }

        //Left Join İşlemi İçin
        [Write(false)]
        public Model.Company.Company Company { get; set; }

        //Tabloya ismi çekmek için
        public string CompanyName
        {
            get { return Company.Name; }
        }

    }
}
