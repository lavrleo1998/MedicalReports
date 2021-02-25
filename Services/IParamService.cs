using Domain;
using System.Collections.Generic;

namespace Services
{
    interface IParamService
    {
        void Create(string name);
        Param Get(long paramId);
        List<Template> GetWhisTemplate(long paramId);
        void Remove(long paramId);
        void Update(long paramId, string NewName);
    }
}