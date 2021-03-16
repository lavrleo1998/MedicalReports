using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class OrganService : IOrganService
    {
        //private readonly IOrganProvider OrganProvider;
        //private readonly IParamService ParamService;
        //public OrganService(IOrganProvider OrganProvider, IParamService ParamService)
        //{
        //    this.OrganProvider = OrganProvider;
        //    this.ParamService = ParamService;
        //}



        private readonly IOrganProvider OrganProvider;
        public OrganService(IOrganProvider organProvider)
        {
               this.OrganProvider = organProvider;
        }
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly IParamService ParamService = scope.GetRequiredService<IParamService>();
        private static readonly IExamService ExamService = scope.GetRequiredService<IExamService>();





        public void Create(string name)
        {
            var organ = new Organ
            {
                Name = name,
                IsDeleted = false
            };
            OrganProvider.Create(organ);
            OrganProvider.SaveChanges();
        }

        public void Remove(long organId)
        {
            var organ = OrganProvider
                .GetAll()
                .Where(x => x.Id == organId)
                .FirstOrDefault()
                ?? throw new Exception("Орган не найден");
            ParamService.RemoveAll(organId);
            OrganProvider.Remove(organ);
            OrganProvider.SaveChanges();
        }

        public void RemoveAll(long examId)
        {
            List<Organ> organs = ExamService.GetOrgans(examId)
                ?? throw new Exception("Исследование с органами не найдено");
            foreach (var organ in organs)
            {
                this.Remove(organ.Id);
            }
            OrganProvider.SaveChanges();
        }

        public Organ GetById(long organId)
        {
            var organ = OrganProvider
                .GetAll()
                .Where(x => x.Id == organId)
                .FirstOrDefault()
                ?? throw new Exception("Орган не найден");
            return organ;
        }

        public Organ GetByName(string name)
        {
            var organ = OrganProvider
                .GetAll()
                .Where(x => x.Name == name)
                .FirstOrDefault()
                ?? throw new Exception("Орган не найден");
            return organ;
        }

        public List<Organ> GetAllByExam(long examId)
        {
            var organList = OrganProvider
                .GetAll()
                .Where(x => x.ExamId == examId)
                .Select(x => x).ToList()
                ?? throw new Exception("Параметр не найдет");
            return organList;
        }

        public List<Param> GetWhisParams(long organId)
        {
            var paramList = new List<Param>();
            var paramsICollection = OrganProvider
                .GetAll()
                .Include(x => x.Params)
                .Where(x => x.Id == organId)
                .Select(x => x.Params)
                .ToList()
                ?? throw new Exception("Орган не найден");
            foreach (var item in paramsICollection)
            {
                var items = item.ToList();
                paramList.AddRange(items);
            }
            return paramList;
        }

        public void Update(long organId, string newName)
        {
            var organ = OrganProvider
                .GetAll()
                .Where(x => x.Id == organId)
                .FirstOrDefault()
                ?? throw new Exception("Орган не найден");
            organ.Name = newName;
            OrganProvider.Update(organ);
            OrganProvider.SaveChanges();
        }
    }
}