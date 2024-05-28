using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumCSharp.utility;
using System;

namespace SeleniumCSharp.pages
{
    public class LoginPage
    {
        IWebDriver driver;
        Helper objHelper;
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement textUsername => driver.FindElement(By.Id("user-name"));
        IWebElement textPassword => driver.FindElement(By.Id("password"));
        IWebElement buttonLogin => driver.FindElement(By.Id("login-button"));
        IWebElement elementBackpack => driver.FindElement(By.Id("item_4_title_link"));
        IWebElement elementAddToCart => driver.FindElement(By.Id("add-to-cart"));

        public void verifyLogin(String username, String password)
        {
            objHelper = new Helper();

            objHelper.elementHighlight(driver, textUsername);
            textUsername.SendKeys(username);
            textUsername.SendKeys(Keys.Tab);

            objHelper.elementHighlight(driver, textPassword);
            textPassword.SendKeys(password);
            textPassword.SendKeys(Keys.Tab);

            objHelper.elementHighlight(driver, buttonLogin);
            buttonLogin.Click();

            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("item_4_title_link")));

            String currentUrl = driver.Url;
            Assert.That("https://www.saucedemo.com/inventory.html", Is.EqualTo(currentUrl));
        }
    }
}
