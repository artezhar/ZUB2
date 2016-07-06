using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class ServiceType : BaseObject
    {
        public Category Cathegory { get; set; }
        public List<Problem> Problems { get; set; }
    }

}
