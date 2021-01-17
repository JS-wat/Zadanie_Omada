using Exercise.Forms;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using System;

namespace Exercise
{
    public class CheckAddDataToBookingDemo : IDisposable
    {
        private FirefoxDriver driver;

        private Links UrlData()
        {
            return new Links(new Uri("https://www.omada.net/"));
        }

        public CheckAddDataToBookingDemo()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        private BookDemoData Data()
        {
            return new BookDemoData("Adam", "Testowy", "Aviva", "IT Recruiter", "adamtestowy@gmail.com", "987654321", "Poland", "0-500");
        }

        [Test]
        public void FillQuestionnaireToBookingDemo()
        {
            var link = UrlData();
            var homePage = new HomePage(driver, link);
            var bookDemoForm = new BookDemoForm(driver);
            var data = Data();

            homePage
                .AcceptCookieReg()
                .IsHomePageLoaded()
                .GoToBookDemoForm();

            bookDemoForm
                .IsBookDemoFormLoaded()
                .FillBookingDemoQuestionnaire(data);

        }

        public void Dispose()
        {
            driver.Quit();
        }

    }
}
