using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class UntitledTestCase
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }


        //TEST CASES START ***************************
        [TestMethod]
        public void PassingCaseTest()
        {
            driver.Navigate().GoToUrl("https://letsusedata.com/index.html");
            driver.FindElement(By.Id("txtUser")).Click();
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("test1");
            driver.FindElement(By.Id("txtPassword")).Click();
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("Test12456");
            driver.FindElement(By.Id("javascriptLogin")).Click();

            Assert.AreEqual("test1", driver.FindElement(By.Id("txtUser")).GetAttribute("value"));
            Assert.AreEqual("Test12456", driver.FindElement(By.Id("txtPassword")).GetAttribute("value"));
        }

        [TestMethod]
        public void FailingCaseTest()
        {
            driver.Navigate().GoToUrl("https://letsusedata.com/index.html");
            driver.FindElement(By.Id("txtUser")).Clear();
            driver.FindElement(By.Id("txtUser")).SendKeys("test1");
            driver.FindElement(By.Id("txtPassword")).Clear();
            driver.FindElement(By.Id("txtPassword")).SendKeys("test1234");
            driver.FindElement(By.Id("javascriptLogin")).Click();

            Assert.AreEqual("test1", driver.FindElement(By.Id("txtUser")).GetAttribute("value"));
            Assert.AreEqual("Test12456", driver.FindElement(By.Id("txtPassword")).GetAttribute("value"));
        }
        //TEST CASES END *****************************

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
