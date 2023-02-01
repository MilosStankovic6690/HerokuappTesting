using HerokuappTesting.Driver;
using Microsoft.CodeAnalysis;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HerokuappTesting.Pages
{
    public class BrokenImagePage
    {
        IWebDriver driver = WebDrivers.Instance;
        

        public IWebElement Image1 => driver.FindElement(By.CssSelector("div[class='example'] img[src='asdf.jpg']"));
        public IWebElement Image2 => driver.FindElement(By.CssSelector("div[class='example'] img[src='hjkl.jpg']"));
        public IWebElement Image3 => driver.FindElement(By.CssSelector("div[class='example'] img[src='img/avatar-blank.jpg']"));
        
        public void ImageTest()
        {
            if (Image1 == Image3)
            {
                Assert.That(Image1.Displayed);
            }
            else 
            {
                Assert.That(Image1, Is.Empty);
            }

            

        }

    }
}
