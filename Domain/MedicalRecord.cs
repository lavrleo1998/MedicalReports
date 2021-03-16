using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class MedicalRecord
    {

        public virtual ICollection<Exam> Exams { get; set; }
        public MedicalRecord()
        {
            Exams = new HashSet<Exam>();
        }
    }
}
