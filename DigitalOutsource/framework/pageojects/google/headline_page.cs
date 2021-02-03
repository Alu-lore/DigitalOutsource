using DigitalOutsource.framework.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalOutsource.framework.pageojects
{
    public class headline_page
    {
        private WebDriverWait wait;
        private IWebDriver driver;
        public headline_page(IWebDriver Driver)
        {
            this.driver = Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(driver, this);
        }

        public void getListOfElements()
        {
            string temp = "";
            List<IWebElement> content_data = new List<IWebElement>();
            content_data = driver.FindElements(By.XPath("//article//h3//a")).ToList();

            List<string> headline = new List<string>();

            foreach (var c in content_data)
            {
                temp = temp + "\r\n" + c.Text;
            }

            Parameters.SetData("ConsoleOutput", temp); 
        }

        public bool Validate_Page()
        {
            return wait.Until(drv => drv.FindElement(By.XPath("//a[text()='Headlines']"))).Displayed;
        }


    

    }
}
