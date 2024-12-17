using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automation2.Sesiune_9
{
    public class WidgestAutoComplete
    {
        IWebDriver driver;
        [Test]

        public void HWAutoComplete()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement cardWidgets = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][4]"));
            cardWidgets.Click();

            IWebElement autoComplete = driver.FindElement(By.XPath("// span[text()=(\"Auto Complete\")]"));
            autoComplete.Click();

            IWebElement multipleColors = driver.FindElement(By.Id("autoCompleteMultipleInput"));
            multipleColors.SendKeys("blue");
            multipleColors.SendKeys(Keys.Enter);
            multipleColors.SendKeys("r");
            multipleColors.SendKeys(Keys.ArrowDown);
            multipleColors.SendKeys(Keys.Enter);

            IWebElement singleColor = driver.FindElement(By.Id("autoCompleteSingleInput"));
            singleColor.SendKeys("y");
            singleColor.SendKeys(Keys.Enter);
        }
    }
}
