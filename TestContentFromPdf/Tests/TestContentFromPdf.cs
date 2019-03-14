using Shouldly;
using TestContentFromPdf.Extension;
using TestContentFromPdf.Pages;
using Xunit;

namespace TestContentFromPdf.Tests
{
    public class TestContentFromPdf : BaseTest
    {
        [Fact]
        public void GoToSiteWithMakeSmallChangesPdf_WhenIDownloadIt_CheckContainingOfDefineTextInPdf()
        {
            var homePage = new HomePage(driver);
            homePage.DownloadPdf();
            var returnTextFromPdf = driver.ReturnTextFromPdf("MPMW_Tipsheet_7_navigatethebuffet_0").Replace("\n", "");
            var text =
                "Take a lap around the buffet before you start to fill up your plate. Plan ahead so you know what to choose and what to limit.";
            returnTextFromPdf.Contains(text).ShouldBeTrue();
        }
    }
}