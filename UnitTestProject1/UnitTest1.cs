using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestYInt() //Тест с целым значением Y
        { 
            double x; 
            double xExpected = 1.5;
            double y = 3; double aCoefficient = 5;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x,1), xExpected);
        }

        [TestMethod]
        public void TestYDouble() //Тест с дробным значением Y
        {
            double x;
            double xExpected = 1.4273;
            double y = 3.05; double aCoefficient = 5;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 4), xExpected);
        }

        [TestMethod]
        public void TestYBig() //Тест с большим значением Y
        {
            double x;
            double xExpected = 4;
            double y = 184; double aCoefficient = 200;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 0), xExpected);
        }

        [TestMethod]
        public void TestYSmall() //Тест с маленьким значением Y
        {
            double x;
            double xExpected = 4.2983;
            double y = 0.01; double aCoefficient = 1;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 4), xExpected);
        }

        [TestMethod]
        public void TestASmall() //Тест при минимальном значении коэффициента а
        {
            double x;
            double xExpected = 0.009;
            double y = 0.01; double aCoefficient = 0.02;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 3), xExpected);
        }
    }
}
