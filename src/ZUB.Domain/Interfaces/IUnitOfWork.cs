using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZUB.Domain
{
    public interface IUnitOfWork
    {
        IBaseObjectRepository<Doctor> Doctors { get; }
    }
}
