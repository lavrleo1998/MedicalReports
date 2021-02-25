using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Controller
{
    public class ProtParamContr
    {
        private void Init()
        {
            var scope = Installer.Init();
            var protParamService = scope.GetRequiredService<IProtocolParameterService>();
        }
        public void Add(string text)
        {
            
        }
    }
}
