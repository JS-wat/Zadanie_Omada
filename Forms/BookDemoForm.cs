using NUnit.Framework;
using OpenQA.Selenium;

namespace Exercise.Forms
{
    public class BookDemoForm : BaseForm
    {
        public BookDemoForm(IWebDriver driver) : base(driver)
        {

        }

        

        public BookDemoForm IsBookDemoFormLoaded()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//p[text()='Omada Identity Live Demo']")).Displayed, "Book Demo Form does not loaded");
            return this;
        }

        public BookDemoForm FillBookingDemoQuestionnaire(BookDemoData bookDemoData)
        {
            driver.SwitchTo().Frame(0);
            
            var _firstName = driver.FindElement(By.XPath("//p[contains(@class, 'first_name')]/input"));
            _firstName.SendKeys(bookDemoData.FirstName);

            var _lastName = driver.FindElement(By.XPath("//p[contains(@class, 'last_name')]/input"));
            _lastName.SendKeys(bookDemoData.LastName);

            var _company = driver.FindElement(By.XPath("//p[contains(@class, 'company')]/input"));
            _company.SendKeys(bookDemoData.Company);

            var _jobTitle = driver.FindElement(By.XPath("//p[contains(@class, 'job_title')]/input"));
            _jobTitle.SendKeys(bookDemoData.JobTitle);

            var _bussinesEmail = driver.FindElement(By.XPath("//p[contains(@class, 'email')]/input"));
            _bussinesEmail.SendKeys(bookDemoData.BusinessEmail);

            var _phone = driver.FindElement(By.XPath("//p[contains(@class, 'phone')]/input"));
            _phone.SendKeys(bookDemoData.Phone);

            var _country = driver.FindElement(By.XPath("//p[contains(@class, 'country')]/select"));
            _country.Click();
            _country.SendKeys(bookDemoData.Country);
            _country.SendKeys(Keys.Enter);

            var _numOfEmpl = driver.FindElement(By.XPath("//p[contains(@class, 'sf_Number_of_Employees')]/select"));
            _numOfEmpl.Click();
            _numOfEmpl.SendKeys(bookDemoData.NumOfEmpl);
            _numOfEmpl.SendKeys(Keys.Enter);

            
            return this;
        }
    }
}
