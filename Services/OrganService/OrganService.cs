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
        private readonly IOrganProvider OrganProvider;
        private readonly IParamService ParamService;
        public OrganService(IOrganProvider OrganProvider, IParamService ParamService)
        {
            this.OrganProvider = OrganProvider;
            this.ParamService = ParamService;
        }

        public void Create(string name)
        {
            var organ = new Organ
            {
                Name = name
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