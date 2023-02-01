using HerokuappTesting.Driver;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using OpenQA.Selenium.DevTools.V107.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace HerokuappTesting.Pages
{
    public class BasicAuthPage
    {
        IWebDriver driver = WebDrivers.Instance;

        public void AlertPopUpLogin(string uname, string pass)
        {
            string URL = "http://" + uname + ":" + pass + "@the-internet.herokuapp.com/basic_auth";
            driver.Url= URL;
        }
        public IWebElement SuccessfulLoginContent => driver.FindElement(By.XPath("/html/body/div[2]/div/div/p"));
        public string SuccessfulLoginText = "Congratulations! You must have the proper credentials.";

    }
}
