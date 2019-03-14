using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestContentFromPdf.Extension
{
    public static class WaitExtension
    {
        private static WebDriverWait wait;

        public static WebDriverWait Wait(this IWebDriver driver)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            return wait;
        }

        public static void WaitForClickable(this IWebDriver driver, By by)
        {
            driver.Wait().Until(ExpectedConditions.ElementToBeClickable(by));
        }
    }
}