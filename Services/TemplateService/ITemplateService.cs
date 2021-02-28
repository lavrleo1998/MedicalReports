using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface ITemplateService
    {
        public void Create(string templateText, long paramId);
        public Template Get(long TemplateId);
        public List<Template> GetAll(long paramId);
        public void Remove(long templateId);
        public void RemoveAll(long paramId);
        public void UpdateById(string TemplateText, long TemplateId);
    }
}