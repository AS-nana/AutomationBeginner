using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace ExecuteAutomationSessions
{
    public class DotnetSelenium
    {
        [SetUp]
        public void Setup()
        {
        }

        //[Test]
        //public void Test1()
        //{
        //    IWebDriver driver = new EdgeDriver();
        //    driver.Navigate().GoToUrl("https://www.google.com/");
        //    driver.Manage().Window.Maximize();

        //    IWebElement webElement = driver.FindElement(By.Id("APjFqb"));
        //    webElement.SendKeys("Doubtifire");
        //    webElement.SendKeys(Keys.Return);
        //    webElement.Click();
        //    driver.Quit();
        //}

        [Test]
        public void TestLogin()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement BookStoreCard = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][6]"));
            BookStoreCard.Click();

            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("window.scrollTo(0,1000)");

            //IWebElement BookStoreTab = driver.FindElement(By.XPath("//span[text()='Book Store Application']"));
            //BookStoreTab.Click();

            IWebElement BookStoreLogin = driver.FindElement(By.XPath("//span[text()='Login']"));
            BookStoreLogin.Click();

            IJavaScriptExecutor jsal = (IJavaScriptExecutor)driver;
            jsal.ExecuteScript("window.scrollTo(0,1000)");


            IWebElement loginUserName = driver.FindElement(By.Id("userName"));
            loginUserName.SendKeys("magnific");

            IWebElement loginPassword = driver.FindElement(By.Id("password"));
            loginPassword.SendKeys("!Qaz");

            //IWebElement loginPasswordEye = driver.FindElement(By.Id("password"));
            //loginPasswordEye.SendKeys("!Qaz");

            IWebElement LoginButton = driver.FindElement(By.Id("login"));
            LoginButton.Click();

        }
        [Test]
        public void TestLoginReduced()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][6]")).Click();
            
            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("window.scrollTo(0,1000)");

          
            driver.FindElement(By.XPath("//span[text()='Login']")).Click();
            

            IJavaScriptExecutor jsal = (IJavaScriptExecutor)driver;
            jsal.ExecuteScript("window.scrollTo(0,1000)");


            driver.FindElement(By.Id("userName")).SendKeys("magnific");    
            driver.FindElement(By.Id("password")).SendKeys("!Qaz");
            driver.FindElement(By.Id("login")).Click();
        }


        [Test]
        public void TestWorkingWithAdvancedControls()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]")).Click();//click pe Elementts card
            

            IJavaScriptExecutor jsa = (IJavaScriptExecutor)driver;
            jsa.ExecuteScript("window.scrollTo(0,1000)");

            driver.FindElement(By.XPath("//span[text()='Check Box']")).Click();//click pe Check Box
            driver.FindElement(By.XPath("//button[@title='Toggle']//*[name()='svg']")).Click();//toggler de la Home

            IJavaScriptExecutor jsd = (IJavaScriptExecutor)driver;
            jsd.ExecuteScript("window.scrollTo(0,200)");

            driver.FindElement(By.CssSelector("body > div:nth-child(6) > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > div:nth-child(1) > ol:nth-child(2) > li:nth-child(1) > ol:nth-child(2) > li:nth-child(2) > span:nth-child(1) > button:nth-child(1) > svg:nth-child(1)")).Click();//click pe toggler de la Documents
                                                                                                                                                                                                                                                                                                                                         //driver.FindElement(By.CssSelector("body div[id='app'] li[class='rct-node rct-node-parent rct-node-expanded'] li[class='rct-node rct-node-parent rct-node-expanded'] li:nth-child(2) span:nth-child(1) button:nth-child(1) svg path")).Click();//click pe toggler de la Office

            driver.FindElement(By.XPath("//label[@for='tree-node-office']//span[@class='rct-checkbox']//*[name()='svg']")).Click();//bifa pe Office
        }

    }
}