using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Position:BaseObject
    {
        public List<Doctor> Doctors { get; set; }
    }
}
