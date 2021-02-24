using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class ProtocolParameter : PersistentObject
    {
        public string Name { get; set; }
        public virtual ICollection<Template> Templates { get; set; }
        public ProtocolParameter()
        {
            Templates = new HashSet<Template>(); 
        }
    }
}
