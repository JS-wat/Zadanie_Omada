using Exercise.Forms;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;

namespace Exercise
{
    public class CheckChangeLanguageTestCase : IDisposable
    {
        private ChromeDriver driver;
        private Links UrlData()
        {
            return new Links(new Uri("https://www.omada.net/"));
        }

        public CheckChangeLanguageTestCase()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ChangeLanguageOnPage()
        {
            var link = UrlData();
            var homePage = new HomePage(driver, link);

            homePage
                .AcceptCookieReg()
                .IsHomePageLoaded()
                .ChangeToGermanLanguage()
                .AssertsIsLanguageChangeToGerman()
                .ChangeToDanishLanguage()
                .AssertsIsLanguageChangeToDanish()
                .ChangeToEnglishLanguage()
                .IsHomePageLoaded();
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
