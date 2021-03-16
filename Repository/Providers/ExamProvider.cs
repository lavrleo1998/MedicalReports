using Domain;
using Storage;


namespace Repository
{
    public class ExamProvider : Repository<Exam>, IExamProvider
    {
        public ExamProvider(AppDbContext context)
            : base(context)
        {

        }
    }
}
