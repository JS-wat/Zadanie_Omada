using NUnit.Framework;
using OpenQA.Selenium;

namespace Exercise.Forms
{
    public class CustomersListForm : BaseForm
    {
        public CustomersListForm(IWebDriver driver) : base(driver)
        {

        }

        public CustomersListForm IsCustomersListFormLoaded()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Selected Omada Customers']")).Displayed, "Customers List Form not loaded");

            return this;
        }

        public CustomersListForm AssertsIsBayerIsCustomerAndGoToTheirPage()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Bayer']")).Displayed, "Bayer does not exist on the list");

            MoveToElement(By.XPath("//a[text()='Bayer']"));
            WaitForClickable(By.XPath("//a[text()='Bayer']"), 5);

            driver.FindElement(By.XPath("//a[text()='Bayer']")).Click();

            return this;
        }
    }
}
