using Domain;
using Repository;
using Storage;

namespace Repository
{
    public class TemplateProvider : Repository<Template>, ITemplateProvider
    {
        public TemplateProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
