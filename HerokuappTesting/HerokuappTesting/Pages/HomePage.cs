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
        public IWebElement ChallengingDOM => driver.FindElement(By.LinkText("Challenging DOM"));
        public IWebElement Checkboxes => driver.FindElement(By.LinkText("Checkboxes"));
        public IWebElement ContexMenu => driver.FindElement(By.LinkText("Context Menu"));
        public IWebElement DigestAuthentication => driver.FindElement(By.LinkText("Digest Authentication"));
        public IWebElement DisappearingElements => driver.FindElement(By.LinkText("Disappearing Elements"));
        public IWebElement DragAndDrop => driver.FindElement(By.LinkText("Drag and Drop"));
        public IWebElement DropDown => driver.FindElement(By.LinkText("Dropdown"));


    }
}
