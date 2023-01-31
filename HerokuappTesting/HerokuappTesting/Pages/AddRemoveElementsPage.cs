using HerokuappTesting.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V107.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class AddRemoveElementsPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement AddElementButton => driver.FindElement(By.CssSelector(".example button"));
        public IWebElement DeleteButton => driver.FindElement(By.CssSelector("#elements .added-manually"));
    }
}
