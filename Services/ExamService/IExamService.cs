using Domain;
using System.Collections.Generic;

namespace Services
{
    interface IExamService
    {
        void Create(string name);
        Exam GetById(long examId);
        Exam GetByName(string name);
        List<Organ> GetOrgans(long examId);
        void Remove(long examId);
        void RemoveAll();
        void Update(long examId, string newName);
    }
}