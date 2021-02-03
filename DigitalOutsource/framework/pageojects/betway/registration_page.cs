using DigitalOutsource.framework.utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace DigitalOutsource.framework.pageojects.betway
{
    public class registration_page
    {
        private WebDriverWait wait;
        private IWebDriver driver;
        public registration_page(IWebDriver Driver)
        {
            this.driver = Driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "MobileNumber_tmpl")]
        private IWebElement MobileNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Password_tmpl")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName_tmpl")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "LastName_tmpl")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "Email_tmpl")]
        private IWebElement Email { get; set; }

        [FindsBy(How = How.Id, Using = "VoucherCode_tmpl")]
        private IWebElement VoucherCode_tmpl { get; set; }

        [FindsBy(How = How.Id, Using = "ReferralCode_tmpl")]
        private IWebElement ReferralCode { get; set; }

        [FindsBy(How = How.Id, Using = "SignUp")]
        private IWebElement SignUp { get; set; }

        [FindsBy(How = How.Id, Using = "SU-Close")]
        private IWebElement close { get; set; }

        [FindsBy(How = How.Id, Using = "IDType_tmpl")]
        private IWebElement IDType { get; set; }

        [FindsBy(How = How.Id, Using = "IDNumber_tmpl")]
        private IWebElement IDNumber { get; set; }

        [FindsBy(How = How.Id, Using = "Template_TemplateFieldModels_13__Value_Day")]
        private IWebElement day { get; set; }

        [FindsBy(How = How.Id, Using = "Template_TemplateFieldModels_13__Value_Month")]
        private IWebElement month { get; set; }


        [FindsBy(How = How.Id, Using = "Template_TemplateFieldModels_13__Value_Year")]
        private IWebElement year { get; set; }

        [FindsBy(How = How.Id, Using = "nxtBtn")]
        private IWebElement Next { get; set; }

        [FindsBy(How = How.Id, Using = "ConfirmAge_tmpl")]
        private IWebElement ConfirmAge { get; set; }


        


        [FindsBy(How = How.XPath, Using = "//button[@title='Quit Tour'")]
        private IWebElement closeTour { get; set; }

        public void Type_MobileNumber()
        {
            MobileNumber.SendKeys(Parameters.GetData<string>("mobile"));
        }

        public void Type_Password()
        {
            Password.SendKeys(Parameters.GetData<string>("password"));
        }

        public void Type_FirstName()
        {
            FirstName.SendKeys(Parameters.GetData<string>("firstname"));
        }

        public void Type_LastName()
        {
            LastName.SendKeys(Parameters.GetData<string>("lastname"));
        }

        public void Type_Email()
        {
            Email.SendKeys(Parameters.GetData<string>("email"));
        }

        public void Type_IDNumber()
        {
            IDNumber.SendKeys(Parameters.GetData<string>("idnumber"));
        }

        public void Click_SignUp()
        {
            SignUp.SendKeys(Parameters.GetData<string>("email"));
        }

        public void Click_SignUp2()
        {
            seleniumDriver.Webdriver.FindElement(By.XPath("//div[@class='BtnCont']//a[text()='Sign Up']")).Click();
        }

        public void Click_Next()
        {
            Next.Click();
        }

        public void Click_ConfirmAge()
        {
            ConfirmAge.Click();
        }

        public void SetIDType()
        {
            SelectElement Day = new SelectElement(driver.FindElement(By.Id("IDType_tmpl")));
            Day.SelectByValue("South African ID");
       
        }



        public void setDate()
        {
            SelectElement Day = new SelectElement(driver.FindElement(By.Id("Template_TemplateFieldModels_13__Value_Day")));
            Day.SelectByValue("1");

            SelectElement Month = new SelectElement(driver.FindElement(By.Id("Template_TemplateFieldModels_13__Value_Month")));
            Month.SelectByValue("1");

            SelectElement Year = new SelectElement(driver.FindElement(By.Id("Template_TemplateFieldModels_13__Value_Year")));
            Year.SelectByValue("2003");

        }


        public bool Validate_Page()
        {
            return wait.Until(drv => drv.FindElement(By.XPath("//div[@class='BtnCont']//a[text()='Sign Up']"))).Displayed;
        }
    }
}

