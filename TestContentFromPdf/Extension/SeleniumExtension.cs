using System.IO;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using OpenQA.Selenium;

namespace TestContentFromPdf.Extension
{
    public static class SeleniumExtension
    {
        public static string ReturnTextFromPdf(this IWebDriver driver, string nameFile)
        {
            var pathToFile = $"{TestSettings.PathToDownloads}/{nameFile}.pdf";
            driver.Wait().Until(x => File.Exists(pathToFile));
            var fileInfo = new FileInfo(pathToFile);
            if (fileInfo.Length == 0) return null;
            var result = new StringBuilder();
            using (var reader = new PdfReader(pathToFile))
            {
                for (var page = 1; page <= reader.NumberOfPages; page++)
                {
                    var strategy =
                        new SimpleTextExtractionStrategy();

                    var pageText =
                        PdfTextExtractor.GetTextFromPage(reader, page, strategy);


                    result.Append(pageText);
                }
            }

            return result.ToString();
        }
    }
}