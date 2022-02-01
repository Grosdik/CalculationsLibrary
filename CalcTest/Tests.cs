using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculationsLibrary;

namespace CalcTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void CheckingСalculation()
        {
            double S = 200000;
            double N = 24;
            double trueAnswer = 9414.69;

            double action = Calculations.CalculatingTheCredits(S, N);

            Assert.AreEqual(trueAnswer, action);
        }
    }
}


