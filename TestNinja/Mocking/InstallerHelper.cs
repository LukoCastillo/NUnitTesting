using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private readonly IFileDownloader _fileDownloader;
        public InstallerHelper(IFileDownloader fileDownloader)
        {
            _fileDownloader = fileDownloader;
        }
        private string _setupDestinationFile;

        public bool DownloadInstaller(string customerName, string installerName)
        {
            try
            {
                var url = string.Format("http://example.com/{0}/{1}", customerName, installerName);
                _fileDownloader.DownloadFile(url, _setupDestinationFile);
                return true;
            }
            catch (WebException)
            {
                return false;
            }
        }
    }
}