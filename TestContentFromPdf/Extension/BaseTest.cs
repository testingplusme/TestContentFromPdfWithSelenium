using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestContentFromPdf.Extension
{
    public class BaseTest : IDisposable
    {
        protected IWebDriver driver;

        protected BaseTest()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("plugins.always_open_pdf_externally", true);
            chromeOptions.AddUserProfilePreference("download.default_directory", TestSettings.PathToDownloads);
            driver = new ChromeDriver(chromeOptions);
        }

        public void Dispose()
        {
            driver.Close();
        }
    }
}