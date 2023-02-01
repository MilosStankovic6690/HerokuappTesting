using HerokuappTesting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class HomePage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement ABTesting => driver.FindElement(By.LinkText("A/B Testing"));
        public IWebElement AddRemoveElements => driver.FindElement(By.LinkText("Add/Remove Elements"));
        public IWebElement BasicAuth => driver.FindElement(By.LinkText("Basic Auth"));
        public IWebElement BrokenImage => driver.FindElement(By.LinkText("Broken Images"));

    }
}
