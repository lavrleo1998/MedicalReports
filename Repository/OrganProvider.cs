using Domain;
using Storage;


namespace Repository
{
    public class OrganProvider : Repository<Organ>, IOrganProvider
    {
        public OrganProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}