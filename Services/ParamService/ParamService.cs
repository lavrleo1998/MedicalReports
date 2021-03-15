﻿using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    class ParamService : IParamService
    {
        //private readonly IParamProvider ParamProvider;
        //private readonly ITemplateService TemplateService;
        //private readonly IOrganService OrganService;
        //public ParamService(IParamProvider ParamProvider, IOrganService OrganService, ITemplateService TemplateService)
        //{
        //    this.ParamProvider = ParamProvider;
        //    this.OrganService = OrganService;
        //    this.TemplateService = TemplateService;
        //}

        private readonly IParamProvider ParamProvider;
        public ParamService(IParamProvider ParamProvider)
        {
            this.ParamProvider = ParamProvider;
        }
        private static readonly ServiceProvider scope = Installer.Init();
        private static readonly ITemplateService TemplateService = scope.GetRequiredService<ITemplateService>();
        private static readonly IOrganService OrganService = scope.GetRequiredService<IOrganService>();



        /// <summary>
        /// Функция создания нового параметра. Требует на вход имя параметра.
        /// </summary>
        /// <param name="name"></param>
        public void Create(string name)
        {
            var param = new Param
            {
                Name = name
            };
            ParamProvider.Create(param);
            ParamProvider.SaveChanges();
        }
        

        /// <summary>
        /// Функция удаления параметра. 
        /// Удаляет по айди параметр и все шаблоны к нему.
        /// Обращается к методу сервисов шаблона RemoveAll
        /// </summary>
        /// <param name="paramId"></param>
        public void Remove(long paramId)
        {
            var param = ParamProvider
                .GetAll()
                .Where(x => x.Id == paramId)
                .FirstOrDefault()
                ?? throw new Exception("Параметр не найдет");

            TemplateService.RemoveAll(paramId);
            ParamProvider.Remove(param);
            ParamProvider.SaveChanges();
        }

        /// <summary>
        /// Удаляет все параметры одного органа
        /// </summary>
        /// <param name="organId"></param>
        public void RemoveAll(long organId)
        {
            List<Param> paramS = OrganService.GetWhisParams(organId)
                ?? throw new Exception("Параметр не найден");
            foreach (var param in paramS)
            {
                this.Remove(param.Id);
            }
            ParamProvider.SaveChanges();
        }

        /// <summary>
        /// Получение параметра по его Id
        /// </summary>
        /// <param name="paramId"></param>
        /// <returns></returns>
        public Param GetById(long paramId)
        {
            var param = ParamProvider
                .GetAll()
                .Where(x => x.Id == paramId)
                .FirstOrDefault()
                ?? throw new Exception("Параметр не найдет");
            return param;
        }

        /// <summary>
        /// Получение параметра по его имени и Id органа, к которому параметр принадлежит.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="organId"></param>
        /// <returns></returns>
        public Param GetByNameAndOrganId(string name, long organId)
        {
            var param = ParamProvider
                .GetAll()
                .Where(x => x.Name == name & x.OrganId == organId)
                .FirstOrDefault()
                ?? throw new Exception("Параметр не найдет");
            return param;
        }

        /// <summary>
        /// Возвращает все параметры одного органа по номеру Органа
        /// </summary>
        /// <param name="organId"></param>
        /// <returns></returns>
        public List<Param> GetAllByOrgan(long organId)
        {
            var paramList = ParamProvider
                .GetAll()
                .Where(x => x.OrganId == organId)
                .Select(x => x).ToList()
                ?? throw new Exception("Параметр не найдет");
            return paramList;
        }

        /// <summary>
        /// Получить параметр вместе с его шаблонами
        /// </summary>
        /// <param name="paramId"></param>
        /// <returns></returns>
        public List<Template> GetWhisTemplate(long paramId)
        {
            var templates = new List<Template>();
            var templatesICollection = ParamProvider
                .GetAll()
                .Include(x => x.Templates)
                .Where(x => x.Id == paramId)
                .Select(x => x.Templates).ToList()
                ?? throw new Exception("Параметр не найдет");

            foreach (var item in templatesICollection)
            {
                var items = item.ToList();
                templates.AddRange(items);
            }
            return templates;
        }

        /// <summary>
        /// Обновить парметр
        /// </summary>
        /// <param name="paramId"></param>
        /// <param name="newName"></param>
        public void Update(long paramId, string newName)
        {
            var param = ParamProvider
               .GetAll()
               .Where(x => x.Id == paramId)
               .FirstOrDefault()
               ?? throw new Exception("Параметр не найдет");
            param.Name = newName;
            ParamProvider.Update(param);
            ParamProvider.SaveChanges();
        }
    }
}
