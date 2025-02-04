using System;
using LibraryAIS3Windows.ButtonsClikcs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAIS3Windows.AutomationsUI.LibaryAutomations;
using LibraryAIS3Windows.Window;
using System.Linq;
using System.Windows.Automation;
using System.Runtime.InteropServices;
using System.Data;

using AttributeHelperModelXml;

using Net.SourceForge.Koogra;
using EfDatabaseAutomation.Automation.BaseLogica.XsdShemeSqlLoad.XsdAllBodyData;
using EfDatabaseAutomation.Automation.BaseLogica.XsdShemeSqlLoad;
using LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction;
using LibraryAIS3Windows.AutomationsUI.Otdels.PublicJournal129And121;
using System.DirectoryServices.AccountManagement;
using System.Globalization;
using System.Text.RegularExpressions;
using AutoIt;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using LibaryDocumentGenerator.Documents.Template;
using ZXing;
using ZXing.PDF417.Internal;
using ZXing.Rendering;
using LibraryAIS3Windows.AutomationsUI.Otdels.Registration;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Windows.Input;
using WindowsInput;
using WindowsInput.Native;
using LibraryAIS3Windows.AutomationsUI.PublicElement;
using ViewModelLib.ModelTestAutoit.PublicModel.ButtonStartAutomat;

