using Microsoft.Extensions.DependencyInjection;
using Services;
using System.Collections.Generic;
namespace WindowsFormsApp1
{
    public static class TemplContr
    {

        private static ServiceProvider scope = Installer.Init();
        private static ITemplateService TemplateService = scope.GetRequiredService<ITemplateService>();

        public static void Add(string text, long protParmId)
        {

            TemplateService.Create(text, protParmId);

        }
        public static List<string> GiveMeTemplTexts(long protParmId)
        {
            var templates = TemplateService.GetAll(protParmId);
            var texts = new List<string>();
            foreach (var template in templates)
            {
                texts.Add(template.Text);
            }
            return texts;
        }

    }
}
