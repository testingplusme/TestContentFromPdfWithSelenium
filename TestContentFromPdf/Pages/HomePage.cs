using System.Linq;
using OpenQA.Selenium;

namespace TestContentFromPdf.Pages
{
    public class HomePage
    {
        public By FirstAvailableLinkToDocument => By.CssSelector("td a:nth-child(4)");
        
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
    

        public void DownloadPdf()
        {
            driver.Navigate().GoToUrl("https://choosemyplate-prod.azureedge.net/make-small-changes-0");
            driver.FindElements(FirstAvailableLinkToDocument).FirstOrDefault()?.Click();
        }
    }
}