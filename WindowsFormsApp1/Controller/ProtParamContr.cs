using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ProtParamContr
    {
        /// <summary>
        /// Глобальные переменные
        /// </summary>
        private static ServiceProvider scope = Installer.Init();
        private static IParamService ParamService = scope.GetRequiredService<IParamService>();

        public static long FindParamByName(Label label)
        {
            long paramId = ParamService.GetByName(label.Text).Id;
            return paramId;
        }
    }
}
