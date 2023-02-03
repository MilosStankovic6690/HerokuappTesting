using HerokuappTesting.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class ContexMenuPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public IWebElement HotSpot => driver.FindElement(By.Id("hot-spot"));
        public void RightClick()
        {
            var action = new Actions(driver);
            action.ContextClick(HotSpot).Perform();
        }
        public void Alert()
        {
            driver.SwitchTo().Alert().Accept();
        }
    }
}
