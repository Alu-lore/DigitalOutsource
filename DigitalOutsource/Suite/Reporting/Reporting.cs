using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using DigitalOutsource.framework.utility;
using DigitalOutsource.framework.pageojects;

namespace DigitalOutsource.Suite.Reporting
{
    public class Reporting
    {
        public static int images = 0; 
        private static ExtentTest TestFeature;
        private static ExtentTest scenario;
        private static ExtentReports ExtentReports;
        private static ExtentHtmlReporter hmtlreport;
        private static string extentHtmlPath = string.Format(@"{0}\ExtentReport\ExtentReport.html", utils.ProjectRoot()+@"\Results");
        private static string reportPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


        public static void initialize_report(string OSVersion, string BrowserType, string Environment)
        {
            hmtlreport = new ExtentHtmlReporter(extentHtmlPath);
            ExtentReports = new ExtentReports();
            ExtentReports.AttachReporter(hmtlreport);
            ExtentReports.AddSystemInfo("OS version", OSVersion);
            ExtentReports.AddSystemInfo("Browser", BrowserType);
            ExtentReports.AddSystemInfo("Environmet ", Environment);

        }
        public static void StepPassFail(string type, string step, string stepStatus)
        {
            images =images+1; 
            string datestamp = DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss");
            var screenshotspath = string.Format(@"{0}\ExtentReport\images\{1}", utils.ProjectRoot() + @"\Results", string.Format("Image_{0}.jpg", images));
            utils.CreateDir(string.Format(@"{0}\ExtentReport\images", utils.ProjectRoot()+@"\Results"));

            seleniumDriver.TakeScreenshot(seleniumDriver.Webdriver, string.Format("Image_{0}", images));
            
            switch (stepStatus)
            {
                case "Fail":
                    scenario.Log(Status.Fail, string.Format("<b>{0}</b> {1} <br>Console Output: {4}<br><a href ='{3}'><img src='{2}' height = '250' width = '250'/></a> ", type, step, screenshotspath, screenshotspath, screenshotspath, Parameters.GetData<string>("ConsoleOutput")));
                    break;

                case "Warning":
                    scenario.Log(Status.Warning, string.Format("<b>{0}</b> {1} <br> Console Output: {4}<br><a href ='{3}'><img src='{2}' height = '250' width = '250'/></a> ", type, step, screenshotspath, screenshotspath, screenshotspath, Parameters.GetData<string>("ConsoleOutput")));
                    break;

                case "Pass":
                    scenario.Log(Status.Pass, string.Format("<b>{0}</b> {1} <br>Console Output: {4}<br><a href ='{3}'><img src='{2}' height = '250' width = '250'/></a> ", type, step, screenshotspath, screenshotspath,Parameters.GetData<string>("ConsoleOutput")));
                    break;

            }

            Reporter.Clear();

        }

        public static void CreateScenarionNode(String s)
        {
            scenario = TestFeature.CreateNode(s);
        }


        public static void CreateTestFeature(string s)
        {
            TestFeature = ExtentReports.CreateTest(s);
        }

        public static void flush()
        {
            ExtentReports.Flush();
        }

    }
}
