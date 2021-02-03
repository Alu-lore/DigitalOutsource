using DigitalOutsource.framework.pageojects;
using DigitalOutsource.framework.utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace DigitalOutsource.Suite.steps
{
    [Binding]
    public sealed class betways
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public betways(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to betways")]
        public void GivenINavigateToBetways()
        {
            bool succes = false;
            try
            {

                seleniumDriver.Launchbrowser("CHROME");

                Parameters.SetData("URL", "https://www.betway.co.za/");
                webUI.common_page.NaviagteTo();
                Reporter.SetStepPassed("StatusMessage", "Navigate to betways passed");
                Reporter.SetStepPassed("StepStatus", "Pass");
                succes = true;
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Navigate to betways failed");
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

        [Then(@"I presented by home page")]
        public void ThenIPresentedByHomePage()
        {
            bool succes = false;
            try
            {
                succes= webUI.betwayHome_page.Validate_Page();
                Reporter.SetStepPassed("StatusMessage", "Validate home page passed.");
                Reporter.SetStepPassed("StepStatus", "Pass");
        
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Validate home page failed.");
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

        [When(@"I fill the first form page")]
        public void WhenIFillTheFirstFormPage()
        {
            bool succes = false;
            try
            {
                Parameters.SetData("firstname", "lore");
                Parameters.SetData("lastname", "mags");
                Parameters.SetData("email", "lorri@gmail.com");
                Parameters.SetData("mobile", "0601111111111");
                Parameters.SetData("password", "1234sdfsdfsdf");
                Parameters.SetData("idnumber", "9811050782248");
                webUI.betwayHome_page.Click_SignUp2();
                webUI.betwayHome_page.Type_Email();
                webUI.betwayHome_page.Type_FirstName();
                webUI.betwayHome_page.Type_LastName();
                webUI.betwayHome_page.Type_MobileNumber();
                webUI.betwayHome_page.Type_Password();
                Reporter.SetStepPassed("StatusMessage", "Complete first form passed.");
                Reporter.SetStepPassed("StepStatus", "Pass");
                succes = true;
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Complete first form failed:"+e.Message);
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

        [When(@"Click next")]
        public void WhenClickNext()
        {
            bool succes = false;
            try
            {
                webUI.betwayHome_page.Click_Next();
                Reporter.SetStepPassed("StatusMessage", "Click next button passed.");
                Reporter.SetStepPassed("StepStatus", "Pass");
                succes = true;
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Complete first form failed:" + e.Message);
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

        [When(@"I fill the second form page")]
        public void WhenIFillTheSecondFormPage()
        {
            bool succes = false;
            try
            {
                webUI.betwayHome_page.SetIDType();
                webUI.betwayHome_page.Type_IDNumber();
                webUI.betwayHome_page.Click_ConfirmAge();
                Reporter.SetStepPassed("StatusMessage", "Fill second form pased.");
                Reporter.SetStepPassed("StepStatus", "Pass");
                succes = true;
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Fill second form failed: " + e.Message);
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

    }
}
