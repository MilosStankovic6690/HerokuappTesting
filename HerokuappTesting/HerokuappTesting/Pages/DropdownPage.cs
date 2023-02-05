using HerokuappTesting.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class DropdownPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement DropdownList => driver.FindElement(By.CssSelector(".example #dropdown"));
        public void SelectOption(string text)
        {
            SelectElement element = new SelectElement(DropdownList);
            element.SelectByValue(text);
        }
    }
}
