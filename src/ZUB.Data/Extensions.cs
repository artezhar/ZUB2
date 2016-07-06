using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZUB.Domain;

namespace ZUB.Data
{
    public static class RepoExtensions
    {
        public static IEnumerable<Doctor> GetAll(this IBaseObjectRepository<Doctor> repo)
        {
            return new List<Doctor>{ new Doctor(), new Doctor() };
        }

        public static IEnumerable<Position> GetAll(this IBaseObjectRepository<Position> repo)
        {
            return new List<Position> { new Position(), new Position() };
        }
    }
}
