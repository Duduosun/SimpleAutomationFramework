using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGiving.POM
{
    public class JustGivingOR
    {
        public string baseUrl = "http://jgautomationrecruitment.apphb.com/";
        public string exerciseOneUrl = "http://jgautomationrecruitment.apphb.com/Account/Register";
        public string exerciseTwoUrl = "http://jgautomationrecruitment.apphb.com/api/exercise2";
        public string exerciseThreeUrl = "http://jgautomationrecruitment.apphb.com/Exercise3";

        public string JustGivingQATitle = "JustGiving QA Automation Recruitment - JustGiving QA";
        public string JustGivingRegisterTitle = "Register - JustGiving QA"; //Exercise 1
        public string JustGivingIndexTitle = "Index - JustGiving QA"; //Exercise 3
        public string JustGivingResultTitle = "Result - JustGiving QA"; //Exercise 3

        //Xpath
        public string JustGivingLogo = "/html/body/header/div/div/a/img";
        public string JustGivingFooter = "/html/body/footer/div/div/p";
        public string RegisterButton = "/html/body/div/section/form/fieldset/input";
        public string RegisteredUser = "/html/body/header/div/div[2]/section/a";


        public string JustGivingDescribe = "/html/body/div/section/table/tbody/tr/td[text()='JustGiving']";
        public string JustGivingNumber = "/html/body/div/section/table/tbody/tr/td[normalize-space(text())='JustGiving']/..";
        
        //Link Strings
        public string exerciseOne = "Exercise 1";
        public string exerciseTwo = "Exercise 2";
        public string exerciseThree = "Exercise 3";
        public string Register = "Register";
        public string callAPI = "API";
        public string Result = "result";
        
        //Id
        public string Username ="UserName";
        public string Password ="Password";
        public string ConfirmPassword ="ConfirmPassword";
        public string LogOff = "logoutForm";
        public string UserSection = "login";
        //public string Register = "registerLink";      
      }
}
