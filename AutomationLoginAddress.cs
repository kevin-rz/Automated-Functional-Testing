using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationAlmaG
{
    class AutomationLoginAddress
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

            IWebElement emailInput = driver.FindElement(By.XPath("//input[@id='email']"));
            IWebElement passInput = driver.FindElement(By.XPath("//input[@id='passwd']"));
            IWebElement loginSubmit = driver.FindElement(By.XPath("//button[@id='SubmitLogin']/span"));

            emailInput.Click();
            emailInput.SendKeys("kramirez@sciodev.com");
            Thread.Sleep(1000);
            passInput.Click();
            passInput.SendKeys("12345");
            Thread.Sleep(1000);

            loginSubmit.Click();
            Thread.Sleep(3000);

            //MY ADDRESSES
            IWebElement myAddresses = driver.FindElement(By.XPath(" //div[@id='center_column']/div/div/ul/li[3]/a/span"));
            myAddresses.Click();
            Thread.Sleep(2000);

            //ADD A NEW ADDRESS
            IWebElement newAddress = driver.FindElement(By.XPath("//div[@id='center_column']/div[2]/a/span"));
            newAddress.Click();
            Thread.Sleep(2000);

            //FORM  
              IWebElement adderss = driver.FindElement(By.XPath("//input[@id='address1']"));
              IWebElement city = driver.FindElement(By.XPath("//input[@id='city']"));
              IWebElement state = driver.FindElement(By.XPath("//select[@id='id_state']/option[11]"));
              IWebElement pc = driver.FindElement(By.XPath("//input[@id='postcode']"));
            IWebElement phone = driver.FindElement(By.XPath("//input[@id='phone_mobile']"));
            IWebElement phoneHome = driver.FindElement(By.XPath("//input[@id='phone']"));
            IWebElement submitAddress = driver.FindElement(By.XPath("//button[@id='submitAddress']/span"));

              adderss.Click();
              adderss.SendKeys("Luna Avenue 654");
              Thread.Sleep(1000);

              city.SendKeys("Miami");
              Thread.Sleep(1000);
              state.Click();
              Thread.Sleep(1000);
              pc.SendKeys("50698");
              Thread.Sleep(1000);
            phoneHome.SendKeys("0017739654");
            Thread.Sleep(1000);
            phone.SendKeys("0017737085");
              Thread.Sleep(1000);
            

            submitAddress.Click();
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
