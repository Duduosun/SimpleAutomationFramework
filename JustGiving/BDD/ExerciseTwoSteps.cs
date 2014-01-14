using JustGiving.Tests;
using System;
using TechTalk.SpecFlow;

namespace JustGiving.BDD
{
    [Binding]
    public class ExerciseTwoSteps : JustGivingHttpClient
    {
        [Given(@"JustGiving API")]
public void GivenJustGivingAPI()
{
    InitializeClient();
}

        [Then(@"I can Parse Response and Output each donation and Calculate Total Sum to the Console")]
public void ThenICanParseResponseAndOutputEachDonationAndCalculateTotalSumToTheConsole()
{
    ParseResponseAndOutput();
}
    }
}
