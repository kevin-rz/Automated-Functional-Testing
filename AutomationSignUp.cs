using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace AutomationAlmaG
{
    class AutomationSignUp
    {
        IWebDriver driver;

        [SetUp] //This is a NUnit method
        public void startBrowser()
        {
            driver = new FirefoxDriver("C:/Users/kramirez/Downloads/AutomationAlmaG/");
        }

        [Test]
        public void Explore_and_submit_form()
        {
            driver.Url = "http://automationpractice.com/index.php";

            IWebElement signInBtn = driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));

            signInBtn.Click();
            Thread.Sleep(1000);

            IWebElement emailInput = driver.FindElement(By.XPath("//form[@id='create-account_form']/div/div[2]/input"));
            IWebElement emailSubmit = driver.FindElement(By.XPath("//button[@id='SubmitCreate']/span"));

            emailInput.Click();
            emailInput.SendKeys("kramirez3@sciodev.com");
            Thread.Sleep(1000);

            emailSubmit.Click();
            Thread.Sleep(3000);

            //FORM
            IWebElement tittle = driver.FindElement(By.XPath("//input[@id='id_gender1']"));
            IWebElement fName = driver.FindElement(By.XPath("//input[@id='customer_firstname']"));
            IWebElement lName = driver.FindElement(By.XPath("//input[@id='customer_lastname']"));
            IWebElement pass = driver.FindElement(By.XPath("//input[@id='passwd']"));
            IWebElement day = driver.FindElement(By.XPath("//select[@id='days']/option[26]"));
            IWebElement month = driver.FindElement(By.XPath("//select[@id='months']/option[8]"));
            IWebElement year = driver.FindElement(By.XPath("//select[@id='years']/option[28]"));
            IWebElement company = driver.FindElement(By.XPath("//input[@id='company']"));
            IWebElement adderss = driver.FindElement(By.XPath("//input[@id='address1']"));
            IWebElement city = driver.FindElement(By.XPath("//input[@id='city']"));
            IWebElement state = driver.FindElement(By.XPath("//select[@id='id_state']/option[15]"));
            IWebElement pc = driver.FindElement(By.XPath("//input[@id='postcode']"));
            IWebElement phone = driver.FindElement(By.XPath("//input[@id='phone_mobile']"));
            IWebElement SignInsSubmit = driver.FindElement(By.XPath("//button[@id='submitAccount']/span"));
            
            tittle.Click();
            Thread.Sleep(1000);

            fName.Click();
            fName.SendKeys("Kevin");
            Thread.Sleep(1000);

            lName.Click();
            lName.SendKeys("Ramirez");
            Thread.Sleep(1000);

            pass.Click();
            pass.SendKeys("12345");
            Thread.Sleep(1000);

            day.Click();
            month.Click();
            year.Click();
            Thread.Sleep(1000);
            
            company.Click();
            company.SendKeys("SCIO");
            adderss.Click();
            adderss.SendKeys("Wall Street 14");
            Thread.Sleep(1000);

            city.SendKeys("Chicago");
            Thread.Sleep(1000);
            state.Click();
            Thread.Sleep(1000);
            pc.SendKeys("60638");
            Thread.Sleep(1000);
            phone.SendKeys("0017737085");
            Thread.Sleep(1000);

            SignInsSubmit.Click();
            Thread.Sleep(3000);
            //We can use Click action most of the time, also to send information in a textbox we can use SendKeys. You can read more about it looking for "Selenium webdriver commands"
        }

        [TearDown] //This is another NUnit method
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
