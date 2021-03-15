using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Collections.Generic;
namespace WindowsFormsApp1
{
    public static class TemplContr
    {
        /// <summary>
        /// Глобальные переменные
        /// </summary>
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly ITemplateService templateService = scope.GetRequiredService<ITemplateService>();

        public static void Add(string text, long protParmId)
        {
             templateService.Create(text, protParmId);
        }
        public static List<string> GiveMeTemplTexts(long protParmId)
        {
            var templates = templateService.GetAll(protParmId);
            var texts = new List<string>();
            foreach (var template in templates)
            {
                texts.Add(template.Text);
            }
            return texts;
        }
    }
}
