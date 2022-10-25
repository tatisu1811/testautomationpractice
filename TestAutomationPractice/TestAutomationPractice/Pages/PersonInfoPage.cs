using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class PersonInfoPage
    {
        readonly IWebDriver driver;
        public By personInfoPage = By.Id("identity");
        public By Lastname = By.Id("lastname");
        public By CurrentPswd = By.Id("old_passwd");
        public By myNameBTn = By.ClassName("account");
        public By SaveBtn = By.CssSelector("[name=submitIdentity]");






        public PersonInfoPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(personInfoPage));

        }

    }
}