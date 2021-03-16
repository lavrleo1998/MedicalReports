using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface IOrganService
    {
        void Create(string name);
        Organ GetById(long organId);
        Organ GetByName(string name);
        public List<Organ> GetAllByExam(long examId);
        List<Param> GetWhisParams(long organId);
        void Remove(long organId);
        public void RemoveAll(long examId);
        void Update(long organId, string newName);
    }
}