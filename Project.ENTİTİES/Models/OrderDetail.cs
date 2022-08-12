using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class OrderDetail : BaseEntiti
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }

        // Reletional Porperties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
