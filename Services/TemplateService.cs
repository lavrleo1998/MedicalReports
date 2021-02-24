using Domain;
using DTO.Request;
using Microsoft.Extensions.DependencyInjection;
using Repository.ProtocolParameterProvider;
using Repository.TemplateProvider;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateProvider TemplateProvider;
        public TemplateService(ITemplateProvider templateProvider)
        {
            TemplateProvider = templateProvider;
        }

        public void CreateById(string TemplateText, long ProtocolParameterId)
        {
            var newTemplate = new Template
            {
                Text = TemplateText,
                ProtocolParameterId = ProtocolParameterId
            };
            TemplateProvider.Create(newTemplate);
            TemplateProvider.SaveChanges();
        }

        public void CreateByObj(string TemplateText, ProtocolParameter protocolParameter)
        {
            var newTemplate = new Template
            {
                Text = TemplateText,
                ProtocolParameterId = protocolParameter.Id
            };
            TemplateProvider.Create(newTemplate);
            TemplateProvider.SaveChanges();
        }

        public void RemoveById(long TemplateId)
        {
            var template = TemplateProvider
                .GetAll()
                .Where(x => x.Id == TemplateId)
                .FirstOrDefault();
            TemplateProvider.Remove(template);
        }

        public Template GetOneByTempId(long TemplateId)
        {
            var template = TemplateProvider
                .GetAll()
                .Where(x => x.Id == TemplateId)
                .FirstOrDefault();
            return template;
        }

        public List<Template> GetAllByPPId(long ProtParamId)
        {
            var scope = Installer.Init();
            var protocolService = scope.GetRequiredService<IProtocolParameterService>();
            List<Template> templates = protocolService.GetWhisTemplate(ProtParamId);
            return templates;
        }

        public void UpdateById(string TemplateText, long TemplateId)
        {
            var templ = TemplateProvider
                .GetAll()
                .Where(x => x.Id == TemplateId)
                .FirstOrDefault();
            templ.Text = TemplateText;
            TemplateProvider.Update(templ);

        }
    }
}
