﻿using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Helpers
{
    public class Utilities
    {
        readonly IWebDriver driver;
        private static readonly Random RandomName = new Random();

        public Utilities(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string GenerateRandomEmail()
        {
            return string.Format("email{0}@malinator.com", RandomName.Next(10000, 1000000));
        }

        internal static void ClickOnElement(object signin)
        {
            throw new NotImplementedException();
        }

        public void ClickOnElement(By locator)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator)).Click();
        }

        internal void EnterTextInElement(By username)
        {
            throw new NotImplementedException();
        }

        public void DropDownSelect(By select, string option)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(select));
            var dropdown = driver.FindElement(select);
            var SelectElement = new SelectElement(dropdown);
            SelectElement.SelectByText(option);
        }
        internal object ElementIsDisplayed(By signOutbtn)
        {
            throw new NotImplementedException();
        }
        internal object ReturnTextFromElementText(object searchResult)
        {
            throw new NotImplementedException();
        }

        public void EnterTextInElement(By locator, string text)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

        public string ReturnTextFromElement(By locator)
        {

            return driver.FindElement(locator).GetAttribute("textContent");
        }

        public bool ElementExists(By locator)

        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(locator)).Displayed;
        }
        public bool TextPresentInElement(string text)
        {
            By textElement = By.XPath("//*[contains(text(),'" + text + "')]");
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(textElement)).Displayed;
        }

        public IList<IWebElement> ReturnCategoryList(string catName)
        {
            By catOption = By.CssSelector(".sf-menu [title='" + catName + "']");
            IList<IWebElement> category = driver.FindElements(catOption);
            return category;
        }
    }
}