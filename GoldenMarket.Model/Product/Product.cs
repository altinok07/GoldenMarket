using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldenMarket.Model.Product
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int ProductTypeId { get; set; }
        public string Barcode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public bool IsActive { get; set; }

        // Left Join İşlemleri İçin Oluşturduk.
        [Write(false)]
        public Model.Company.Company Company { get; set; }
        [Write(false)]
        public Model.Product.ProductType ProductType { get; set; }

        // Tabloda Model olarak gelen valueyi Çektik
        [Write(false)]
        public string CompanyName
        {
            get { return Company.Name; }
        }

        [Write(false)]
        public string ProductTypeName
        {
            get { return ProductType.Name; }
        }
    }

}
