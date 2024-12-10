using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation1
{
    public class TexBoxTest
    {
        IWebDriver driver;

        [Test]
        public void WebFillIn()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement ElementCard = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            ElementCard.Click();

            IWebElement TextBoxCard = driver.FindElement(By.XPath("//*[text()='Text Box']"));
            TextBoxCard.Click();


            IWebElement elementFirstName = driver.FindElement(By.Id("userName"));
            elementFirstName.SendKeys("Lavinia Milosovici");

            IWebElement elementEmail = driver.FindElement(By.Id("userEmail"));
            elementEmail.SendKeys("l.milosovici@mail.com");

            IWebElement currentAddress = driver.FindElement(By.Id("currentAddress"));
            currentAddress.SendKeys("Str.Sportului, nr 64, Deva,HD");

            IJavaScriptExecutor jos = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1500)");

            IWebElement permanentAddress = driver.FindElement(By.Id("permanentAddress"));
            permanentAddress.SendKeys("Str. Campionilor, nr 10, sector 1, Bucuresti");

            IWebElement SubmitButton = driver.FindElement(By.Id("submit"));
            SubmitButton.Click();
        }
    }
}