using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SeleniumCSharp.cucumber_example.StepDefinitions
{
    internal class LoginStepsDefinition
    {
        [Binding]
        public class LoginSteps
        {
            private IWebDriver _driver;

            [Given(@"I navigate to the login page")]
            public void GivenINavigateToTheLoginPage()
            {
                _driver = new ChromeDriver();
                _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            }

            [When(@"I enter valid credentials")]
            public void WhenIEnterValidCredentials()
            {
                var usernameField = _driver.FindElement(By.Id("user-name"));
                var passwordField = _driver.FindElement(By.Id("password"));
                var loginButton = _driver.FindElement(By.Id("login-button"));

                usernameField.SendKeys("standard_user");
                passwordField.SendKeys("secret_sauce");
                loginButton.Click();
            }

            [Then(@"I should be logged in")]
            public void ThenIShouldBeLoggedIn()
            {
                var logoutButton = _driver.FindElement(By.Id("logoutButton"));
                //Assert.IsNotNull(logoutButton);

                // Cleanup
                _driver.Quit();
            }
        }
    }
}
