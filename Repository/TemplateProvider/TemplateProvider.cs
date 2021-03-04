using Domain;
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
