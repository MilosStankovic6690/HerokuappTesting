using HerokuappTesting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class ABTestControlPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement TestControlText => driver.FindElement(By.CssSelector(".example h3"));
        public string ABTestingUrl = "http://the-internet.herokuapp.com/abtest";
    }
}
