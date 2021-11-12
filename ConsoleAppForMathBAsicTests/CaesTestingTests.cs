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
    public class CaesTestingTests
    {
        ConsoleAppForMathBAsic.CaesTesting caseObj = new ConsoleAppForMathBAsic.CaesTesting();

        [TestMethod()]
        public void performActionTest_IfCase()
        {
            double result = 16.0;
            double math_result = caseObj.performAction(4.0, 12.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void performActionTest_ElseIfCase()
        {
            double result = 3.0;
            double math_result = caseObj.performAction(6.0, 3.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void performActionTest_Else()
        {
            double result = 42.0;
            double math_result = caseObj.performAction(7.0, 6.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase1()
        {
            double result = 0.0;
            double math_result = caseObj.findSum(11);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase3()
        {
            double result = 3.0;
            double math_result = caseObj.findSum(1);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase2()
        {
            double result = 0.0;
            double math_result = caseObj.findSum(-2);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase4()
        {
            double result = 3.0;
            double math_result = caseObj.findSum(2);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase5()
        {
            double math_result = caseObj.findSum(6);
            Assert.IsNotNull(math_result);
        }

        [TestMethod()]
        public void findSumTestCase6()
        {
            double result = 27.1;
            double math_result = caseObj.findSum(9);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod()]
        public void findSumTestCase7()
        {
            double result = 29.1;
            double math_result = caseObj.findSum(10);
            Assert.AreEqual(result, math_result);
        }

        public void findSumTestCase8()
        {
            double result = 0.0;
            double math_result = caseObj.findSum(11);
            Assert.AreEqual(result, math_result);
        }
    }
}