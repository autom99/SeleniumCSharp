using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace SeleniumTests
{
    class PracticeWithCSharp
    {
        //create the reference for the browser  
        IWebDriver driver;
        WebDriverWait wait;

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver(); //new EdgeDriver(); //new ChromeDriver();
            //navigate to URL  
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            //Maximize the browser window  
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [Test(Description = "This is Checking Internet Speed from Google Search.")]
        [Description("This is Checking Internet Speed from Google Search.")]
        [TestCase("TestCase: Check Internet Speed")]
        [Order(1)]
        //[TestCaseSource("TestCaseSource: Check Internet Speed")]
        [Author("Hardik Prajapati")]
        public void CheckInternetSpeedFromGoogle(String searchText)
        {
            try{
                IWebElement searchBar = driver.FindElement(By.XPath("//textarea[@name='q']"));
                //IWebElement searchBar = _driver.FindElement(By.Id("nav-search"));
                searchBar.SendKeys(searchText);
                searchBar.SendKeys(Keys.Enter);

                // Find the element by class name
                IWebElement element = driver.FindElement(By.ClassName("lv7K9c"));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.ClassName("lv7K9c")));
                // Interact with the element, for example, click it
                element.Click();
                Thread.Sleep(5000);
                // Close the driver
                driver.Quit();
            }
            catch(Exception ex){
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