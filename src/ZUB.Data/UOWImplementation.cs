using ZUB.Domain;

namespace ZUB.Data
{
    public class UOWImplementation : IUnitOfWork
    {
        public IBaseObjectRepository<Doctor> Doctors
        {
            get
            {
                return new DapperBORImplementation<Doctor>(
                    new MappingBuilder()
                    .Type(typeof(Doctor))
                    .MapPropertyToTable("Position", "Position")
                    .Build()
                    );
            }
        }
    }
}
