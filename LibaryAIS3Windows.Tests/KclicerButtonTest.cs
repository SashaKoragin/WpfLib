// <copyright file="KclicerButtonTest.cs">Copyright ©  2018</copyright>

using System;
using LibraryAIS3Windows.ButtonsClikcs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryAIS3Windows.AutomationsUI.LibaryAutomations;
using LibraryAIS3Windows.Window;
using System.Linq;
using AutoIt;
using System.Windows.Automation;
using System.IO;
using System.Collections.Generic;
using LibraryAIS3Windows.ButtonFullFunction.PublicGlobalFunction;
using System.Runtime.InteropServices;
using LibraryAIS3Windows.ButtonFullFunction.Okp2Function;
using Ifns51.ToAis;
using ViewModelLib.ModelTestAutoit.PublicModel.ButtonStartAutomat;
using System.Data.OleDb;
using System.Data;
using LibraryAIS3Windows.AutomationsUI.Otdels.PreCheck;
using LibaryXMLAuto.Converts.ConvettToXml;
using System.Xml;
using LibraryAIS3Windows.AutomationsUI.Otdels.RaschetBud;
using LibraryAIS3Windows.AutomationsUI.Otdels.PublicJournal129And121;
using System.Windows.Forms;
using Ifns51.FromAis;
using LibraryAIS3Windows.ButtonFullFunction.PreCheck;

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
            var listParameter = new List<string>()
            {
                "12121",
                "232323",
                "232323"
            };
            var t = -1 < 0;
            var t2 = 2 < 0;
            var t3 = 0 < 0;
            DateTime dateVAdd = new DateTime(2020, 07, 07);
            var counDay = (int)(dateVAdd - DateTime.Now).TotalDays;
            if (counDay >= 0)
            {
                //Нет просрочки
            }
            else
            {
                //просрочка
            }
            var libraryAutomation = new LibraryAutomations(WindowsAis3.AisNalog3);
            
         //   libraryAutomation.ClickElements();

            //while (true)
            //{
            //    if (libraryAutomation.IsEnableElements(Journal129AndJournal121.ErrorFaceGr11, null, true) != null)
            //    {
            //        PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ErrorFaceGr11);
            //        var cash = decimal.Parse(libraryAutomation.ParseElementLegacyIAccessiblePatternIdentifiers(libraryAutomation.IsEnableElements(Journal129AndJournal121.CashFace)));
            //        if (cash == 1000)
            //        {
            //            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.ErrorFaceGr11);
            //            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.PublicInfo);
            //            libraryAutomation.IsEnableElements(Journal129AndJournal121.DateReshenia, null, true);

            //            libraryAutomation.SetValuePattern(dateVAdd.Date.ToString("dd.MM.yy"));
            //            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.AnyDocumentsGr3);
            //            libraryAutomation.IsEnableElements(Journal129AndJournal121.AnyPastDocumentsGr3, null, true);
            //            libraryAutomation.SetValuePattern(string.Join("\r\n", listParameter));
            //            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.AnyDocumentsGr3);
            //            PublicGlobalFunction.WindowElementClick(libraryAutomation, Journal129AndJournal121.InstallGr6);
            //            var template = libraryAutomation.ParseValuePattern(libraryAutomation.IsEnableElements(Journal129AndJournal121.InstallTextGr6));
            //            libraryAutomation.SetValuePattern(string.Join("\r\n", template, "Что то!!!"));
            //            

            // libraryAutomation.SelectItemCombobox(libraryAutomation.IsEnableElements(Journal129AndJournal121.FaceNameSignGr14), "Лобачев А. А.", 0);
            //        }
            //        else
            //        {
            //            //Не выставляем решения так как Итого {cash}
            //        }
            //        break;
            //    }
            //}
        }

        [TestMethod]
        public void Send()
        {

            var listFile = new List<GetFile>();
            var pdf = Directory.GetFiles("C:/Users/7751-00-450/AppData/Local/Temp/", "*.pdf");
            foreach (var path in pdf)
            {
                Path.GetExtension(path);
                listFile.Add(new GetFile { DateWrite = Directory.GetLastWriteTime(path), namePath = path });
            }
            var list = listFile.Where(file => file.DateWrite == listFile.Max(files => files.DateWrite)).FirstOrDefault();
            byte[] bytes;
            //   FileStream stream = new FileStream(list.namePath, FileMode.Open);
            using (FileStream stream = new FileStream(list.namePath, FileMode.Open))
            {

                bytes = new byte[stream.Length];
                //   taxJournal.Document = bytes;
            }
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
