using Domain;
using DTO.Request;
using Repository.TemplateProvider;

namespace Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateProvider TemplateProvider;
        public TemplateService(ITemplateProvider templateProvider)
        {
            TemplateProvider = templateProvider;
        }
        public void CreateTemplate(string TemplateText)
        {
            var newTemplate = new Template
            {
                Text = TemplateText,
            };
            TemplateProvider.Create(newTemplate);
            TemplateProvider.SaveChanges();
        }
    }
}
