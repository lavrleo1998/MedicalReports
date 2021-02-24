using Domain;
using DTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ITemplateService 
    {
        void CreateById(string TemplateText, long ProtocolParameterId);
        void CreateByObj(string TemplateText, ProtocolParameter protocolParameter);
        List<Template> GetAllByPPId(long ProtParamId);
        Template GetOneByTempId(long TemplateId);
        void RemoveById(long TemplateId);
        void UpdateById(string TemplateText, long TemplateId);

    }
}
