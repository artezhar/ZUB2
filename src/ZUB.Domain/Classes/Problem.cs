using System.Collections.Generic;
using System.Linq;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Problem : BaseObject
    {
        public int Urgency { get; set; }
        public Category Category { get; set; }
    }

}