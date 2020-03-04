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
    class AutomationLoginBuy
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

            //WOMEN
            IWebElement btnWomen = driver.FindElement(By.XPath("//a[contains(text(),'Women')]"));
            btnWomen.Click();
            Thread.Sleep(2000);

            //SELECT ITEM 1
            IWebElement item1 = driver.FindElement(By.XPath("//img[@alt='Blouse']"));
            item1.Click();
            Thread.Sleep(1000);
            IWebElement addCart = driver.FindElement(By.XPath("//p[@id='add_to_cart']/button/span"));
            addCart.Click();
            Thread.Sleep(3000);
            IWebElement cont = driver.FindElement(By.XPath("//div[4]/span/span"));
            cont.Click();
            Thread.Sleep(2000);
            IWebElement btnWomen2 = driver.FindElement(By.XPath("//a[contains(text(),'Women')]"));
            btnWomen2.Click();
            Thread.Sleep(3000);

            //SELECT ITEM 2
            IWebElement item2 = driver.FindElement(By.XPath("(//img[@alt='Printed Summer Dress'])[2]"));
            item2.Click();
            Thread.Sleep(1000);
            IWebElement addCart2 = driver.FindElement(By.XPath("//p[@id='add_to_cart']/button/span"));
            addCart2.Click();
            Thread.Sleep(3000);
            
            //CHECKPOT
            IWebElement check1 = driver.FindElement(By.XPath("//div[@id='layer_cart']/div/div[2]/div[4]/a/span"));
            check1.Click();
            Thread.Sleep(3000);

            //CHECKPOT
            IWebElement check = driver.FindElement(By.XPath("//div[@id='center_column']/p[2]/a/span"));
            check.Click();
            Thread.Sleep(3000);

            //CHECKOUT
            IWebElement btnCheckOut = driver.FindElement(By.XPath("//div[@id='center_column']/form/p/button/span"));
            btnCheckOut.Click();
            Thread.Sleep(3000);

            //TERMS
            IWebElement terms = driver.FindElement(By.XPath("//input[@id='cgv']"));
            terms.Click();
            Thread.Sleep(3000);

            //CHECKOUT
            IWebElement btnCheckOut3 = driver.FindElement(By.XPath("//form[@id='form']/p/button/span"));
            btnCheckOut3.Click();
            Thread.Sleep(3000);

            //PAYMENT
            IWebElement payment = driver.FindElement(By.XPath("//div[@id='HOOK_PAYMENT']/div/div/p/a"));
            payment.Click();
            Thread.Sleep(3000);

            //CONFIRM ORDER
            IWebElement confirm = driver.FindElement(By.XPath("//p[@id='cart_navigation']/button/span"));
            confirm.Click();
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
