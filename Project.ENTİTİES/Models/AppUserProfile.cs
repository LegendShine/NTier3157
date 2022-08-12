using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class AppUserProfile : BaseEntities
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Reletional Porperties
        public virtual AppUser AppUser { get; set; }
        public virtual List <Order> Orders { get; set; }

    }
}
