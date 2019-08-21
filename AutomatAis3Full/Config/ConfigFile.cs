﻿using System.Collections.Generic;
using System.Configuration;

namespace AutomatAis3Full.Config
{
   internal class ConfigFile
    {
        public static string FileInn = ConfigurationManager.AppSettings["FileInn"];
        public static string FileFpd = ConfigurationManager.AppSettings["FileFpd"];
        public static string FileJurnalError = ConfigurationManager.AppSettings["FileJurnalError"];
        public static string FileJurnalOk = ConfigurationManager.AppSettings["FileJurnalOk"];
        public static string FileSpisok = ConfigurationManager.AppSettings["FileSpisok"];
        public static string PathJurnal = ConfigurationManager.AppSettings["PathJurnal"];
        public static string PathInn = ConfigurationManager.AppSettings["PathInn"];
        public static string ExcelReportFile = ConfigurationManager.AppSettings["ExcelReportFile"];
        public static string FileInnFull = ConfigurationManager.AppSettings["FileInnFull"];
        public static string FileFid = ConfigurationManager.AppSettings["FileFid"];
        public static string FidFace = ConfigurationManager.AppSettings["FidFace"];
        public static string VisualId = ConfigurationManager.AppSettings["IdZaprosVisual"];
        public static string ReportMigration = ConfigurationManager.AppSettings["ReportMigration"];
        public static string ServerReport = ConfigurationManager.AppSettings["ServerReport"];
        public static string ServiceAndIpComputer = ConfigurationManager.AppSettings["ServiceAndIpComputer"];
        public static string Ifns = ConfigurationManager.AppSettings["Ifns"];
        public static string Help = ConfigurationManager.AppSettings["Help"];
        /// <summary>
        /// Строка соединения с нашей БД
        /// </summary>
        public static readonly string Connection = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
        /// <summary>
        /// Путь к PDF файлам сохранение Temp
        /// </summary>
        public static string PathPdfTemp = ConfigurationManager.AppSettings["PathPdfTemp"];
        /// <summary>
        /// Путь к PDF файлам сохранение Work
        /// </summary>
        public static string PathPdfWork = ConfigurationManager.AppSettings["PathPdfWork"];

    }
}
