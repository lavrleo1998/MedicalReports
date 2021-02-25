using Microsoft.Extensions.DependencyInjection;
using Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Controller
{
    public static class TemplContr
    {
        private static ITemplateService Init()
        {
            var scope = Installer.Init();
            var templService = scope.GetRequiredService<ITemplateService>();
            return templService;
        }

        public static void Add(string text, long protParmId)
        {
            var scope = Installer.Init();
            var templService = scope.GetRequiredService<ITemplateService>();
            templService.CreateById(text, protParmId);

        }
        public static List<string> GiveMeTemplTexts(long protParmId)
        {
            var templateService = Init();
            var templates = templateService.GetAllByPPId(protParmId);
            var texts = new List<string>();
            foreach (var template in templates)
            {
                texts.Add(template.Text);
            }
            return texts;
        }
    }
}
