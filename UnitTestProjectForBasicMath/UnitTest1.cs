using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleAppForMathBAsic;

namespace ConsoleAppForMathBAsic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Add()
        {
            ConsoleAppForMathBAsic.Math unitTest = new ConsoleAppForMathBAsic.Math();
            double result = 10.0;
            double math_result = unitTest.Add(5.0 , 5.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod]
        public void Test_Sub()
        {
            ConsoleAppForMathBAsic.Math unitTest = new ConsoleAppForMathBAsic.Math();
            double result = 10.0;
            double math_result = unitTest.subtract(20.0, 10.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod]
        public void Test_Mul()
        {
            ConsoleAppForMathBAsic.Math unitTest = new ConsoleAppForMathBAsic.Math();
            double result = 10.0;
            double math_result = unitTest.multiply(5.0, 2.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod]
        public void Test_Div()
        {
            ConsoleAppForMathBAsic.Math unitTest = new ConsoleAppForMathBAsic.Math();
            double result = 10.0;
            double math_result = unitTest.devide(50.0, 5.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod]
        public void Test_Div_Exc_Case()
        {
            ConsoleAppForMathBAsic.Math unitTest = new ConsoleAppForMathBAsic.Math();
            Assert.ThrowsException<System.ArgumentException>(() => unitTest.devide(10.0 , 0));
        }

        [TestMethod]
        public void Test_Child_Add()
        {
            ConsoleAppForMathBAsic.ChildMath unitTest = new ConsoleAppForMathBAsic.ChildMath();
            double result = 20.0;
            double math_result = unitTest.Add(5.0, 5.0);
            Assert.AreEqual(result, math_result);
        }

        [TestMethod]
        public void Test_PerformSomething_IfCase()
        {
            ConsoleAppForMathBAsic.ChildMath unitTest = new ConsoleAppForMathBAsic.ChildMath();
            double result = 20.0;
            double math_result = unitTest.Add(5.0, 5.0);
            Assert.AreEqual(result, math_result);
        }

    }
}
