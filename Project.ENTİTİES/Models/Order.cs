using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class Order : BaseEntiti
    {
        public string ShippedAddres { get; set; }
        public int? AppUserID { get; set; }
        public int? ShipperID { get; set; }

        // Reletional Porperties
        public virtual AppUser AppUser { get; set; }
        public List<Product> Products { get; set; }
        public virtual Shipper Shipper { get; set; }
    }
}
