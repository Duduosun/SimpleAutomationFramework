using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustGiving.Tests;

namespace JustGiving.TDD
{
    [TestClass]
    public class ExerciseThreeTDD : JustGivingTestLogic
    {
        [TestInitialize]
        public void TestSetup()
        {
            SelectBrowser("Chrome");
            GoToJustGivingQA();
        }

        [TestMethod]
        [Priority(2)]
        public void DOMElements()
        {
            GoToLink("Exercise 3");
            VerifyJustGiving();
            VerifyIndexPage();
            GoToLink("Just Giving");
            VerifyJustGiving();
            VerifyResultPage();
        }
    }
}
