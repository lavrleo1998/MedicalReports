using Domain;
using DTO.Request;
using Microsoft.EntityFrameworkCore;
using Repository.ParamProvider;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class ParamService : IParamService
    {
        private readonly IParamProvider ParamProvider;
        public ParamService(IParamProvider paramProvider)
        {
            ParamProvider = paramProvider;
        }
        public void Create(string name)
        {
            var protocolParameter = new Param
            {
                Name = name
            };
            ParamProvider.Create(protocolParameter);
            ParamProvider.SaveChanges();

        }

        public void Remove(long paramId)
        {
            var protocolParameter = ParamProvider
                .GetAll()
                .Where(x => x.Id == paramId)
                .FirstOrDefault();

            ParamProvider.Remove(protocolParameter);
        }

        public Param Get(long paramId)
        {
            var param = ParamProvider
                .GetAll()
                .Where(x => x.Id == paramId)
                .FirstOrDefault()
                ?? throw new System.Exception("протокол параметр не найдет");

            return param;
        }
        public List<Template> GetWhisTemplate(long paramId)
        {
            var templates = new List<Template>();
            var templatesICollection = ParamProvider
               .GetAll()
               .Include(x => x.Templates)
               .Where(x => x.Id == paramId)
               .Select(x => x.Templates).ToList();

            foreach (var item in templatesICollection)
            {
                var items = item.ToList();
                templates.AddRange(items);
            }
            return templates;

        }
        public void Update(long paramId, string NewName)
        {
            var param = ParamProvider
               .GetAll()
               .Where(x => x.Id == paramId)
               .FirstOrDefault();
            param.Name = NewName;
            ParamProvider.Update(param);
        }
    }
}
