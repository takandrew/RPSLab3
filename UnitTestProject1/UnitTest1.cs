using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPSLab3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestYInt()
        { 
            double x; 
            double xExpected = 1.5;
            double y = 3; double aCoefficient = 5;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x,1), xExpected);
        }

        [TestMethod]
        public void TestYDouble()
        {
            double x;
            double xExpected = 1.4273;
            double y = 3.05; double aCoefficient = 5;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 4), xExpected);
        }

        [TestMethod]
        public void TestYBig()
        {
            double x;
            double xExpected = 4;
            double y = 184; double aCoefficient = 200;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 0), xExpected);
        }

        [TestMethod]
        public void TestYSmall()
        {
            double x;
            double xExpected = 4.2983;
            double y = 0.01; double aCoefficient = 1;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 4), xExpected);
        }

        [TestMethod]
        public void TestASmall()
        {
            double x;
            double xExpected = 0.009;
            double y = 0.01; double aCoefficient = 0.02;
            x = RPSLab3.Tractrix.TractrixBuild(y, aCoefficient);
            Assert.AreEqual(Math.Round(x, 3), xExpected);
        }
    }
}
