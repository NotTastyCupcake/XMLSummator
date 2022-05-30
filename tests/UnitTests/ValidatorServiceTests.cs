using Metcom.XMLSummator.ApplicationCore.Services;
using NUnit.Framework;

namespace Tests
{
    public class ValidatorServiceTests
    {
        #region IsValidNameFile
        [TestCase("")]
        public void IsValidNameFile_ShouldReturnTrue(string fileName)
        {
            // Arrange
            var validator = new ValidatorFileService();

            // Act

            // Assert
            Assert.Pass();
        }

        [TestCase()]
        public void IsValidNameFile_ShouldReturnFalse(string fileName)
        {
            // Arrange
            var validator = new ValidatorFileService();

            // Act

            // Assert
            Assert.Pass();
        }
        #endregion
    }
}