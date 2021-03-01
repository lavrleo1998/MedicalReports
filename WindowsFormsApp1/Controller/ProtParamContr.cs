using Microsoft.Extensions.DependencyInjection;
using Services;

namespace WindowsFormsApp1
{
    public class ProtParamContr
    {
        /// <summary>
        /// Глобальные переменные
        /// </summary>
        private static ServiceProvider scope = Installer.Init();
        private static IParamService ParamService = scope.GetRequiredService<IParamService>();

    }
}
