using Domain;
using Repository.Repository;
using Storage;

namespace Repository.ProtocolParameterProvider
{
    public class ProtocolParameterProvider : Repository<ProtocolParameter>, IProtocolParameterProvider
    {
        public ProtocolParameterProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
