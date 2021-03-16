using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Exam : PersistentObject
    {
        public string Name { get; set; }

        public long MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
        public virtual ICollection<Organ> Organs { get; set; }
        public Exam()
        {
            Organs = new HashSet<Organ>();
        }
    }
}
