using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGiving.POM
{
    public class JustGivingOM : JustGivingOR
    {
        public IWebDriver webDriver;

        public IWebElement logoJustGiving { get { return webDriver.FindElement(By.XPath(JustGivingLogo)); } }
        public IWebElement footerJustGiving { get { return webDriver.FindElement(By.XPath(JustGivingFooter)); } }

        public IWebElement lnkExerciseOne { get { return webDriver.FindElement(By.LinkText(exerciseOne)); } }
        public IWebElement lnkExerciseTwo { get { return webDriver.FindElement(By.LinkText(exerciseTwo)); } }
        public IWebElement lnkExerciseThree { get { return webDriver.FindElement(By.LinkText(exerciseThree)); } }
        public IWebElement lnkRegister { get { return webDriver.FindElement(By.LinkText(Register)); } }
        public IWebElement lnkAPI { get { return webDriver.FindElement(By.LinkText(callAPI)); } }

        public IWebElement inpUserName { get { return webDriver.FindElement(By.Id(Username)); } }
        public IWebElement inpPassword { get { return webDriver.FindElement(By.Id(Password)); } }
        public IWebElement inpConfirmPassword { get { return webDriver.FindElement(By.Id(ConfirmPassword)); } }

        public IWebElement btnRegister { get { return webDriver.FindElement(By.XPath(RegisterButton)); } }
        public IWebElement ManageUser { get { return webDriver.FindElement(By.XPath(RegisteredUser)); } }
        public IWebElement lnkLogOff { get { return webDriver.FindElement(By.Id(LogOff)); } }
        public IWebElement ManageUserSection { get { return webDriver.FindElement(By.XPath(UserSection)); } }
        public IWebElement DisplayJustGiving { get { return webDriver.FindElement(By.XPath(JustGivingDescribe)); } }
        public IWebElement RowNumberJustGiving { get { return webDriver.FindElement(By.XPath(JustGivingNumber)); } }

        public IWebElement RightPageResult { get { return webDriver.FindElement(By.Id(Result)); } }
        public IWebElement RowNumber { get { return webDriver.FindElement(By.LinkText(RowNumberJustGiving.Text.Substring(0, 1))); } }
    }
}