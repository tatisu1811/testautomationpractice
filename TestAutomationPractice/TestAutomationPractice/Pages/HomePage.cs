using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomationPractice.Helpers;

namespace TestAutomationPractice.Pages
{
    class HomePage : Base 
    {
        readonly IWebDriver driver;
        public By homepage = By.Id("index");
        public By contactUs = By.Id("contact-link");
        public By searchfield = By.Id("search_query_top");
        public By searchBtn = By.Name("submit_search");


        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(homepage));
            
        }
    }
}
