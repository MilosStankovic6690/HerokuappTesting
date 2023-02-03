using HerokuappTesting.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace HerokuappTesting.Pages
{
    public class DisappearingElementsPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement AboutButton => driver.FindElement(By.LinkText("About"));
        public IWebElement ContactUsButton => driver.FindElement(By.LinkText("Contact Us"));
        public IWebElement PortfolioButton => driver.FindElement(By.LinkText("Portfolio"));
        public IWebElement GalleryButton => driver.FindElement(By.LinkText("Gallery"));
        public void MouseMove()
        {
            var action = new Actions(driver);
            var moveToElement = action.MoveToElement(AboutButton).MoveToElement(ContactUsButton).MoveToElement(PortfolioButton).MoveToElement(GalleryButton).Build();
            moveToElement.Perform();
        }
        public void WaitElement()
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 1, 30));
            var element = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(GalleryButton));
            element.Click();
           
        }


    }
}
