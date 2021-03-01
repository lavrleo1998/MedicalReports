using Domain;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class TemplateService : ITemplateService
    {
        private readonly ITemplateProvider TemplateProvider;
        public TemplateService(ITemplateProvider templateProvider)
        {
            TemplateProvider = templateProvider;
        }
        /// <summary>
        /// Глобальные переменные
        /// </summary>
        private static ServiceProvider scope = Installer.Init();
        private static IParamService ParamService = scope.GetRequiredService<IParamService>();


        /// <summary>
        /// Функция создания нового шаблона.
        /// Требует на вход текст шаблона и айди параметра,
        /// для которого создаётся новый шаблон.
        /// </summary>
        /// <param name="templateText"></param>
        /// <param name="paramId"></param>
        public void Create(string templateText, long paramId)
        {
            var newTemplate = new Template
            {
                Text = templateText,
                ParamId = paramId
            };
            TemplateProvider.Create(newTemplate);
            TemplateProvider.SaveChanges();
        }

        /// <summary>
        /// Функция удаления шаблона. Требует айди шаблона.
        /// </summary>
        /// <param name="templateId"></param>
        public void Remove(long templateId)
        {
            var template = TemplateProvider
                .GetAll()
                .Where(x => x.Id == templateId)
                .FirstOrDefault()
                 ?? throw new System.Exception("Шаблон не найдет");

            TemplateProvider.Remove(template);
            TemplateProvider.SaveChanges();
        }

        /// <summary>
        /// Функция удаления всех шаблонов у одного параметра
        /// </summary>
        /// <param name="paramId"></param>
        public void RemoveAll(long paramId)
        {
            List<Template> templates = ParamService.GetWhisTemplate(paramId)
                ?? throw new System.Exception("Шаблон не найдет");
            foreach (var templ in templates)
            {
                TemplateProvider.Remove(templ);
            }
            TemplateProvider.SaveChanges();
        }

        /// <summary>
        /// Получение Шаблона по его id
        /// </summary>
        /// <param name="TemplateId"></param>
        /// <returns></returns>
        public Template Get(long TemplateId)
        {
            var template = TemplateProvider
                .GetAll()
                .Where(x => x.Id == TemplateId)
                .FirstOrDefault()
                ?? throw new System.Exception("Шаблон не найдет");
            return template;
        }

        /// <summary>
        /// Получение всех шаблонов по id параметра.
        /// ВОзвращает лит шаблонов
        /// </summary>
        /// <param name="paramId"></param>
        /// <returns></returns>
        public List<Template> GetAll(long paramId)
        {
            List<Template> templates = ParamService.GetWhisTemplate(paramId)
                ?? throw new System.Exception("Шаблон не найдет");
            return templates;
        }

        /// <summary>
        /// Обновление шаблона
        /// </summary>
        /// <param name="TemplateText"></param>
        /// <param name="TemplateId"></param>
        public void UpdateById(string TemplateText, long TemplateId)
        {
            var templ = TemplateProvider
                .GetAll()
                .Where(x => x.Id == TemplateId)
                .FirstOrDefault()
                ?? throw new System.Exception("Шаблон не найдет");
            templ.Text = TemplateText;
            TemplateProvider.Update(templ);
            TemplateProvider.SaveChanges();
        }
    }
}
