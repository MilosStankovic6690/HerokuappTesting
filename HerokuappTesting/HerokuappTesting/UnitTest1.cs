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
        private BasicAuthPage _basicAuthPage;
        private BrokenImagePage _brokenImagePage;
        private ChallengingDOMPage _challengingDOMPage;
        private CheckboxesPage _checkboxesPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            _homePage = new HomePage();
            _abTestControlPage = new ABTestControlPage();
            _addRemoveElementsPage = new AddRemoveElementsPage();
            _basicAuthPage = new BasicAuthPage();
            _brokenImagePage = new BrokenImagePage();
            _challengingDOMPage = new ChallengingDOMPage();
            _checkboxesPage = new CheckboxesPage();
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
        public void TC02_AddAndDeleteElement_ElementShouldBeDeleted()
        {
            _homePage.AddRemoveElements.Click();
            _addRemoveElementsPage.AddElementButton.Click();
            _addRemoveElementsPage.DeleteButton.Click(); 
        }
         

        [Test]
        public void TC03_FillUsernameAndPasswordWithValidData_ShouldPageBeDisplayed()
        {
            _homePage.BasicAuth.Click();
            _basicAuthPage.AlertPopUpLogin("admin", "admin");
            Assert.That(_basicAuthPage.SuccessfulLoginText, Is.EqualTo(_basicAuthPage.SuccessfulLoginContent.Text));
        }

        [Test]
        public void TC04_ClickOnTheImage_TheImageShouldBeBroken()
        {
            _homePage.BrokenImage.Click();
            Assert.That(_brokenImagePage.Image1.Enabled, Is.True);
        }

        [Test]
        public void TC05_FindElement_LocatorShouldBeFound()
        {
            _homePage.ChallengingDOM.Click();
            Assert.That(_challengingDOMPage.Definiebas8.Displayed, Is.True);
        }

        [Test]
        public void TC06_SelectCheckbox_CheckboxShouldBeSelected()
        {
            _homePage.Checkboxes.Click();
            _checkboxesPage.Checkbox1.Click();
            _checkboxesPage.Checkbox2.Click();
            Assert.That(_checkboxesPage.Checkbox1.Selected);

        }

    }
}