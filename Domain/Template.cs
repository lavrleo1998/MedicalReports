using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Template : PersistentObject
    {
        public string Text { get; set; }
        public long ProtocolParameterId{ get; set; }
        public ProtocolParameter ProtocolParameter { get; set; }
       

    }
}
