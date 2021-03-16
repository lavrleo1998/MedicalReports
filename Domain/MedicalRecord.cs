using System.Collections.Generic;

namespace Domain
{
    public class MedicalRecord : PersistentObject
    {

        public virtual ICollection<Exam> Exams { get; set; }
        public MedicalRecord()
        {
            Exams = new HashSet<Exam>();
        }
    }
}
