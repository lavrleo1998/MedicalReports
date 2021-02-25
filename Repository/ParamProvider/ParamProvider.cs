using Domain;
using Repository.Repository;
using Storage;

namespace Repository.ParamProvider
{
    public class ParamProvider : Repository<Param>, IParamProvider
    {
        public ParamProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
