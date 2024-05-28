using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp.utility
{
    public class Helper
    {
        public void elementHighlight(IWebDriver driver, IWebElement element)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor) driver;
            js.ExecuteScript("arguments[0].setAttribute('style', 'background: yellow; border: 3px solid blue;');", element);
        }
    }
}
