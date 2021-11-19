using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppForMathBAsic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForMathBAsic.Tests
{
    [TestClass()]
    public class ApplicationCodeClassTests
    {
        [TestMethod()]
        public void combineArrayStringWithSpaceTest()
        {
            ApplicationCodeClass target = new ApplicationCodeClass();
            string[] strArray = null;
            string expected = string.Empty;
            String actual = target.combineArrayStringWithSpace(strArray);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("verify the correctness of this test method");
        }

        [TestMethod()]
        public void Whitespace_combineArrayStringWithSpaceTest()
        {
            ApplicationCodeClass target = new ApplicationCodeClass();
            string[] actStrArray = new string[] { "I",  " wish", " everyone", " the", "best" } ;
            string expected = "I wish everyone the best";
            string result = target.combineArrayStringWithSpace(actStrArray);
            Assert.AreEqual<string>(expected, result);
        }

        [TestMethod()]
        public void Positive_Scenario_combineArrayStringWithSpaceTest()
        {
            ApplicationCodeClass target = new ApplicationCodeClass();
            string[] actStrArray = new string[] { "I", "wish", "everyone", "the", "best" };
            string expected = "I wish everyone the best";
            string result = target.combineArrayStringWithSpace(actStrArray);
            Assert.AreEqual<string>(expected, result);

        }
    }
}