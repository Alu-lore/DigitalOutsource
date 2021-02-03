using DigitalOutsource.framework.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DigitalOutsource.framework.pageojects.shared
{
    public class common_page
    {
        private WebDriverWait wait;
        private IWebDriver driver;
        public common_page(IWebDriver Driver)
        {
            this.driver = Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(driver, this);
        }

        public void NaviagteTo()
        {
            try
            {
                driver.Navigate().GoToUrl(Parameters.GetData<string>("URL"));
            }
            catch (Exception)
            {

                throw;
            }
        }

    }    
}