namespace LibraryAIS3Windows.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для KclicerButton</summary>
    [TestClass]
    public partial class KclicerButtonTest
    {
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        [DllImport("user32.dll")]
        //[return:MarshalAs(UnmanagedType.Bool)]
        static extern bool PostMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        [TestMethod]
        public void TestMet()
        {
            var kbk = "18210102040011000110";
            var Inn = "502499333103";
            var InnMo = "5024002119";
            var KppMo = "502401001";
            var Oktmo = "46744000";
            var bik = "004525987";
            var Name = "Управление Федерального казначейства по Московской области";
            var KbkCash = "03100643000000014800";
            LibraryAutomations libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);

            while (true)
            {

                if (libraryAutomation.IsEnableElements(IncomeJournalKrsb.DateResh, null, false, 5) != null)
                {
                    libraryAutomation.SetLegacyIAccessibleValuePattern(DateTime.Now.ToString("dd.MM.yy"));
                    var list = libraryAutomation.SelectAutomationColrction(libraryAutomation.IsEnableElements(IncomeJournalKrsb.GridSelect)).Cast<AutomationElement>().Where(elem => elem.Current.Name.Contains("List`1 row ")).Distinct();
                    foreach (var row in list)
                    {
                        var elemCheck = libraryAutomation.SelectAutomationColrction(row).Cast<AutomationElement>().First(elem => elem.Current.Name.Contains("выбор"));
                        libraryAutomation.ClickElement(elemCheck);
                    }
                    break;
                }
            }

            //while (true)
            //{
            //    if (libraryAutomation.IsEnableElements(IncomeJournalKrsb.MemoNum, null, false, 5) != null)
            //    {
            //        libraryAutomation.SetLegacyIAccessibleValuePattern("1");
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Data, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(DateTime.Now.ToString("dd.MM.yyyy"));
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.InnMemo, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(Inn);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Status, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern("13");
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Kbk, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(kbk);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Inn, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(InnMo);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Kpp, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(KppMo);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.Oktmo, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(Oktmo);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.KbkCash, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(KbkCash);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.BicCash, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(bik);
            //        libraryAutomation.IsEnableElements(IncomeJournalKrsb.NameCash, null, true);
            //        libraryAutomation.SetLegacyIAccessibleValuePattern(Name);
            //        break;
            //    }
            //}



        }

        public static SecureString ConvertSecureString(string password)
        {
            if(password==null)
                throw new ArgumentException("password");
            unsafe
            {
                fixed (char* passwordChars = password)
                {
                    var securePassword = new SecureString(passwordChars, password.Length);
                    securePassword.MakeReadOnly();
                    return securePassword;
                }
            }
        }

        [TestMethod]
        public void MethodStartAis3()
        {
            var tree = "Налоговое администрирование\\Контрольная работа (налоговые проверки)\\051. Синхронизация данных СЭОД – Налог-3 (Входящие сведения)\\00001. Все входящие сведения (ЭОД - Налог-3)";
            var pathAis3 = "C:\\Program Files (x86)\\Ais3Prom\\Client\\CommonComponents.UnifiedClient.exe";
            if (!File.Exists(pathAis3))
            {
                return;
            }
            var startInfo = new ProcessStartInfo()
            {
                FileName = pathAis3,
                UseShellExecute = false,
                CreateNoWindow = true,
                UserName = "7751-00-099",
                Password =  ConvertSecureString("Qwerty12345678("),
                Domain = "REGIONS"
            };
            var process = System.Diagnostics.Process.Start(startInfo);
            while (process.MainWindowTitle != WindowsAis3.AisNalog3)
            {
                process.Refresh();
            }
            LibraryAutomations libraryAutomation = new LibraryAutomations(process.MainWindowHandle);
            if (libraryAutomation.IsFocusableElement(PublicElementName.FullTreeIfns))
            {
                libraryAutomation.InvokePattern(libraryAutomation.FindFirstElement(PublicElementName.ShowAll));
                var sw = tree.Split('\\').Last();
                var fullTree = string.Concat(PublicElementName.FullTree, $"Name:{sw}");
                libraryAutomation.IsEnableExpandTree(tree);
                libraryAutomation.FindFirstElement(fullTree, null, true);
                libraryAutomation.SelectionComboBoxSelectionItemPattern(libraryAutomation.FindElement);
                libraryAutomation.InvokePattern(libraryAutomation.FindFirstElement(PublicElementName.OpenTree, null, true));
            }
        }
        [TestMethod]
        public void MethodTrebovanie()
        {
            KclicerButton s20 = new KclicerButton();
            s20.Click22(null, null, null);
        }
        [TestMethod]
        public void MethodStatementOfficeNote()
        {
            KclicerButton s20 = new KclicerButton();
            s20.Click25(null);
        }

        [TestMethod]
        public void TestCombobox()
        {
          var index = SelectArrayToNumberButton(5);
          var index1 = SelectArrayToNumberButton(6);
          var index2 = SelectArrayToNumberButton(7);
          var index3 = SelectArrayToNumberButton(8);
          var index4 = SelectArrayToNumberButton(9);
          var index5 = SelectArrayToNumberButton(10);
          var index6 = SelectArrayToNumberButton(11);
          var index7 = SelectArrayToNumberButton(12);
          var index8 = SelectArrayToNumberButton(13);
          var array47 = SelectArrayToNumberButton(5000);
        }


        public Dictionary<int, int> SelectArrayToNumberButton(int number)
        {
            var startArray = new[] { 2, 4 };
            var arrayStart = new Dictionary<int, int>() { { startArray[0], startArray[1] } };
            var min_Row = 5;
            var stepRow = 3;
            if (number < min_Row) return null;
            var indexRow = (int)Math.Floor((decimal)(number - min_Row) / stepRow);
            if (indexRow != 0)
            {
                while (indexRow > 0)
                {
                    arrayStart.Add(startArray[0] += stepRow, startArray[1] += stepRow);
                    indexRow--;
                }
                return arrayStart;
            }
            return arrayStart;
        }

        public Dictionary<int, int> SelectArrayToNumberChekBox(int number)
        {
            var startArray = new[] { 6, 0 };
            var arrayStart = new Dictionary<int, int>() { { startArray[0], startArray[1] } };
            var min_Row = 6;
            var stepRow = 14;
            if (number < min_Row) return null;
            var indexRow = (int)Math.Floor((decimal)(number - min_Row) / stepRow);
            if (indexRow != 0)
            {
                while (indexRow > 0)
                {
                    arrayStart.Add(startArray[0] += stepRow, startArray[1] += 1);
                    indexRow--;
                }
                return arrayStart;
            }
            return arrayStart;
        }

        [TestMethod]
        public void Okp2Reshenia()
        {
            LibraryAutomations libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);
            if (libraryAutomation.IsEnableElements(Journal129AndJournal121.ListCashFace, null, true) != null)
            {

                AutomationElement cashAdd;
                LibraryAutomations libraryAutomationDialog = new LibraryAutomations(WindowsAis3.AisNalog3);
                LibraryAutomations libraryAutomationAddObject;
                AutomationElement listView;

                while ((cashAdd = libraryAutomation.IsEnableElements(Journal129AndJournal121.ListCashFace, null, false, 10)) != null)
                {
                    var TextBox = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "TextBox").ToArray();
                    var flag = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "CheckBox").ToArray();
                    var indexChekBoxAndTextSumm = SelectArrayToNumberChekBox(TextBox.Length);
                    foreach (var box in indexChekBoxAndTextSumm)
                    {
                       var summ = Convert.ToInt32(libraryAutomation.ParseElementLegacyIAccessiblePatternIdentifiers(TextBox.ElementAtOrDefault(box.Key)));
                        if (summ <= 0)
                        {
                            libraryAutomation.TogglePatternInputAndStatus(flag.ElementAtOrDefault(box.Value));
                        }
                    }
                    var elem = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "Button").ToArray();
                    libraryAutomation.InvokePattern(elem.ElementAtOrDefault(0));
                    var dictionary = SelectArrayToNumberButton(elem.Length);
                    var flagExit = 0;
                    foreach (var dict in dictionary)
                    {
                        while ((cashAdd = libraryAutomation.IsEnableElements(Journal129AndJournal121.ListCashFace, null, false, 10)) != null)
                        {
                            elem = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "Button").ToArray();
                            flag = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "CheckBox").ToArray();
                            var elementKey = elem.ElementAtOrDefault(dict.Key);
                            if (elementKey == null || flagExit == flag.Length) //Это в случае если нет внутри обстоятельств
                            {
                                return;
                            }
                            libraryAutomation.InvokePattern(elementKey);
                            var flagExitYes = libraryAutomation.SelectAutomationColrction(cashAdd).Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "CheckBox").ToArray();
                            if (flagExitYes.Length > flag.Length)
                            {
                                break;
                            }
                            libraryAutomation.InvokePattern(elem.ElementAtOrDefault(dict.Value));
                            AutoItX.Sleep(2000);
                            libraryAutomationAddObject = new LibraryAutomations(TreeWalker.RawViewWalker.GetPreviousSibling(libraryAutomationDialog.RootAutomationElements));
                            PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect1Obs);
                            while ((listView = libraryAutomationAddObject.IsEnableElements(Journal129AndJournal121.WinSelectErrorPopup, null, false, 10)) != null)
                            {
                                while (true)
                                {
                                    elem = libraryAutomationAddObject.SelectAutomationColrction(listView).Cast<AutomationElement>().Where(elems => elems.Current.Name == "Rnivc.Cam.Nsi.Business.TaxKindCircumstanceEntity").ToArray();
                                    libraryAutomationAddObject.SelectionComboBoxPattern(elem[4]);
                                    break;
                                }
                                break;
                            }
                            PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect2Obs);
                            while ((listView = libraryAutomationAddObject.IsEnableElements(Journal129AndJournal121.WinSelectErrorPopup, null, false, 10)) != null)
                            {
                                while (true)
                                {
                                    elem = libraryAutomationAddObject.SelectAutomationColrction(listView).Cast<AutomationElement>().Where(elems => elems.Current.Name == "Rnivc.Cam.Nsi.Business.TaxCircumstanceEntity").ToArray();
                                    libraryAutomationAddObject.SelectionComboBoxPattern(elem[0]);
                                    break;
                                }
                                break;
                            }
                            PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelectCircumstanceOk);
                            flagExit += 2;
                            break;
                        }
                    }
                    break;
                }
            }

        }

            /// <summary>
            /// Если выходные то плюсуем
            /// </summary>
            /// <param name="dateTime">Дата для проверки выходного дня</param>
            /// <returns></returns>
            private DateTime IsWeekends(DateTime dateTime)
        {
            if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                dateTime = dateTime.AddDays(2);
            if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                dateTime = dateTime.AddDays(1);
            return dateTime;
        }


        /// <summary>
        /// Перевод листа xlsx в DataTable
        /// </summary>
        /// <param name="pathXlsx">Путь к xlsx</param>
        /// <param name="sheetName">Имя листа</param>
        /// <param name="indexColumn">Индекс колонки по умолчанию 1</param>
        /// <param name="indexRow">Индекс строки с какой начинать</param>
        /// <returns></returns>
        public DataTable GetDateTableXslx(string pathXlsx, string sheetName, int indexColumn = 1, uint indexRow = 0)
        {
            DataTable dt = new DataTable();
            var xlFile = WorkbookFactory.GetExcel2007Reader(pathXlsx);
            var sheet = xlFile.Worksheets.GetWorksheetByName(sheetName, true);

            uint minRow = sheet.FirstRow + indexRow;
            uint maxRow = sheet.LastRow;

            IRow firstRow = sheet.Rows.GetRow(minRow);

            uint minCol = sheet.FirstCol;
            uint maxCol = sheet.LastCol;

            for (uint i = minCol; i <= maxCol; i++)
            {
                var valueNameColums = firstRow.GetCell(i).GetFormattedValue();
                if (!dt.Columns.Contains(valueNameColums))
                {
                    dt.Columns.Add(valueNameColums);
                }
                else
                {
                    dt.Columns.Add(string.Concat(valueNameColums, indexColumn));
                    indexColumn++;
                }
            }
            for (uint i = minRow + 1; i <= maxRow; i++)
            {
                IRow row = sheet.Rows.GetRow(i);
                if (row != null)
                {
                    DataRow dr = dt.NewRow();
                    for (uint j = minCol; j <= maxCol; j++)
                    {
                        ICell cell = row.GetCell(j);
                        if (cell != null)
                        {
                            if (cell.Value != null)
                            {
                                double result;
                                // Try parsing in the current culture
                                if (!double.TryParse(cell.Value.ToString(), NumberStyles.Any, CultureInfo.CurrentCulture, out result) &&
                                    // Then try in US english
                                    !double.TryParse(cell.Value.ToString(), NumberStyles.Any,
                                        CultureInfo.GetCultureInfo("en-US"), out result) &&
                                    // Then in neutral language
                                    !double.TryParse(cell.Value.ToString(), NumberStyles.Any,
                                        CultureInfo.InvariantCulture, out result))
                                {
                                    dr[Convert.ToInt32(j)] = cell.Value != null ? cell.GetFormattedValue() : string.Empty;
                                }
                                else
                                {
                                    dr[Convert.ToInt32(j)] = result.ToString();
                                }
                            }
                            else
                            {
                                dr[Convert.ToInt32(j)] = null;
                            }
                        }
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    


    [TestMethod]
        public void Send()
        {
            var pathXlsx = @"D:\WWW.xlsx";
            var sheetName = @"1";
            DataTable dataTable = GetDateTableXslx(pathXlsx, sheetName);
            dataTable.Columns.Remove(dataTable.Columns[0]);
            DataNamesMapper<BookPurchase> mapper = new DataNamesMapper<BookPurchase>();
            var bookSales = new ArrayBodyDoc() { BookPurchase = mapper.Map(dataTable).ToArray() };
        }
        

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);

        private const UInt32 WM_CLOSE = 0x0010;

        void CloseWindow(IntPtr hwnd)
        {
            SendMessage(hwnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
        }

        [TestMethod]
        public void TestTableMapper()
        {
            PublicGlobalFunction.CloseProcessProgram("AcroRd32");
        }


        [TestMethod]
        public void TestNewSendForm()
        {
            var period = "за 12 месяцев, квартальный";
            var god = 2021;
            //Проверка КНД Выставляем шаблон
            if (period != "за 12 месяцев, квартальный" && god <= 2022)
            {
                //Не меняем 30 на 25
            }
            else
            {
                //Меняем 30 на 25
            }

        }

        [TestMethod]
        public void TestTableIkn()
        {
            using (PrincipalContext context = new PrincipalContext(ContextType.Domain, "regions.tax.nalog.ru"))
            {
                using (var user = UserPrincipal.FindByIdentity(context, "7751-00-469"))
                {

                    var group = user.GetGroups();
                    var groups = new string[group.Count()];
                    var i = 0;
                    foreach (var gr in group)
                    {
                        groups[i] = gr.Name;
                        i++;
                    }
                }
            }
        }
        /// <summary>
        /// Тест расчета месяца
        /// </summary>
        [TestMethod]
        public void TestMouthDeclaration()
        {
            using (var context = new EfDatabaseAutomation.Automation.Base.Automation())
            {
              var t = context.DeclarationDataFls.Where(x => x.RegNumDecl == 1457848780).ToArray();

             var s =  t.Where(model => model.CodeString == "П0388").Select(cash => Convert.ToDouble(cash.Error)).Sum();
            }
        }
        [TestMethod]
        public void TestDates()
        {
            LibraryAutomations libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);
            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ErrorGroup3);
            if (libraryAutomation.IsEnableElements(Journal129AndJournal121.ListCashFaceGr3, null, true) != null)
            {
                AutomationElement cashAdd;
                while ((cashAdd = libraryAutomation.IsEnableElements(Journal129AndJournal121.ListCashFaceGr3, null, false, 10)) != null)
                {
                    while (true)
                    {
                       var elem = libraryAutomation.SelectAutomationColrction(cashAdd)
                                         .Cast<AutomationElement>().Where(elems => elems.Current.ClassName == "Button").ToArray();
                     
                        libraryAutomation.ClickElement(elem[2]);
                        if (libraryAutomation.IsEnableElements(Journal129AndJournal121.ButtonGroup3Add2Add, null, true) != null)
                        {
                            libraryAutomation.ClickElement(libraryAutomation.IsEnableElements(Journal129AndJournal121.ButtonGroup3Add2Add));
                            break;
                        }
                    }
                    break;
                }
                LibraryAutomations libraryAutomationDiaolog = new LibraryAutomations(WindowsAis3.AisNalog3);
                AutoItX.Sleep(2000);
                LibraryAutomations libraryAutomationAddObject = new LibraryAutomations(TreeWalker.RawViewWalker.GetPreviousSibling(libraryAutomationDiaolog.RootAutomationElements));
                PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect1);
                AutomationElement listView;
                while ((listView = libraryAutomationAddObject.IsEnableElements(Journal129AndJournal121.WinSelect1Select, null, false, 10)) != null)
                {
                    while (true)
                    {
                        var elem = libraryAutomationAddObject.SelectAutomationColrction(listView)
                                          .Cast<AutomationElement>().Where(elems => elems.Current.Name == "Rnivc.Cam.Nsi.Business.TaxKindCircumstanceEntity").ToArray();
                        libraryAutomationAddObject.SelectionComboBoxPattern(elem[4]);
                        break;
                    }
                }
                PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect2);
                while ((listView = libraryAutomationAddObject.IsEnableElements(Journal129AndJournal121.WinSelect2Select, null, false, 10)) != null)
                {
                    while (true)
                    {
                        var elem = libraryAutomationAddObject.SelectAutomationColrction(listView)
                                          .Cast<AutomationElement>().Where(elems => elems.Current.Name == "Rnivc.Cam.Nsi.Business.TaxCircumstanceEntity").ToArray();
                        libraryAutomationAddObject.SelectionComboBoxPattern(elem[0]);
                        break;
                    }
                }
                PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelectCircumstanceOk);
                //    AutoItX.Sleep(1000);
                //PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect1Select);
                //AutoItX.Sleep(1000);
                //AutoItX.Send(ButtonConstant.Tab);
                //PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect2);
                //AutoItX.Sleep(1000);
                //PublicGlobalFunction.WindowElementClick(libraryAutomationAddObject, Journal129AndJournal121.WinSelect2Select);
                //AutoItX.Sleep(1000);
                //AutoItX.Send(ButtonConstant.Tab);
                //libraryAutomationAddObject.IsEnableElements(Journal129AndJournal121.WinSelect2);
                //libraryAutomationAddObject.SetValuePattern("22");

                //if (!string.IsNullOrEmpty(sender))
                //{
                //    if (libraryAutomationSign.IsEnableElements(Journal129AndJournal121.SenderSign, null, true) != null)
                //    {
                //        libraryAutomationSign.SetValuePattern(sender);
                //    }
                //}
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.AddNewErrror1293);

                //libraryAutomation.SetValuePattern("12911012");
                //libraryAutomation.IsEnableElements(Journal129AndJournal121.WinSelect2);
                //libraryAutomation.SetValuePattern("12911012");
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.WinSelectOk);
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.AddNewCircumstance1293);
                //libraryAutomation.IsEnableElements(Journal129AndJournal121.WinSelectCircumstance1);
                //libraryAutomation.SetValuePattern("отсутствие обстоятельств");
                //libraryAutomation.IsEnableElements(Journal129AndJournal121.WinSelectCircumstance2);
                //libraryAutomation.SetValuePattern("22");
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.WinSelectCircumstanceOk);
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ErrorGroup3);
                //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.Inoe);
                //libraryAutomation.IsEnableElements(Journal129AndJournal121.InoeText);
                //libraryAutomation.SetValuePattern(Journal129AndJournal121.TextInoeTemplate);
            }

            // PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ButtonGroup3Add);
            //PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ButtonGroup3Add2Add);

        }
        [TestMethod]
        public void TestSummPage()
        {
            var min = 100;
            var max = 110;

            List<int> arrInt = new  List<int>();
            arrInt.Add(50);
            arrInt.Add(50);
            arrInt.Add(2);
            arrInt.Add(60);
            arrInt.Add(56);
            arrInt.Add(5);
            arrInt.Add(23);
            arrInt.Add(13);
            arrInt.Add(24);
            var countPageSum = 0;
            foreach (var i in arrInt)
            {
                if (countPageSum + i <= min || countPageSum + i <= max)
                {
                    countPageSum += i;
                    if (countPageSum >= min)
                    {
                        break;
                    }
                }

            }


        }

        private Bitmap ScaleImages(Bitmap bmp, double maxWidth, double maxHeight)
        {
            var ratioX = maxWidth / bmp.Width;
            var ratioY = maxHeight / bmp.Height;
            var ratioMin = Math.Min(ratioX, ratioY);
            var ratioMax = Math.Max(ratioX, ratioY);
            var newWidth = (int) (bmp.Width * ratioMin);
            var newHeight = (int) (bmp.Height * ratioMax);
            var newImage = new Bitmap(newWidth, newHeight, PixelFormat.Format24bppRgb);
            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                graphics.PixelOffsetMode = PixelOffsetMode.Default;

                graphics.DrawImage(bmp, 0 ,0, newWidth, newHeight);
            }
            return newImage;
        }



            public static void SetSelectedComboBoxItem(AutomationElement
comboBox, string item)
        {
            AutomationPattern automationPatternFromElement =
    GetSpecifiedPattern(comboBox,
    "ExpandCollapsePatternIdentifiers.Pattern");

            ExpandCollapsePattern expandCollapsePattern =
    comboBox.GetCurrentPattern(automationPatternFromElement) as
    ExpandCollapsePattern;

            expandCollapsePattern.Expand();
            expandCollapsePattern.Collapse();

            AutomationElement listItem =
    comboBox.FindFirst(TreeScope.Subtree, new
    PropertyCondition(AutomationElement.NameProperty, item));

            automationPatternFromElement = GetSpecifiedPattern(listItem,
    "SelectionItemPatternIdentifiers.Pattern");

            SelectionItemPattern selectionItemPattern =
    listItem.GetCurrentPattern(automationPatternFromElement) as
    SelectionItemPattern;

            selectionItemPattern.Select();
        }

        private static AutomationPattern
GetSpecifiedPattern(AutomationElement element, string patternName)
        {
            AutomationPattern[] supportedPattern = element.GetSupportedPatterns();

            foreach (AutomationPattern pattern in supportedPattern)
            {
                if (pattern.ProgrammaticName == patternName)
                    return pattern;
            }

            return null;
        }

        public class GetFile
        {
            public string namePath { get; set; }
            public DateTime DateWrite { get; set; }
        }
    }


    public static class DateTimeExtensions
    {
        public static DateTime AddWorkdays(this DateTime originalDate, int workDays)
        {
            DateTime tmpDate = originalDate;
            while (workDays > 0)
            {
                tmpDate = tmpDate.AddDays(1);
                if (tmpDate.DayOfWeek < DayOfWeek.Saturday &&
                    tmpDate.DayOfWeek > DayOfWeek.Sunday &&
                    !tmpDate.IsHoliday())
                    workDays--;
            }
            return tmpDate;
        }

        public static bool IsHoliday(this DateTime originalDate)
        {
            // INSERT YOUR HOlIDAY-CODE HERE!
            return false;
        }
    }

}
