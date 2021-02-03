using DigitalOutsource.framework.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.pageojects
{
    public class seleniumDriver
    {
            public static IWebDriver Webdriver;
            public static int screenshotcount = 0;
            public static void Launchbrowser(string browser)
            {
                Parameters.SetData("Browsers", browser);
                switch (browser)
                {
                    case "CHROME":
                        Webdriver = new ChromeDriver(string.Format(@"{0}\{1}", utils.ProjectRoot(), utils.GetAppConfigValue("Drivers")));
                        Webdriver.Manage().Window.Maximize();
                        break;
                }
            }

            public static void close()
            {
                if (Webdriver != null)
                {
                    Webdriver.Close();
                }

            }

            public static bool TakeScreenshot(IWebDriver drvr, string imagename)
            {
                Screenshot screenshot = ((ITakesScreenshot)drvr).GetScreenshot();
                screenshot.SaveAsFile(string.Format(@"{0}\ExtentReport\images\{1}.jpg", utils.ProjectRoot() + @"\Results", imagename), ScreenshotImageFormat.Jpeg);
                return true;
            }
        }


    }

