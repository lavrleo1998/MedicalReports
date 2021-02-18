using Microsoft.Extensions.DependencyInjection;
using Services;

namespace Controller
{
    public class Class1
    {
        public string Add(string text)
        {
            var scope = Installer.Init();
            var templateService = scope.GetRequiredService<ITemplateService>();
            templateService.CreateTemplate(text);
            string response = "Добавлено";
            return response;
        }
    }
}
