using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// Орган
    /// </summary>
    public class Organ : PersistentObject
    {
        public string Name { get; set; }
        public virtual ICollection<Param> Params { get; set; }
        public Organ()
        {
            Params = new HashSet<Param>();
        }
    }
}