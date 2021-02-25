using Domain;
using System.Collections.Generic;

namespace Services
{
    public interface ITemplateService
    {
        void Create(string templateText, long paramId);
        List<Template> GetAllByPPId(long paramId);
        Template GetOneByTempId(long TemplateId);
        void Remove(long templateId);
        void UpdateById(string TemplateText, long TemplateId);
    }
}