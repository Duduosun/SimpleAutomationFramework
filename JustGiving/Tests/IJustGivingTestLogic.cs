using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustGiving.Tests
{
    interface IJustGivingTestLogic
    {
        void SelectBrowser(string Browser);
        void GoToJustGivingQA();
        void VerifyRegisterPage();
        void RegisterNewAccount(string UserName, string Password);
        void VerifyNewAccount(string NewUser);

        void VerifyIndexPage();
        void VerifyResultPage();

        void VerifyJustGiving();
        void GoToLink(string LinkName);
        void LogOff(string CurrentUser);
    }
}
