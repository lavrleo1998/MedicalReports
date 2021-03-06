using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IOrganService
    {
        void Create(string name);
        Organ GetById(long organId);
        Organ GetByName(string name);
        List<Param> GetWhisParams(long organId);
        void Remove(long organId);
        void Update(long organId, string newName);
    }
}