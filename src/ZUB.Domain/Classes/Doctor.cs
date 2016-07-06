using System.Collections.Generic;
using System.Linq;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Doctor:ApplicationUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string Name
        {
            get { return $"{LastName} {FirstName}"; }
        }
        public int Position_ID { get; set; }
        public Position Position { get; set; }
    }
}