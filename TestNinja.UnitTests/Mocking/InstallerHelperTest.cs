using Moq;
using NUnit.Framework;
using System.Net;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class InstallerHelperTest
    {
        private Mock<IFileDownloader>  _fileDowloader;
        private InstallerHelper _installerHelper;

        [SetUp]
        public void SetUp()
        {
            _fileDowloader = new Mock<IFileDownloader>();
            _installerHelper = new InstallerHelper(_fileDowloader.Object);
        }

        [Test]
        public void DowloadInstaller_DownloadFails_ReturnFalse()
        {
            _fileDowloader.Setup(fd => 
                fd.DownloadFile(It.IsAny<string>(), It.IsAny<string>()))
             .Throws<WebException>();

            var result = _installerHelper.DownloadInstaller("customer","installer");

            Assert.That(result, Is.False);
        }

        [Test]
        public void DowloadInstaller_DownloadComplete_ReturnTrue()
        {
            var result = _installerHelper.DownloadInstaller("customer", "installer");

            Assert.That(result, Is.True);
        }

    }
}
