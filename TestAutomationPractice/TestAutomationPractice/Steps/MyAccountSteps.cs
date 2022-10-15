using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base

    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);
    

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.signIn);
        }
        
        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
           ut.EnterTextInElement(ap.Password, TestConstants.Password);
        }
        
        [When(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()

        {
            AuthenticationPage ap = new AuthenticationPage(Driver);
            ut.ClickOnElement(hp.signIn);
        }
        
        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccountPage mp = new MyAccountPage(Driver);
            Assert.True((bool)ut.ElementIsDisplayed(mp.signOutbtn), "User is not logged in");
        }
    }

    
    }

