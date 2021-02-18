using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IDeletableObject
    {
        bool IsDeleted { get; set; }
        DateTime DeleteDate { get; set; }
    }
}
