using JustGiving.Tests;
using System;
using TechTalk.SpecFlow;

namespace JustGiving.BDD
{
    [Binding]
    public class ExerciseThreeSteps : JustGivingTestLogic
    {
        [Given(@"Just Giving Recruitment Test Page")]
public void GivenJustGivingRecruitmentTestPage()
{
    SelectBrowser("Chrome");
    GoToJustGivingQA();
}

        [When(@"I navigate to JustGiving Index")]
public void WhenINavigateToJustGivingIndex()
{
    GoToLink("Exercise 3");
    VerifyJustGiving();
}

        [When(@"Click the row number where row description is JustGiving")]
public void WhenClickTheRowNumberWhereRowDescriptionIsJustGiving()
{
    GoToLink("Just Giving");
}

        [Then(@"The opened page contains the message Well done you opened the right link")]
public void ThenTheOpenedPageContainsTheMessageWellDoneYouOpenedTheRightLink()
{
    VerifyJustGiving();
    VerifyResultPage();
}
    }
}
