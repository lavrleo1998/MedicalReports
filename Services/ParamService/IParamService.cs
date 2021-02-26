using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IParamService
    {
        void Create(string name);
        Param GetById(long paramId);
        Param GetByName(string Name);
        List<Template> GetWhisTemplate(long paramId);
        void Remove(long paramId);
        void Update(long paramId, string NewName);
    }
}