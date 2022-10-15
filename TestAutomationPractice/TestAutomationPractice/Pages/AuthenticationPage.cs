using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class AuthenticationPage
    {
        readonly IWebDriver driver;
        public By authenticationpage = By.Id("authentication");
        public By username = By.Id("email");
        public By Password = By.Id("password");
     


        public AuthenticationPage(IWebDriver driver)

        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(authenticationpage));

        }
    }
}
