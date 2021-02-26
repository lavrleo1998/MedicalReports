using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface ITemplateService
    {
        void Create(string templateText, long paramId);
        Template Get(long TemplateId);
        List<Template> GetAll(long paramId);
        void Remove(long templateId);
        void RemoveAll(long paramId);
        void UpdateById(string TemplateText, long TemplateId);
    }
}