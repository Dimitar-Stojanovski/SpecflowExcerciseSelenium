using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using SpecflowExcerciseSelenium.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowExcerciseSelenium.Drivers
{
    [Binding]
    public class DriverFactory
    {
        private IWebDriver? driver;

        public IWebDriver DriverInitiate(BrowserTypes browserTypes)
        {
            return browserTypes switch
            {
                BrowserTypes.Chrome => GetChromeDriver(),
                BrowserTypes.Edge => GetEdgeDriver(),
                BrowserTypes.Firefox => GetFirefoxDriver(),
                _ => throw new Exception("Unsupported browser provided")
            };
        }
        

        private IWebDriver GetChromeDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        private IWebDriver GetFirefoxDriver()
        {
            driver = new FirefoxDriver();
            return driver;
        }

        private IWebDriver GetEdgeDriver()
        {
            driver = new EdgeDriver();
            return driver;
        }
        

        
    }
}
