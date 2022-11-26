using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ClassLibrary2;

namespace Cal
{
    [TestFixture]
    class Calculatetests
    {
        [TestCase]
        public void When_Add2plus3Number_ThenResult5()
        {   //arrange
            Calculator c = new Calculator();
            //act
            int acutalresult = c.Add(2,3);
            //assert - to test the result
            Assert.AreEqual(5, acutalresult);
        }

        [TestCase]
        public void When_Sub2plus3Number_ThenResult1()
        {   //arrange
            Calculator c = new Calculator();
            //act
            int acutalresult = c.Sub(2, 3);
            //assert - to test the result
            Assert.AreEqual(-1, acutalresult);
        }

        [TestCase]
        public void When_Mul2plus3Number_ThenResult6()
        {   //arrange
            Calculator c = new Calculator();
            //act
            int acutalresult = c.Mul(2, 3);
            //assert - to test the result
            Assert.AreEqual(6, acutalresult);
        }
    }
}
