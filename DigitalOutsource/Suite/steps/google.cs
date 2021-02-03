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
    public sealed class google
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public google(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to google headline")]
        public void GivenINavigateToGoogleHeadline()
        {
            bool succes = false;
            try
            {

                seleniumDriver.Launchbrowser("CHROME");

                Parameters.SetData("URL", "https://news.google.com/");
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

        [Then(@"I print out all the headline")]
        public void ThenIPrintOutAllTheHeadline()
        {
            bool succes = false;
            try
            {

                Assert.IsTrue(webUI.headline_page.Validate_Page(),"Landing page");
                webUI.headline_page.getListOfElements(); 

                Reporter.SetStepPassed("StatusMessage", "Print headline passed");
                Reporter.SetStepPassed("StepStatus", "Pass");
                succes = true;
            }

            catch (Exception e)
            {
                Reporter.SetStepPassed("StatusMessage", "Print headline failed");
                Reporter.SetStepPassed("StepStatus", "Fail");
            }
            Assert.IsTrue(succes, Reporter.GetStepPassed<string>("StatusMessage"));
        }

    }
}
