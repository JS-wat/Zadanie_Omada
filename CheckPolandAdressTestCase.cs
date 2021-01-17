using Exercise.Forms;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;

namespace Exercise
{
    public class CheckPolandAdressTestCase : IDisposable
    {
        private ChromeDriver driver;
        private Links UrlData()
        {
            return new Links(new Uri("https://www.omada.net/"));
        }

        public CheckPolandAdressTestCase()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }


        [Test]
        public void CheckPolandAdressInAboutSection()
        {
            
            var link = UrlData();
            var homePage = new HomePage(driver, link);
            var aboutPage = new AboutPage(driver);
            var contactPage = new ContactPage(driver);

            
            homePage
                .AcceptCookieReg()
                .IsHomePageLoaded()
                .GoToAboutPage();
            
            aboutPage
                .IsAboutPageLoaded()
                .GoToContactPage();

            
            contactPage
                .IsContactPageLoaded()
                .PolandInstitutionAdressIsVisible();
        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
