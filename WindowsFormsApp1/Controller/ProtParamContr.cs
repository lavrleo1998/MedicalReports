using Microsoft.Extensions.DependencyInjection;
using Services;

namespace WindowsFormsApp1
{
    public class ProtParamContr
    {
        private void Init()
        {
            var scope = Installer.Init();
            var protParamService = scope.GetRequiredService<IParamService>();
        }
        public void Add(string text)
        {

        }
    }
}
