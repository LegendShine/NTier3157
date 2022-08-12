using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class Shipper : BaseEntities
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        // Reletiona Properties
        public List<Order> orders { get; set; }
    }
}
