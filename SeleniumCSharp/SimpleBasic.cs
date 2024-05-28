using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SeleniumCSharp
{
    public class SimpleBasic
    {      

        static void Main(string[] args)
        {
            IWebDriver driver;

            Console.Write("--------------test case started--------------");
            //create the reference for the browser  
            driver = new ChromeDriver();
            // navigate to URL  
            driver.Navigate().GoToUrl("https://www.google.com/");
            Thread.Sleep(2000);

            // identify the Google search text box  
            IWebElement searchTextBox = driver.FindElement(By.Name("q"));
            //enter the value in the google search text box  
            searchTextBox.SendKeys("javatpoint tutorials");
            Thread.Sleep(2000);

            //identify the google search button  
            IWebElement searchButton = driver.FindElement(By.Name("btnK"));
            // click on the Google search button  
            searchButton.Click();
            Thread.Sleep(3000);

            //close the browser  
            driver.Close();
            Console.Write("--------------test case ended--------------");
        }
    }
}
