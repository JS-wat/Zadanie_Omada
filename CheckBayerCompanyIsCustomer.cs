using Exercise.Forms;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;

namespace Exercise
{
    public class CheckBayerCompanyIsCustomer : IDisposable
    {
        private ChromeDriver driver;

        private Links UrlData()
        {
            return new Links(new Uri("https://www.omada.net/"));
        }

        public CheckBayerCompanyIsCustomer()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void AssertsBayerCompanyInCustomersList()
        {
            var link = UrlData();
            var homePage = new HomePage(driver, link);
            var customerListForm = new CustomersListForm(driver);

            homePage
                .AcceptCookieReg()
                .IsHomePageLoaded()
                .GoToCustomerListForm();

            customerListForm
                .IsCustomersListFormLoaded()
                .AssertsIsBayerIsCustomerAndGoToTheirPage();

        }

        public void Dispose()
        {
            driver.Quit();
        }
    }
}
