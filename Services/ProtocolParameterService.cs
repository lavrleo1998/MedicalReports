
using Domain;
using DTO.Request;
using Microsoft.EntityFrameworkCore;
using Repository.ProtocolParameterProvider;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class ProtocolParameterService : IProtocolParameterService
    {
        private readonly IProtocolParameterProvider ProtocolParameterProvider;
        public ProtocolParameterService(IProtocolParameterProvider protocolParameterProvider)
        {
            ProtocolParameterProvider = protocolParameterProvider;
        }
        public void CreateProtocolParameter(CreateProtocolParameterDTO request)
        {
            var protocolParameter = new ProtocolParameter();
            protocolParameter.Name = request.Name;
            ProtocolParameterProvider.Create(protocolParameter);
        }

        public void RemoveById(long ProtParamId)
        {
            var protocolParameter = ProtocolParameterProvider
                .GetAll()
                .Where(x => x.Id == ProtParamId)
                .FirstOrDefault();
            ProtocolParameterProvider.Remove(protocolParameter);
        }

        public ProtocolParameter GetById(long ProtParamId)
        {
            var protocolParameter = ProtocolParameterProvider.
                GetAll()
                .Where(x => x.Id == ProtParamId)
                .FirstOrDefault();
            return protocolParameter;
        }
        public List<Template> GetWhisTemplate(long ProtParamId)
        {
            var templates = new List<Template>();
            var templatesICollection = ProtocolParameterProvider.
               GetAll()
               .Include(x => x.Templates)
               .Where(x => x.Id == ProtParamId)
               .Select(x => x.Templates).ToList();

            foreach (var item in templatesICollection)
            {
                var items = item.ToList();
                templates.AddRange(items);
            }
            return templates;

        }
        public void UpdateById(long ProtParamId)
        {
            var protocolParameter = ProtocolParameterProvider.
               GetAll()
               .Where(x => x.Id == ProtParamId)
               .FirstOrDefault();
            protocolParameter.Name = "";
            ProtocolParameterProvider.Update(protocolParameter);
        }
    }
}
