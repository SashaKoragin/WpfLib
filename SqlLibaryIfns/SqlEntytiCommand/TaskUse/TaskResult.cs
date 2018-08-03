﻿using System;
using System.Collections.Generic;
using SqlLibaryIfns.SqlSelect.SqlReshenia;
using System.Reflection;
using SqlLibaryIfns.SqlZapros.StoreProcedure;
using System.Threading.Tasks;
using LibaryXMLAuto.ModelXmlSql.Model.FullSetting;

namespace SqlLibaryIfns.SqlEntytiCommand.TaskUse
{
   public class TaskResult
    {
        /// <summary>
        /// Выбор процедуры в зависимости от настроек:
        /// 1 - Процедура добавления значения на добавления
        /// 2 - Процедура запуска процесса решений
        /// 3 - Процедура запуска инкассовых поручений
        /// Процесс генерации параметров для процедуры нужно улучшить!!!!
        /// </summary>
        /// <param name="connection">Строка соединения</param>
        /// <param name="seting">Настойки</param>
        /// <returns>Строка с ответа с сервера</returns>
        public async Task<string> TaskSqlProcedure(string connection, FullSetting seting)
        {
            StartProcedure startprocedure = new StartProcedure();

            Dictionary<string, string> listparametr = null;
            if (seting.ParametrReshen.D270!=0)
            {
                CreateParamert(ref listparametr,seting.ParametrReshen.GetType(), seting.ParametrReshen);
            }
            switch (seting.Id)
            {
                case 1:
                    return await Task.Factory.StartNew(()=> startprocedure.StartingProcedure(connection,ProcedureReshenie.ProcedureAddTreb, listparametr));
                case 2:
                    return await Task.Factory.StartNew(() => startprocedure.StartingProcedure(connection, ProcedureReshenie.ProcedureStartTreb, listparametr));
                case 3:
                    return await Task.Factory.StartNew(() => startprocedure.StartingProcedure(connection, ProcedureReshenie.ProcedureStartIncass, listparametr));
                default:
                    return null;
            }
        }
        /// <summary>
        /// Выбор процедуры в зависимости от настроек:
        /// 1 - Процедура предварительного анализа
        /// 2 - Процедура запуска процесса BDK
        /// Процесс генерации параметров для процедуры нужно улучшить!!!!
        /// </summary>
        /// <param name="connection">Строка соединения</param>
        /// <param name="seting">Настройка</param>
        /// <returns></returns>
        public async Task<string> TaskSqlProcedureBdk(string connection, FullSetting seting)
        {
            StartProcedure startprocedure = new StartProcedure();
            Dictionary<string, string> listparametr = null;
            if (seting.ParametrBdk.N269 != 0)
            {
                CreateParamert(ref listparametr, seting.ParametrBdk.GetType(), seting.ParametrBdk);
            }
            switch (seting.Id)
            {
                case 1:
                    return await Task.Factory.StartNew(() => startprocedure.StartingProcedure(connection, SqlSelect.SqlBdkIt.SqlBdkIt.StartAnalis, listparametr));
                case 2:
                    return await Task.Factory.StartNew(() => startprocedure.StartingProcedure(connection, SqlSelect.SqlBdkIt.SqlBdkIt.StartBdk, listparametr));
               default:
                    return null;
            }
        }

        /// <summary>
        /// Процесс генерации словаря параметров для процедуры если они есть
        /// </summary>
        /// <param name="listparametr">ref вернет ссылку на обект с изменениями Словарь параметров</param>
        /// <param name="param">Тип класса из функции GetType()</param>
        /// <param name="ob">Сам класс в виде object</param>
        public void CreateParamert(ref Dictionary<string, string> listparametr,Type param,object ob)
        {
            listparametr = new Dictionary<string, string>();
            if (param.IsClass)
            {
                PropertyInfo[] property = param.GetProperties();
                
                foreach (var prop in property)
                {
                        var value =prop.GetValue(ob,null);
                        var name = prop.Name;
                    if (value!=null)
                    {
                        listparametr.Add("@" + name, value.ToString());
                    } 
                }
            }
        }
  }
}
