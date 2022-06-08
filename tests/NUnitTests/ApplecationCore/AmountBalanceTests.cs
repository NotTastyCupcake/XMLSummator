using Metcom.XMLSummator.ApplicationCore.Entities;
using Metcom.XMLSummator.ApplicationCore.Entities.BalanceModel;
using Metcom.XMLSummator.ApplicationCore.Extensions;
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NUnitTests.ApplecationCore
{
    public class AmountBalanceTests
    {
        private IAmountBalances _service;
        [SetUp]
        public void Setup()
        {
            _service = new AmountBalance();
        }

        [Test]
        public void ShouldReturnAmountReport()
        {
            // Arrange

            // Act

            // Assert
            Assert.That(true);
        }

    }
}
