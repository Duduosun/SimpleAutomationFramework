using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustGiving.Tests;
using JustGiving.UserDefined;

namespace JustGiving.TDD
{
    [TestClass]
    public class ExerciseOneTDD : JustGivingTestLogic
    {
        [TestInitialize]
        public void TestSetup()
        {
            SelectBrowser("Chrome");
            GoToJustGivingQA();
        }

        [TestMethod]
        [Priority(0)]
        public void RegisterUserOne()
        {
            GoToLink("Exercise 1");
            VerifyRegisterPage();
            VerifyJustGiving();
            RegisterNewAccount(GlobalFunction.UserOne, GlobalFunction.PasswordOne);
            VerifyNewAccount(GlobalFunction.UserOne);
            VerifyJustGiving();
            LogOff(GlobalFunction.UserOne);
        }

        [TestMethod]
        [Priority(1)]
        public void RegisterUserTwo()
        {
            GoToLink("Exercise 1");
            VerifyRegisterPage();
            VerifyJustGiving();
            RegisterNewAccount(GlobalFunction.UserTwo, GlobalFunction.PasswordTwo);
            VerifyNewAccount(GlobalFunction.UserTwo);
            VerifyJustGiving();
            LogOff(GlobalFunction.UserTwo);
        }
    }
}
