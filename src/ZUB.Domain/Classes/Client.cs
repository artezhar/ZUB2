using System.Collections.Generic;
using ZUB.Domain;

namespace ZUB.Domain
{
    public class Client :ApplicationUser
    {
        public string CardNumber { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public override string Name
        {
            get { return $"{LastName} {FirstName}"; }
        }
        public List<string> EMAILS { get; set; }
        public List<string> PhoneNumbers { get; set; }
    }

   
}