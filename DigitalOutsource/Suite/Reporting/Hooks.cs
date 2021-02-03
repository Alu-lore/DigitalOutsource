using DigitalOutsource.framework.pageojects;
using DigitalOutsource.framework.utility;
using TechTalk.SpecFlow;


namespace DigitalOutsource.Suite.Reporting
{
    [Binding]
    public class Hooks
    {
        [BeforeTestRun]
        public static void startup()
        {
            Parameters.SetData("ConsoleOutput", string.Empty);
            Reporting.initialize_report("WINNDOWS", "CHROME", "Lores");
        }

        [AfterTestRun]
        public static void EndTest()
        {
          
            Reporting.flush();
        }

        [AfterStep]
        public static void reportSteps()
        {
            Reporting.StepPassFail(ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString(), ScenarioStepContext.Current.StepInfo.Text.ToString(), Reporter.GetStepPassed<string>("StepStatus"));

        }

        [BeforeScenario]
        public static void BeforeScen()
        {
            Reporting.CreateScenarionNode(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [AfterFeature]
        public static void AfterFeature()
        { 
            seleniumDriver.close();
        }

        [BeforeFeature]
        public static void BeforeFeature()
        {
            Reporting.CreateTestFeature(FeatureContext.Current.FeatureInfo.Title);
        }
    }
}

