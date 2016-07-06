using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Domain
{
    public class ApplicationUser:BaseObject
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
    }
}
