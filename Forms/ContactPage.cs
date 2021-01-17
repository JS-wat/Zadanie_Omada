using NUnit.Framework;
using OpenQA.Selenium;

namespace Exercise.Forms
{
    public class ContactPage : BaseForm
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {

        }

        public ContactPage IsContactPageLoaded()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Contact Omada']")).Displayed, "Contact Omada Page not loaded");
            return this;
        }

        public ContactPage PolandInstitutionAdressIsVisible()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//p[text()='Omada | Postępu 17A | 02-676 Warszawa']")).Displayed, "Poland Institution Adress does not exist on Contact Page");
            return this;
        }
    }
}
