using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Service : BaseObject
    {
        public ServiceType Type { get; set; }
        public DateTime Date { get; set; }
        public Doctor Doctor { get; set; }
        public Client Client { get; set; }
        public ServiceStatus Status { get; set; }
    }
}
