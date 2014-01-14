using JustGiving.Tests;
using JustGiving.UserDefined;
using System;
using TechTalk.SpecFlow;

namespace JustGiving
{
    [Binding]
    public class ExerciseOneSteps : JustGivingTestLogic
    {
        [Given(@"JustGiving Recruitment Test Page")]
public void GivenJustGivingRecruitmentTestPage()
{
    SelectBrowser("Chrome");
    GoToJustGivingQA();
    GoToLink("Exercise 1");
    VerifyRegisterPage();
    VerifyJustGiving();
}

        [When(@"I register a new user account")]
public void WhenIRegisterANewUserAccount()
{
    RegisterNewAccount(GlobalFunction.UserOne, GlobalFunction.PasswordOne);
}

        [Then(@"The new user is logged in")]
public void ThenTheNewUserIsLoggedIn()
{
    VerifyJustGiving();
    VerifyNewAccount(GlobalFunction.UserOne);   
}

        [Then(@"I register a second new user account")]
public void ThenIRegisterASecondNewUserAccount()
{
    LogOff(GlobalFunction.UserOne);
    GoToLink("Exercise 1");
    VerifyRegisterPage();
    RegisterNewAccount(GlobalFunction.UserTwo, GlobalFunction.PasswordTwo);
}

        [Then(@"The second new user is logged in")]
public void ThenTheSecondNewUserIsLoggedIn()
{
    VerifyJustGiving();
    VerifyNewAccount(GlobalFunction.UserTwo);
}
    }
}
