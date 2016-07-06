using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class OnlineForm : BaseObject
    {
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public Problem Problem { get; set; }
        public Client Client { get; set; }
    }
}
