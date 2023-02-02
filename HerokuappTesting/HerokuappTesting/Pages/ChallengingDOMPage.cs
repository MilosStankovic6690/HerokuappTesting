using HerokuappTesting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class ChallengingDOMPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public IWebElement Definiebas8 => driver.FindElement(By.XPath("//*[@class='large-10 columns']/table/tbody/tr[9]/td[4]"));
        public IWebElement Phaedrum3 => driver.FindElement(By.XPath("//*[@class='large-10 columns']/table/tbody/tr[4]/td[6]"));
    }
}
