using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    /// <summary>
    /// ProtocolParametr - параметр медицинского протокола. 
    /// Например для печени это контуры, размер, положение, форма.
    /// У каждого такого параметра есть имя, а также список шаблонов - отфетов к этому параметру.
    /// Форма: круглая, овальная, правильна, неправильная
    /// </summary>
    public class Param : PersistentObject
    {
        public string Name { get; set; }
        public long OrganId { get; set; }
        public Organ Organ { get; set; }


        public virtual ICollection<Template> Templates { get; set; }
        public Param()
        {
            Templates = new HashSet<Template>(); 
        }
    }
}
