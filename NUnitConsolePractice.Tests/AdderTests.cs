using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitConsolePractice.Tests
{
    [TestFixture]
    public class AdderTests
    {
        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 5, 8)]
        public void Add_SpecifiedInput_ExpectedOutput(int a, int b, int expected)
        {
            Adder adder = new Adder();
            int actual = adder.Add(a, b);
            Assert.AreEqual(expected, actual);
        }
    }
}
