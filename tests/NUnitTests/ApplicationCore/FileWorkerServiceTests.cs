using Metcom.XMLSummator.ApplicationCore.Services;
using NUnit.Framework;

namespace Metcom.XMLSummator.NUnitTests.ApplicationCore
{
    public class FileWorkerServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase()]
        public void CorrectlySerializesAndDeserializesObject(string path)
        {
            // Arrange
            FileWorkerService fileWorker = new FileWorkerService();
            fileWorker.CreataAmountFiles(path, path);

            // Act

            // Assert

            Assert.Pass();
        }
    }
}