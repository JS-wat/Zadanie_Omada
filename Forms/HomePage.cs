using OpenQA.Selenium;
using NUnit.Framework;



namespace Exercise.Forms
{
    public class HomePage : BaseForm
    {
        public HomePage(IWebDriver driver, Links url) : base(driver)
        {
            this.driver.Url = url.Url.ToString();
        }

        public HomePage IsHomePageLoaded()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Take back control of IT with automated identity and access governance']")).Displayed, "Home Page not loaded");
            return this;
        }

        public HomePage AcceptCookieReg()
        {
            WaitForClickable(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"), 5);

            var _buttonAcceptConsent = driver.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll"));

            if (_buttonAcceptConsent.Displayed)
            {
                _buttonAcceptConsent.Click();
            }

            return this;
        }

        public AboutPage GoToAboutPage()
        {
            MoveToElement(By.XPath("//a[contains(text(), 'More')]"));
            var _aboutButton = driver.FindElement(By.XPath("/html/body/header/div[2]/div/div[2]/nav/div/ul/li[5]/div/ul/div[5]/div[2]/a"));
            _aboutButton.Click();

            return new AboutPage(driver);
        }

        public HomePage ChangeToGermanLanguage()
        {
            WaitForClickable(By.XPath("//a[text()='DE']"), 5);
            var _buttonChangeToGermanLanguauge = driver.FindElement(By.XPath("//a[text()='DE']"));
            _buttonChangeToGermanLanguauge.Click();
            return this;
        }

        public HomePage AssertsIsLanguageChangeToGerman()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Die eigene IT wieder voll im Griff – mit automatisierter Identity- und Access-Governance']")).Displayed, "Language does not change");
            return this;
        }

        public HomePage ChangeToDanishLanguage()
        {
            WaitForClickable(By.XPath("//a[text()='DK']"), 5);
            var _buttonChangeToDanishLanguauge = driver.FindElement(By.XPath("//a[text()='DK']"));
            _buttonChangeToDanishLanguauge.Click();
            return this;
        }

        public HomePage AssertsIsLanguageChangeToDanish()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//h1[text()='Få kontrol over jeres IT med automatiseret identitets- og adgangsstyring']")).Displayed, "Language does not change");
            return this;
        }

        public HomePage ChangeToEnglishLanguage()
        {
            WaitForClickable(By.XPath("//a[text()='EN']"), 5);
            var _buttonChangeToEnglishLanguauge = driver.FindElement(By.XPath("//a[text()='EN']"));
            _buttonChangeToEnglishLanguauge.Click();
            return this;
        }

        public BookDemoForm GoToBookDemoForm()
        {
            WaitForClickable(By.XPath("//a[text()='Book a Demo']"), 5);
            var _buttonGoToBookDemo = driver.FindElement(By.XPath("//a[text()='Book a Demo']"));
            _buttonGoToBookDemo.Click();
            return new BookDemoForm(driver);
        }

        public CustomersListForm GoToCustomerListForm()
        {
            ScrollToElement(By.XPath("//a[@class = 'clientbar__button button--variant2']"));
            MoveToElement(By.XPath("//a[@class = 'clientbar__button button--variant2']"));
            WaitForClickable(By.XPath("//a[@class = 'clientbar__button button--variant2']"), 5);
            var _customerListButton = driver.FindElement(By.XPath("//a[@class = 'clientbar__button button--variant2']"));
            _customerListButton.Click();
            return new CustomersListForm(driver);
        }
    }
}
