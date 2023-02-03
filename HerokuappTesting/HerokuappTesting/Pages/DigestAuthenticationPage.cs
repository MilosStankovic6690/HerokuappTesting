using HerokuappTesting.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuappTesting.Pages
{
    public class DigestAuthenticationPage
    {
        private IWebDriver driver = Driver.WebDrivers.Instance;

        public void AlertPopUpLogin(string uname, string pass)
        {
            string URL = "http://" + uname + ":" + pass + "@the-internet.herokuapp.com/basic_auth";
            driver.Url = URL;
        }
        public IWebElement SuccessfulLoginContent => driver.FindElement(By.XPath("//*[@id=\"content\"]/div/p"));
        public string SuccessfulLoginText = "Congratulations! You must have the proper credentials.";
    }
}
