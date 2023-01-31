using HerokuappTesting.Driver;
using HerokuappTesting.Pages;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace HerokuappTesting
{
    public class Tests
    {
        private HomePage _homePage;
        private ABTestControlPage _abTestControlPage;
        private AddRemoveElementsPage _addRemoveElementsPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _homePage = new HomePage();
            _abTestControlPage= new ABTestControlPage();
            _addRemoveElementsPage= new AddRemoveElementsPage();
        }

        [TearDown]
        public void AfterScenario()
        {
            WebDrivers.Shutdown();
        }

        [Test]
        public void TC01_GoToTheABTestControlPage_PageShouldDisplayed()
        {
            _homePage.ABTesting.Click();
            Assert.That(_abTestControlPage.ABTestingUrl, Is.EqualTo(WebDrivers.Instance.Url));
        }

        [Test]
        public void TC02_GoToTheABTestControlPage_PageShouldDisplayed()
        {
            _homePage.AddRemoveElements.Click();
            _addRemoveElementsPage.AddElementButton.Click();
            _addRemoveElementsPage.DeleteButton.Click();
            Assert.IsTrue(_addRemoveElementsPage.DeleteButton, Is.False);
           
        }


    }
}