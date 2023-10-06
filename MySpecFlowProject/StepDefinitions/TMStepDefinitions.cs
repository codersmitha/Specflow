using SpecFlowProjectTest.Pages;
using SpecFlowProjectTest.Utilities;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SpecFlowProjectTest.StepDefinitions
{
    [Binding]
    public class TMStepDefinitions : CommonDriver
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageobj = new LoginPage();
        HomePage homePageobj = new HomePage();
        TimeMaterialpage timeMaterialpageobj = new TimeMaterialpage();

        [Given(@"User logs into TurnUp Portal")]
        public void GivenUserLogsIntoTurnUpPortal()
        {
            
            //open the chrome browser
            //driver = new ChromeDriver();

            //Login page Object initialisation and definition
            //LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(driver);

            //driver.Manage().Timeouts.ImplicitWait = TimeSpan.FromSeconds(5);

            //Homepage Object initialisation and definition
            //HomePage homePageobj = new HomePage();
           
        }

        [Given(@"User navigates to Time and Material page")]
        public void GivenUserNavigatesToTimeAndMaterialPage()
        {
            homePageobj.GoToTMPage(driver);
        }

        [When(@"User creates a new Time and Material record")]
        public void WhenUserCreatesANewTimeAndMaterialRecord()
        {
            timeMaterialpageobj.CreateNewTimeRecord(driver);
        }

        [Then(@"TurnUp portal should save the new Time and material record")]
        public void ThenTurnUpPortalShouldSaveTheNewTimeAndMaterialRecord()
        {
            throw new PendingStepException();
        }
    }
}
