using JustGiving.POM;
using JustGiving.UserDefined;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGiving.Tests
{
    public class JustGivingTestLogic : IJustGivingTestLogic
    {
        JustGivingOM justgivingOM = new JustGivingOM();
        public void SelectBrowser(string Browser)
        {
            if (Browser == "Firefox")
                justgivingOM.webDriver = new FirefoxDriver();
            else if (Browser == "Chrome")
                justgivingOM.webDriver = new ChromeDriver();
            else if (Browser == "IE")
                justgivingOM.webDriver = new InternetExplorerDriver();
        }

        public void GoToJustGivingQA()
        {
            justgivingOM.webDriver.Navigate().GoToUrl(justgivingOM.baseUrl);
            justgivingOM.webDriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            Assert.IsTrue(justgivingOM.webDriver.Title.Equals(justgivingOM.JustGivingQATitle));
        }

        public void VerifyRegisterPage()
        {
            Assert.IsTrue(justgivingOM.webDriver.Title.Equals(justgivingOM.JustGivingRegisterTitle));
            Assert.IsTrue(justgivingOM.inpUserName.Enabled);
            Assert.IsTrue(justgivingOM.inpPassword.Enabled);
            Assert.IsTrue(justgivingOM.inpConfirmPassword.Enabled);
            Assert.IsTrue(justgivingOM.btnRegister.Enabled);
        }
        public void RegisterNewAccount(String UserName, string Password)
        {
            VerifyJustGiving();
            if (justgivingOM.inpUserName.Enabled)
            {
                justgivingOM.inpUserName.SendKeys(UserName);
            }
            if (justgivingOM.inpPassword.Enabled)
            {
                justgivingOM.inpPassword.SendKeys(Password);
            }
            if (justgivingOM.inpConfirmPassword.Enabled)
            {
                justgivingOM.inpConfirmPassword.SendKeys(Password);
            }
            
                justgivingOM.btnRegister.Click();
        }

        public void VerifyNewAccount(string NewUser)
        {
            Assert.IsTrue(justgivingOM.webDriver.Title.Equals(justgivingOM.JustGivingQATitle));
            Assert.IsTrue(justgivingOM.lnkLogOff.Enabled);
            Assert.IsTrue(justgivingOM.ManageUser.Enabled);
            Assert.AreEqual(justgivingOM.ManageUser.Text, NewUser);
        }

        public void VerifyIndexPage()
        {
            Assert.IsTrue(justgivingOM.webDriver.Title.Equals(justgivingOM.JustGivingIndexTitle));
            Assert.IsTrue(justgivingOM.RowNumberJustGiving.Enabled);
            Assert.IsTrue(justgivingOM.DisplayJustGiving.Displayed);
            Assert.AreEqual(justgivingOM.DisplayJustGiving.Text, GlobalFunction.RowJustGivingCheck);
        }

        public void VerifyResultPage()
        {
            Assert.IsTrue(justgivingOM.webDriver.Title.Equals(justgivingOM.JustGivingResultTitle));
            Assert.AreEqual(justgivingOM.RightPageResult.Text, GlobalFunction.RightResultCheck);
        }

        public void VerifyJustGiving()
        {
            Assert.AreEqual(justgivingOM.lnkExerciseOne.Text, "Exercise 1");
            Assert.AreEqual(justgivingOM.lnkExerciseTwo.Text, "Exercise 2");
            Assert.AreEqual(justgivingOM.lnkExerciseThree.Text, "Exercise 3");

            Assert.IsTrue(justgivingOM.lnkExerciseOne.Enabled);
            Assert.IsTrue(justgivingOM.lnkExerciseTwo.Enabled);
            Assert.IsTrue(justgivingOM.lnkExerciseThree.Enabled);

            Assert.IsTrue(justgivingOM.logoJustGiving.Displayed);
            Assert.IsTrue(justgivingOM.footerJustGiving.Displayed);           
        }

        public void GoToLink(string LinkName)
        {
            switch (LinkName)
            {
                case "Exercise 1":
                    if (justgivingOM.lnkExerciseOne.Enabled)
                    {
                        justgivingOM.lnkExerciseOne.Click();
                    }
                    break;
                case "Exercise 2":
                    if (justgivingOM.lnkExerciseTwo.Enabled)
                    {
                        justgivingOM.lnkExerciseTwo.Click();
                    }
                    break;
                case "Exercise 3":
                    if (justgivingOM.lnkExerciseThree.Enabled)
                    {
                        justgivingOM.lnkExerciseThree.Click();
                    }
                    break;
                case "Register":
                    if (justgivingOM.lnkRegister.Enabled)
                    {
                        justgivingOM.lnkRegister.Click();
                    }
                    break;
                case "API":
                    if (justgivingOM.lnkAPI.Enabled)
                    {
                        justgivingOM.lnkAPI.Click();
                    }
                    break;
                default:
                    if (justgivingOM.RowNumber.Enabled)
                    {
                        justgivingOM.RowNumber.Click();
                    }
                    break;
            }
        }

        public void LogOff(string CurrentUser)
        {
            if (justgivingOM.lnkLogOff.Enabled && justgivingOM.ManageUser.Enabled)
            {
                if (justgivingOM.ManageUser.Text.Equals(CurrentUser))
                {
                    justgivingOM.lnkLogOff.Click();
                }
            }
            else 
            {
                return;
            }
        }
    }
}
