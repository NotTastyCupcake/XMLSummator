
using Metcom.XMLSummator.ApplicationCore.Interfaces;
using Metcom.XMLSummator.ApplicationCore.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTests.ApplecationCore
{
    public class FileWorkerServiceTests
    {
        private IFileWorkerService _service;
        [SetUp]
        public void Setup()
        {
            _service = new FileWorkerService();
        }

        [TestCase()]
        public void ShouldReturnCorrentXml()
        {
            // Arrenge
            // Act
            // Assert 
        }

    }
}
