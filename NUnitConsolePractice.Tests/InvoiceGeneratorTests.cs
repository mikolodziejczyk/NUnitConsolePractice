using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitConsolePractice.Tests
{
    [TestFixture]
    public class InvoiceGeneratorTests
    {
        [Test]
        [TestCase("ABC","ABC/123")]
        [TestCase("C", "C/123")]
        public void GenerateInvoice_SpecifiedInput_ExpectedResult(string series, string expected)
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            string actual = invoiceGenerator.GenerateInvoice(series);
            Assert.AreEqual(expected, actual);
        }
    }
}
