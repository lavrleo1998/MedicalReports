using Domain;
using Storage;


namespace Repository
{
    public class MedicalRecordProvider : Repository<MedicalRecord>, IMedicalRecordProvider
    {
        public MedicalRecordProvider(AppDbContext context) 
            : base(context)
        {

        }
    }
}
