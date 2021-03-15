using Domain;
using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ParamContr
    {
        
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly IParamService ParamService = scope.GetRequiredService<IParamService>();
        private static readonly IOrganService OrganService = scope.GetRequiredService<IOrganService>();
        
        
        public static long FindParamByName(Label organName, Label param)
        {
            long organId = OrganService.GetByName(organName.Text).Id;
            long paramId = ParamService.GetByNameAndOrganId(param.Text, organId).Id;
            return paramId;
        }
        public static long FindParamByName2(string organName, string param)
        {
            long organId = OrganService.GetByName(organName).Id;
            long paramId = ParamService.GetByNameAndOrganId(param, organId).Id;
            return paramId;
        }

        public static List<Param> GetParamsByOrgan(string exName)
        {
            long organId = OrganService.GetByName(exName).Id;
            var paramList = ParamService.GetAllByOrgan(organId);
            return paramList;
        }
    }
}
