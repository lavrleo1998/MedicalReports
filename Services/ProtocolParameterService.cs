
using Domain;
using DTO.Request;
using Repository.ProtocolParameterProvider;

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
            throw new System.NotImplementedException();
        }
    }
}
