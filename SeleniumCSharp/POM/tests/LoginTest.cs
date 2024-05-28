using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SeleniumCSharp.utility;
using SeleniumCSharp.pages;

namespace SeleniumCSharp.tests
{
    public class LoginTest
    {
        //create the reference for the browser  
        IWebDriver driver;
        WebDriverWait wait;
        LoginPage objLoginpage;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver(); //new FirefoxDriver(); //new EdgeDriver(); 
            //navigate to URL  
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
        }

        //[TestCase("standard_user", "secret_sauce")]
        //[TestCase("locked_out_user", "")]
        //[TestCase("problem_user", "")]
        //[TestCase("performance_glitch_user", "")]
        //[TestCase("error_user", "")]
        //[TestCase("visual_user", "")]
        [Test]
        public void AuthenticateUser()
        {
            try
            {
                objLoginpage = new LoginPage(driver);
                objLoginpage.verifyLogin("standard_user", "secret_sauce");

               /* objCommon = new Helper();

                IWebElement textUsername = driver.FindElement(By.Id("user-name"));
                objCommon.elementHighlight(driver,textUsername);
                textUsername.SendKeys(username);
                textUsername.SendKeys(Keys.Tab);

                IWebElement textPassword = driver.FindElement(By.Id("password"));
                objCommon.elementHighlight(driver, textPassword);
                textPassword.SendKeys(password);
                textPassword.SendKeys(Keys.Tab);

                IWebElement buttonLogin = driver.FindElement(By.Id("login-button"));
                objCommon.elementHighlight(driver, buttonLogin);
                buttonLogin.Click();
                
                //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("item_4_title_link")));

                String currentUrl = driver.Url;
                Assert.That("https://www.saucedemo.com/inventory.html",Is.EqualTo(currentUrl));*/

                createOrder();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
        }

        [Test]
        public void createOrder()
        {
            try {
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("item_4_title_link")));
                IWebElement elementBackpack = driver.FindElement(By.Id("item_4_title_link"));
                elementBackpack.Click();

                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("add-to-cart")));
                IWebElement elementAddToCart = driver.FindElement(By.Id("add-to-cart"));
                elementAddToCart.Click();
            }
            catch (Exception ex) {
                ex.Message.ToString();
            }
        }

        [TearDown]
        public void EndTest()
        {
            //close the browser  
            driver.Close();
        }
    }
}
