using Domain;
using Repository.Repository;
using Storage;

namespace Repository.TemplateProvider
{
    public class TemplateProvider : Repository<Template>, ITemplateProvider
    {
        public TemplateProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
