using Domain;
using Storage;

namespace Repository
{
    public class ParamProvider : Repository<Param>, IParamProvider
    {
        public ParamProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
