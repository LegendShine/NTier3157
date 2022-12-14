using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public abstract class BaseEntiti
    {
        public int ID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
        public BaseEntiti()
        {
            Status = DataStatus.Inserted;
            CreateDate = DateTime.Now;
            
        }

    }
}
