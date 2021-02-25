using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Template : PersistentObject
    {
        public string Text { get; set; }
        public long ParamId { get; set; }
        public Param Param { get; set; }
       

    }
}
