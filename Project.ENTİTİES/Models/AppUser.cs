using Project.ENTİTİES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTİTİES.Models
{
    public class AppUser : BaseEntiti
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Guid ActivationCode { get; set; }
        public bool Active { get; set; }
        public string EMail { get; set; }
        public UserRole Role { get; set; }

        //Reletional Porperties
        public virtual AppUserProfile Profile { get; set; }
    }
}
