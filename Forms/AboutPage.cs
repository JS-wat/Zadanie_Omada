using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Forms
{
    public class AboutPage : BaseForm
    {
        public AboutPage(IWebDriver driver) : base(driver)
        {

        }

        public AboutPage IsAboutPageLoaded()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='About Omada']")).Displayed, "About Omada Page not loaded");
            return this;
        }
        public ContactPage GoToContactPage()
        {
            MoveToElement(By.XPath("//a[contains(text(), 'Contact Omada')]"));
            WaitForClickable(By.XPath("//a[contains(text(), 'Contact Omada')]"), 5);
            
            var _goToContactPageButton = driver.FindElement(By.XPath("//a[contains(text(), 'Contact Omada')]"));
            _goToContactPageButton.Click();
            
            return new ContactPage(driver);
        }
    }
}
