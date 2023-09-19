using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculatrice_Amphi
{
    [TestClass]
    public class TestCalculator
    {

        int valeur1 = 20;
        int valeur2 = 10;

        [TestMethod]
        public void TestAdd()
        {
            Calculator testCalculatrice = new Calculator();

            int resultatAttendu = valeur1 + valeur2;
            int resAddition = testCalculatrice.Add(valeur1, valeur2);

            Assert.AreEqual(resultatAttendu, resAddition);
        }

        [TestMethod]
        public void TestSubtract()
        {
            Calculator testCalculatrice = new Calculator();

            int resultatAttendu = valeur1 - valeur2;
            int resSubstract = testCalculatrice.Subtract(valeur1, valeur2);

            Assert.AreEqual(resultatAttendu, resSubstract);
        }

        [TestMethod]
        public void TestMultiply()
        {
            Calculator testCalculatrice = new Calculator();

            int resultatAttendu = valeur1 * valeur2;
            int resMultiply = testCalculatrice.Multiply(valeur1, valeur2);

            Assert.AreEqual(resultatAttendu, resMultiply);
        }

        [TestMethod]
        public void TestDivide()
        {
            Calculator testCalculatrice = new Calculator();

            int resultatAttendu = valeur1 / valeur2;
            int resDivide = testCalculatrice.Divide(valeur1, valeur2);

            Assert.AreEqual(resultatAttendu, resDivide);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDivideWithZero()
        {
            Calculator testCalculatrice = new Calculator();

            //Assert.ThrowsException<ArgumentException>(() => testCalculatrice.Divide(valeur1, 0));
            int result = testCalculatrice.Divide(valeur2,0);

        }
    }
}
