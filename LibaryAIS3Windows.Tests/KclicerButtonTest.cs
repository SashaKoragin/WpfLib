// <copyright file="KclicerButtonTest.cs">Copyright ©  2018</copyright>

using System;
using LibaryAIS3Windows.ButtonsClikcs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibaryAIS3Windows.AutomationsUI.LibaryAutomations;
using LibaryAIS3Windows.Window;
using LibaryAIS3Windows.AutomationsUI.Otdels.Okp2;
using System.Linq;
using AutoIt;
using System.Windows.Automation;
using System.IO;
using System.Collections.Generic;

namespace LibaryAIS3Windows.Tests
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
                var libraryAutomation = new LibaryAutomations(WindowsAis3.AisNalog3);
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


        [TestMethod]
        public void TestColor()
        {


            //  LibaryAutomations libraryAutomation = new LibaryAutomations(WindowsAis3.AisNalog3);
            //  LibaryAutomations libraryAutomationDoc = new LibaryAutomations(WindowsAis3.AisNalog3);

            //  libraryAutomation.FindFirstElement(Okp2ElementName.NumKabinet);
            //  libraryAutomation.SetValuePattern("366.2");


            //if (libraryAutomation.IsEnableElements(Okp2ElementName.FaceName, null, true) != null)
            //{
            //    libraryAutomation.CliksElements(Okp2ElementName.FaceName, null, true);
            //    libraryAutomation.SelectItemCombobox(libraryAutomation.IsEnableElements(Okp2ElementName.FaceNameSign), "Лобачев А. А.");

            //}

            //if (libraryAutomation.IsEnableElements(Okp2ElementName.WindowDateTime, null, true) != null)
            //{
            //    var dateMemo = libraryAutomation.ParseElementLegacyIAccessiblePatternIdentifiers(libraryAutomation.FindElement);
            //    var dateVAdd = Convert.ToDateTime(dateMemo).AddDays(50);
            //    if (dateVAdd.DayOfWeek == DayOfWeek.Saturday)
            //        dateVAdd = dateVAdd.AddDays(2);
            //    if (dateVAdd.DayOfWeek == DayOfWeek.Sunday)
            //        dateVAdd = dateVAdd.AddDays(1);
            //    libraryAutomation.SetValuePattern(dateVAdd.ToString("dd.MM.yy"));
            //    libraryAutomation.FindFirstElement(Okp2ElementName.WindowHours);
            //    libraryAutomation.SetValuePattern("10");
            //    libraryAutomation.FindFirstElement(Okp2ElementName.WindowsOk);
            //    libraryAutomation.InvekePattern(libraryAutomation.FindElement);

            //}

            //libraryAutomation.CliksElements(Okp2ElementName.ButtonSved);
            //var patern = control.GetSupportedPatterns();
            //libraryAutomation.CliksElements(Okp2ElementName.UpdateData);
            //libraryAutomation.IsEnableElements(Okp2ElementName.AllTaxJournal + Okp2ElementName.ElementJournal, null, false, 50);
            //var listMemo = libraryAutomation.SelectAutomationColrction(libraryAutomation.FindFirstElement(Okp2ElementName.AllTaxJournal)).Cast<AutomationElement>().Distinct().Where(elem => elem.Current.Name.Contains("select0 row"));


            //foreach (var automationElement in listMemo)
            //{
            //   automationElement.SetFocus();
            //       var IdDelo = Convert.ToInt32(libraryAutomation.ParseElementLegacyIAccessiblePatternIdentifiers(libraryAutomation.SelectAutomationColrction(automationElement).Cast<AutomationElement>().First(elem => elem.Current.Name.Contains("ун дела"))));
            //       var Status = libraryAutomation.SelectAutomationColrction(automationElement).Cast<AutomationElement>().Where(automationElemenst=>automationElemenst.Current.Name!= "Column Headers").First(elem => elem.Current.Name.Contains(""));
            //       var clickablePoint = Status.GetClickablePoint();
            //       var hexpixel = AutoIt.AutoItX.PixelGetColor((int)clickablePoint.X, (int)clickablePoint.Y);
            //       var color = Convert.ToString(hexpixel, 16);
            //    //var listDocMemo = libraryAutomationDoc.SelectAutomationColrction(libraryAutomationDoc.FindFirstElement(Okp2ElementName.DocAllJournal)).Cast<AutomationElement>().Distinct().Where(elem => elem.Current.Name.Contains("select0 row"));

            //    //var isAct = listDocMemo.Where(doc => libraryAutomationDoc.ParseElementLegacyIAccessiblePatternIdentifiers(libraryAutomationDoc.SelectAutomationColrction(doc).Cast<AutomationElement>().First(elem => elem.Current.Name.Contains("КНД"))) == "1160100" &&
            //    //libraryAutomationDoc.GetColorPixel(libraryAutomationDoc.SelectAutomationColrction(doc).Cast<AutomationElement>().Where(automationElemenst => automationElemenst.Current.Name != "Column Headers").First(elem => elem.Current.Name.Contains(""))) == "ffff00"
            //    //).FirstOrDefault();
            //    //var isIzvesh = listDocMemo.Where(doc => libraryAutomationDoc.ParseElementLegacyIAccessiblePatternIdentifiers(libraryAutomationDoc.SelectAutomationColrction(doc).Cast<AutomationElement>().First(elem => elem.Current.Name.Contains("КНД"))) == "1165213"
            //    //).FirstOrDefault();
            //    //if(isAct !=null || isIzvesh == null)
            //    //{

            //    //}
            //}
        }

        public class GetFile
        {
            public string namePath { get; set; }
            public DateTime DateWrite { get; set; }
        }
    }
}
