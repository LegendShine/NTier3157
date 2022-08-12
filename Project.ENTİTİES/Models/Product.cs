using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class Product : BaseEntities
    {
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public string ImagePath { get; set; }
        //Reletional Porperties
        public virtual Category Categorys { get; set; }
        public List<Order> Orders { get; set; }
    }
}
