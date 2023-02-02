using HerokuappTesting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class CheckboxesPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Checkbox1 => driver.FindElement(By.XPath("//*[@id=\"checkboxes\"]/input[1]"));
        public IWebElement Checkbox2 => driver.FindElement(By.XPath("//*[@id=\"checkboxes\"]/input[2]"));

    }
}
