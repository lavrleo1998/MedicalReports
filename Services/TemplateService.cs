using Domain;
using DTO.Request;
using Microsoft.Extensions.DependencyInjection;
using Repository.ParamProvider;
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

        public void Create(string templateText, long paramId)
        {
            var newTemplate = new Template
            {
                Text = templateText,
                ParamId = paramId
            };
            TemplateProvider.Create(newTemplate);
            TemplateProvider.SaveChanges();
        }

        public void Remove(long templateId)
        {
            var template = TemplateProvider
                .GetAll()
                .Where(x => x.Id == templateId)
                .FirstOrDefault()
                 ?? throw new ServiceErrorException(106);
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

        public List<Template> GetAllByPPId(long paramId)
        {
            var scope = Installer.Init();
            var paramService = scope.GetRequiredService<IParamService>();
            List<Template> templates = paramService.GetWhisTemplate(paramId);
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
