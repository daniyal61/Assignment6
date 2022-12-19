using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace Assignment6
{
    [TestClass]
    public class Assignment_5_Task_1:Methods
    {
        
        IJavaScriptExecutor jsScroll;
        [TestInitialize]
        public void testPre_Reqs()
        {
            driver.Url = "https://demoqa.com/";
            driver.Manage().Window.Maximize();
            jsScroll = driver as IJavaScriptExecutor;
        }
        [TestCleanup]
        public void testPost_Reqs()
        {
            driver.Quit();
        }
        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"C:\Users\DELL\source\repos\Assignment6\TextBoxData.xml", "TextBox", DataAccessMethod.Sequential)]
        public void Automate_Website_TextBox()
        {
            Thread.Sleep(1000);
            jsScroll.ExecuteScript("window.scrollBy(0,250)", "");
            Method1("xpath", "//h5[text() = 'Elements']").Click();
            Method1("xpath", "//span[text()='Text Box']").Click();
            Method1("xpath", "//input[@id='userName']").SendKeys(TestContext.DataRow[0].ToString());
            Method1("xpath", "//input[@id='userEmail']").SendKeys(TestContext.DataRow[1].ToString());
            Method1("xpath", "//textarea[@id='currentAddress']").SendKeys(TestContext.DataRow[2].ToString());
            Method1("xpath", "//textarea[@id='permanentAddress']").SendKeys(TestContext.DataRow[3].ToString());
            jsScroll.ExecuteScript("window.scrollBy(0,500)", "");
            Method1("xpath", "//button[@id='submit']").Click();
            Thread.Sleep(3000);
        }
        [TestMethod]
        public void Automate_Website_CheckBox()
        {
            Thread.Sleep(1000);
            jsScroll.ExecuteScript("window.scrollBy(0,250)", "");
            Method1("xpath", "//h5[text() = 'Elements']").Click();
            Method1("xpath", "//span[text()='Check Box']").Click();
            Method1("xpath", "//button[@title = 'Expand all']").Click();
            Method1("xpath", "//label[@for = 'tree-node-commands']").Click();
            Method1("xpath", "//label[@for = 'tree-node-angular']").Click();
            jsScroll.ExecuteScript("window.scrollBy(0,350)", "");
            Method1("xpath", "//label[@for = 'tree-node-wordFile']").Click();
            Thread.Sleep(2000);
        }
        [TestMethod]
        public void Automate_Website_RadioBtn()
        {
            Thread.Sleep(1000);
            jsScroll.ExecuteScript("window.scrollBy(0,250)","");
            Method1("xpath", "//h5[text() = 'Elements']").Click();
            Method1("xpath", "//span[text() = 'Radio Button']").Click();
            Method1("xpath", "//label[@for = 'yesRadio']").Click();
            Method1("xpath", "//label[@for = 'impressiveRadio']").Click();
        }
    }
}
