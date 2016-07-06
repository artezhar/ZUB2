using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Data
{
    public class DapperUOWImplementation : IUnitOfWork
    {
        public IBaseObjectRepository<Doctor> Doctors
        {
            get
            {
                return new DapperBORImplementation<Doctor>();
            }
        }
    }
}
