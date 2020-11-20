// <copyright file="KclicerButtonTest.cs">Copyright ©  2018</copyright>

using System;
using LibraryAIS3Windows.ButtonsClikcs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAIS3Windows.AutomationsUI.LibaryAutomations;
using LibraryAIS3Windows.Window;
using System.Linq;
using AutoIt;
using System.Windows.Automation;
using System.Runtime.InteropServices;
using System.Data;
using Ifns51.FromAis;
using LibraryAIS3Windows.ButtonFullFunction.PreCheck;
using Net.SourceForge.Koogra;
using EfDatabaseAutomation.Automation.BaseLogica.XsdShemeSqlLoad.XsdAllBodyData;
using EfDatabaseAutomation.Automation.BaseLogica.XsdShemeSqlLoad;
using LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction;
using LibraryAIS3Windows.AutomationsUI.Otdels.PublicJournal129And121;

namespace LibraryAIS3Windows.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для KclicerButton</summary>
    [TestClass]
    public partial class KclicerButtonTest
    {
        [TestMethod]
        public void TestMet()
        {
            KclicerButton s0 = new KclicerButton();
            s0.Click15(null, null, null);
        }
        [TestMethod]
        public void Method()
        {
            KclicerButton s20 = new KclicerButton();
            s20.Click20(null, null);
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
            s20.Click25(null, null, null);
        }

        [TestMethod]
        public void TestCombobox()
        {
            try
            {
                var libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);
                var ComboBoxSelect = "AutomationId:LayoutWorkspace\\AutomationId:ShellLayoutView\\AutomationId:ShellLayoutView_Fill_Panel\\AutomationId:taskWindowWorkspaceView1\\AutomationId:RequirementDocDetailView\\AutomationId:grpBig\\AutomationId:tab\\AutomationId:ultraTabPageControl2\\AutomationId:ultraGroupBox1\\AutomationId:ctrlDocDeliveryInfoControl\\AutomationId:grpDeliveryInfo\\AutomationId:cmbDeliveryWay";
                libraryAutomation.SelectItemCombobox(libraryAutomation.IsEnableElements(ComboBoxSelect, null, true), "По каналам ТКС");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }

        [TestMethod]
        public void Okp2Reshenia()
        {

            PublicGlobalFunction.ExcelSaveAndClose();
           // DateTime date = new DateTime(2020, 11, 13);
           // var libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);
           // PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.DocumentSendDelivery);
           // var dateSend = IsWeekends(date.AddDays(5));
           // var dateDelivery = IsWeekends(dateSend.AddDays(6));
           //// taxJournalDelivery.DateSend = dateSend;
           //// taxJournalDelivery.DateDelivery = dateDelivery;
           // while (true)
           // {
           //     if (libraryAutomation.IsEnableElements(Journal129AndJournal121.WinSendAndSend, null, true) != null)
           //     {

            //         libraryAutomation.SetValuePattern(dateSend.ToString("dd.MM.yy"));
            //         libraryAutomation.IsEnableElements(Journal129AndJournal121.WinSendAndDelivery, null, true);
            //         libraryAutomation.SetValuePattern(dateDelivery.ToString("dd.MM.yy"));
            //         PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.WindowSave);
            //         break;
            //     }
            // }

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


        private DataTable GeteDateTableXslx(string pathXlsx, string sheetName, int indexColumn = 1, uint indexRow = 0)
        {
            DataTable dt = new DataTable();
            var xlFile = WorkbookFactory.GetExcel2007Reader(pathXlsx);
            var sheet = xlFile.Worksheets.GetWorksheetByName(sheetName, true);

            uint minRow = sheet.FirstRow+indexRow;
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
                            dr[Convert.ToInt32(j)] = cell.Value != null ? cell.GetFormattedValue() : string.Empty;
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
            var pathXlsx = @"C:\Users\7751-00-525\Desktop\7727500055_Раздел-8_20201111_16-03.xlsx";
            var sheetName = @"Раздел_9(1)";
            DataTable dataTable = GeteDateTableXslx(pathXlsx, sheetName, 1, 3);
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
            DataBaseElementAdd date = new DataBaseElementAdd();
            var t = new AisParsedData();
            date.AddCashBankAllUlFace("", "D:\\13082020_09-36.xlsx", "Sheet1");
        }
        [TestMethod]
        public void TestTableIkn()
        {
          var t =   AutoItX.WinGetHandle("[CLASS:XLMAIN]");
           
            LibraryAutomations libraryAutomation = new LibraryAutomations("[CLASS:XLMAIN]");
            libraryAutomation.RootAutomationElements.SetFocus();
            AutoItX.Send("^s");
            //while (true)
            //{
            //    if (libraryAutomation.IsEnableElements(PreCheckElementName.Xlsx, null) != null)
            //    {
                    
            //        SendKeys.Send("{^S}");
            //        break;
            //    }
            //}
            //LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, PreCheckElementName.ExportXlsx);
            //while (true)
            //{
            //    if (libraryAutomation.IsEnableElements(PreCheckElementName.WinExport, null, true) != null)
            //    {
            //        LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, PreCheckElementName.WinExport);
            //        LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, PreCheckElementName.ExportMenuXlsx);
            //        libraryAutomation.FindFirstElement(PreCheckElementName.ExportNameList);
            //        libraryAutomation.SetValuePattern("Sheet");
            //        LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, PreCheckElementName.Export);
            //    }
            //}
            //  while (true)
            //  {
            //      if (libraryAutomation.IsEnableElements(Journal129AndJournal121.DateReshenia, null, true) != null)
            //      {
            //          var date = new DateTime(2020, 3, 20);
            //          date = date.AddDays(5);
            //          DateTime dateVAdd = date;
            //          if (date.DayOfWeek == DayOfWeek.Saturday)
            //              dateVAdd = date.AddDays(2);
            //          if (date.DayOfWeek == DayOfWeek.Sunday)
            //              dateVAdd = date.AddDays(1);
            //          libraryAutomation.SetValuePattern(dateVAdd.Date.ToString("dd.MM.yy"));
            //          //PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.Established);
            //          //libraryAutomation.SetValuePattern(string.Format(Journal129AndJournal121.Template1151006, journal.Period, journal.God, journal.DateFinishDeclaration?.ToString("dd.MM.yyyy"), journal.DateStartDeclaration?.ToString("dd.MM.yyyy")));
            //          //PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.SaveAktNo);
            //          //PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.SignAktNo);
            //          //SaveSendDoc(libraryAutomation, journal, "Акт успешно выставлен!!!", "Акт");
            //          break;
            //      }
            //  }


            //  //while (true)
            //  //{
            //  //    if (libraryAutomationSign.IsEnableElements(Journal129AndJournal121.DateFinish, null, true) != null)
            //  //    {
            //  //        libraryAutomationSign.FindFirstElement(Journal129AndJournal121.DateFinish);
            //  //        var valueControl = new DateTime(2018, 3, 15);
            //  //        libraryAutomationSign.DateControlComboboxNotValue(valueControl);



            //          //  libraryAutomationSign.SetValuePattern("21 марта 2020");
            //          //var pattern = s.GetSupportedPatterns();
            //          // libraryAutomationSign.SetValuePattern("21 марта 2020");
            //          //  
            //          //   var native = t.Current.NativeWindowHandle;
            //          //    DateTimePickerHelper.SetDate((IntPtr)native, date);
            //          //libraryAutomationSign.SelectItemCombobox(libraryAutomationSign.IsEnableElements(Journal129AndJournal121.ComboBoxError), "Выявлены нарушения");
            //          //PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomationSign, Journal129AndJournal121.OkEdit);
            //          //PublicGlobalFunction.PublicGlobalFunction.WindowElementClick(libraryAutomationSign, Journal129AndJournal121.WarningOk);
            //          //AutoItX.Sleep(1000);
            //      //    break;
            //  //    }
            // // }
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
  
    


}
