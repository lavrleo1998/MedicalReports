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
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly IParamService ParamService = scope.GetRequiredService<IParamService>();
        private static readonly IOrganService OrganService = scope.GetRequiredService<IOrganService>();
        /// <summary>
        /// Получение строк для объектов формы.
        /// 
        /// </summary>
        /// <param name="organName"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        public static long FindParamByName(Label organName, Label param)
        {
            long organId = OrganService.GetByName(organName.Text).Id;
            long paramId = ParamService.GetByNameAndOrganId(param.Text, organId).Id;
            return paramId;
        }
    }
}
