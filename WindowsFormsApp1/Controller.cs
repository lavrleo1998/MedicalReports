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
        
        public static void FillIn(ComboBox combobox, long protParmId)
        {
            var texts = TemplContr.GiveMeTemplTexts(protParmId);
            combobox.DataSource = texts;
            combobox.DisplayMember = "Name";
            combobox.ValueMember = "";
        }

        public static void newTempl (string text, long protParmId)
        {
            TemplContr.Add(text, protParmId);
        }





    }
}
