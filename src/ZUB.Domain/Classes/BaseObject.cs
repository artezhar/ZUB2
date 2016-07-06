using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Domain
{
    public class BaseObject
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}
