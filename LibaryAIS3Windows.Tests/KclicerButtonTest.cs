// <copyright file="KclicerButtonTest.cs">Copyright ©  2018</copyright>
using System;
using LibaryAIS3Windows.ButtonsClikcs;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibaryAIS3Windows.ButtonsClikcs.Tests
{
    /// <summary>Этот класс содержит параметризованные модульные тесты для KclicerButton</summary>
    //[PexClass(typeof(KclicerButton))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    //[PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class KclicerButtonTest
    {
        /// <summary>Тестовая заглушка для Click15(String, String)</summary>
        [TestMethod]
        public void TestMet()
        {
          //  Assert.Fail("hot empl");
            KclicerButton s0 = new KclicerButton();
             s0.Click18("", "");

        }

    }
}
