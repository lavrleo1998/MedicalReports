using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IParamService
    {
        void Create(string name);
        Param GetById(long paramId);
        Param GetByNameAndOrganId(string name, long organId);
        List<Param> GetAllByOrgan(long organId);
        List<Template> GetWhisTemplate(long paramId);
        void Remove(long paramId);
        void RemoveAll(long organIdd);
        void Update(long paramId, string NewName);
    }
}