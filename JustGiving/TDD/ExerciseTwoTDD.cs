using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JustGiving.Tests;

namespace JustGiving.TDD
{
    [TestClass]
    public class ExerciseTwoTDD : JustGivingHttpClient
    {
        [TestInitialize]
        public void CallAPI()
        {
            InitializeClient();
        }

        [TestMethod]
        [Priority(3)]
        public void GetAPI()
        {           
            ParseResponseAndOutput();
        }
    }
}
