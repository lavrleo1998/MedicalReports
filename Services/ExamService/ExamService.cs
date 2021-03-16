using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class ExamService : IExamService
    {
        private readonly IExamProvider ExamProvider;
        public ExamService(IExamProvider examProvider)
        {
            this.ExamProvider = examProvider;
        }
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly IOrganService OrganService = scope.GetRequiredService<IOrganService>();
       

        public void Create(string name)
        {
            var exam = new Exam
            {
                Name = name,
                IsDeleted = false
            };
            ExamProvider.Create(exam);
            ExamProvider.SaveChanges();
        }


        public void Remove(long examId)
        {
            var exam = ExamProvider
                .GetAll()
                .Where(x => x.Id == examId)
                .FirstOrDefault()
                ?? throw new Exception("Исследование не найдено");
            OrganService.RemoveAll(examId);
            ExamProvider.Remove(exam);
            ExamProvider.SaveChanges();
        }

        public void RemoveAll()
        {
            ExamProvider.SaveChanges();
        }

        public Exam GetById(long examId)
        {
            var exam = ExamProvider
                .GetAll()
                .Where(x => x.Id == examId)
                .FirstOrDefault()
                ?? throw new Exception("Исследование не найдено");
            return exam;
        }

        public Exam GetByName(string name)
        {
            var exam = ExamProvider
                .GetAll()
                .Where(x => x.Name == name)
                .FirstOrDefault()
                ?? throw new Exception("Исследование не найдено");
            return exam;
        }

        public List<Organ> GetOrgans(long examId)
        {
            var organsList = new List<Organ>();
            var organICollection = ExamProvider
                .GetAll()
                .Include(x => x.Organs)
                .Where(x => x.Id == examId)
                .Select(x => x.Organs)
                .ToList()
                ?? throw new Exception("Исследование не найдено");
            foreach (var organMiniList in organICollection)
            {
                var organMiniList1 = organMiniList.ToList();
                organsList.AddRange(organMiniList1);
            }
            return organsList;
        }

        public void Update(long examId, string newName)
        {
            var exam = ExamProvider
                .GetAll()
                .Where(x => x.Id == examId)
                .FirstOrDefault()
                ?? throw new Exception("Исследование не найдено");
            exam.Name = newName;
            ExamProvider.Update(exam);
            ExamProvider.SaveChanges();
        }
    }
}
