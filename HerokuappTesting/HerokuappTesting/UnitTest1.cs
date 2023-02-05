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
        private ContexMenuPage _contexMenuPage;
        private DigestAuthenticationPage _digestAuthenticationPage;
        private DisappearingElementsPage _disappearingElementsPage;
        private DragandDropPage _dragandDropPage;

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
            _contexMenuPage = new ContexMenuPage();
            _digestAuthenticationPage = new DigestAuthenticationPage();
            _disappearingElementsPage = new DisappearingElementsPage();
            _dragandDropPage = new DragandDropPage();
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

        [Test]
        public void TC07_SelectCheckbox_CheckboxShouldBeSelected()
        {
            _homePage.ContexMenu.Click();
            _contexMenuPage.RightClick();
            _contexMenuPage.Alert();
            Assert.Pass();
        }

        [Test]
        public void TC08_FillUsernameAndPasswordWithValidData_ShouldPageBeDisplayed()
        {
            _homePage.BasicAuth.Click();
            _basicAuthPage.AlertPopUpLogin("admin", "admin");
            Assert.That(_digestAuthenticationPage.SuccessfulLoginText, Is.EqualTo(_digestAuthenticationPage.SuccessfulLoginContent.Text));
        }

        [Test]
        public void TC09_FindTheDisappearingLocators_ElementsShouldBeFound()
        {
            _homePage.DisappearingElements.Click();
           _disappearingElementsPage.MouseMove();
            Assert.Pass();
        }

        [Test]
        public void TC10_MoveTheBoxToAnother_BoxShouldMove()
        {
            _homePage.DragAndDrop.Click();
            _dragandDropPage.MoveObject();
        }
    }
}