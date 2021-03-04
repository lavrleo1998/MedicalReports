using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Controller
    {
        
        public static void FillIn(Label organName, Label param, ComboBox templ)
        {
            var protParmId = ProtParamContr.FindParamByName(organName, param);
            var texts = TemplContr.GiveMeTemplTexts(protParmId);
            templ.DataSource = texts;
            templ.DisplayMember = "Name";
            templ.ValueMember = "";
        }

        public static void NewTempl (Label organName, string text, Label label)
        {
            var protParmId = ProtParamContr.FindParamByName(organName, label);
            TemplContr.Add(text, protParmId);
        }





    }
}
