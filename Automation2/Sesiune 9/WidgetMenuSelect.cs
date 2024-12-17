using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation2.Sesiune_9
{
    public class WidgetMenuSelect
    {
        IWebDriver driver;
        [Test]

        public void HWMenuSelect()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement cardWidgets = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
            cardWidgets.Click();

            IJavaScriptExecutor jsd = (IJavaScriptExecutor)driver;
            jsd.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement selectMenu = driver.FindElement(By.XPath("// span[text()=(\"Select Menu\")]"));
            selectMenu.Click();


            // urmeaza sa continui cu ce campuri sa faca select...



           
        }
    }
}
