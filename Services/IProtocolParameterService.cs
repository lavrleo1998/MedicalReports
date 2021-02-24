using Domain;
using DTO.Request;
using System.Collections.Generic;

namespace Services
{
    public interface IProtocolParameterService
    {
        void CreateProtocolParameter(CreateProtocolParameterDTO request);
        ProtocolParameter GetById(long ProtParamId);
        List<Template> GetWhisTemplate(long ProtParamId);
        void RemoveById(long ProtParamId);
        void UpdateById(long ProtParamId, string NewName);
    }
}
