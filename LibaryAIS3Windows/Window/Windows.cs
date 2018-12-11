﻿using AutoIt;
using System.Drawing;

namespace LibaryAIS3Windows.Window
{
    /// <summary>
    /// Класс констант текста АИС 3
    /// </summary>
   public class WindowsAis3
    {
        /// <summary>
        /// Для наведения фокуса на Аиз 3
        /// </summary>
        internal static string GridWinAis3 = "[NAME:gridData]";
       /// <summary>
       /// Переменная для второго параметра Text 
       /// </summary>
        internal static string Text = "";

        /// <summary>
        /// Константа символизирует окно АИС 3 Title
        /// </summary>
        internal static string AisNalog3 = "АИС Налог-3 ПРОМ ";
        /// <summary>
        /// Переменная для подготовки условия Пожалйста подождите
        /// </summary>
       internal static string WinWait = "Подготовка условий. Пожалуйста подождите...";
       /// <summary>
       /// Нет Данных при отборе
       /// </summary>
       internal static string DataNotFound = "Данные, удовлетворяющие заданным условиям не найдены.";
        /// <summary>
        /// Обновление Данных пожалуйста подождите
        /// </summary>
       internal static string UpdateDataSource = "Обновление данных. Пожалуйста подождите...";
        /// <summary>
        /// Считать позицию Общего окна АИС 3
        /// </summary>
        internal Rectangle WindowsAis = AutoItX.WinGetPos(AisNalog3, Text);
        /// <summary>
        /// Считать позицию создание заявки на формирование СНУ
        /// Так- же данная функция работае для пользовательских заданий
        /// </summary>
        internal Rectangle WinRequest = AutoItX.ControlGetPos("АИС Налог-3 ПРОМ ", "", "[NAME:CreateRequestImplView]");
        /// <summary>
        /// Grid контроль полей для вычисления
        /// </summary>
        internal Rectangle WinGrid = AutoItX.ControlGetPos("АИС Налог-3 ПРОМ ", "", "[Name:gridConditions]");

        /// <summary>
        /// Контроль поле для пользовательских заданий
        /// </summary>
        internal Rectangle GridMain = AutoItX.ControlGetPos("АИС Налог-3 ПРОМ ", "", "[NAME:mainGrid]");
        /// <summary>
        /// Контрольная панель
        /// </summary>
        internal Rectangle ControlPanel = AutoItX.ControlGetPos("АИС Налог-3 ПРОМ ", "", "[NAME:tsControlPanel]");
        /// <summary>
        /// Проверка наличия окна АИС налог 3 
        /// если вернет 1 то окно существует если 0 то не существует!!!
        /// </summary>
        /// <returns>Возвращает 1 или 0 </returns>
        public int WinexistsAis3()
        {
            return AutoItX.WinExists(AisNalog3, Text);
        }
    }
}
