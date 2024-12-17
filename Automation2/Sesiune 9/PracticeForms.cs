using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Automation2.Sesiune_5
{
    public class PracticeForms
    {
        IWebDriver webDriver;
        [Test]

        public void TestMethod()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://demoqa.com/");
            webDriver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsButton = webDriver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][2]"));
            formsButton.Click();
            IJavaScriptExecutor jsd = (IJavaScriptExecutor)webDriver;
            jsd.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementPracticeForms = webDriver.FindElement(By.XPath("//*[text()='Practice Form']"));
            elementPracticeForms.Click();

            IWebElement genderMale = webDriver.FindElement(By.XPath("//label[@for='gender-radio-1']"));
            IWebElement genderFemale = webDriver.FindElement(By.XPath("//label[@for='gender-radio-2']"));
            IWebElement genderOther = webDriver.FindElement(By.XPath("//label[@for='gender-radio-3']"));

            string gender = "Male";

            //if (gender.Equals("Male"))
            //{
            //    genderMale.Click();
            //}
            //else if (gender.Equals("Female"))
            //{
            //    genderFemale.Click();
            //}
            //else
            //{
            //    genderOther.Click();

            //}

            switch (gender)
            {
                case "Male":
                    genderMale.Click();
                    break;
                case "Female":
                    genderFemale.Click();  
                    break;
                case "Other":
                    genderOther.Click();    
                    break;
            }


            // selecteaza din campul subjects
            IWebElement subjectsFields = webDriver.FindElement(By.Id("subjectsInput"));
            subjectsFields.SendKeys("English");
            subjectsFields.SendKeys(Keys.Enter);
            subjectsFields.SendKeys("C");
            subjectsFields.SendKeys(Keys.ArrowDown);
            subjectsFields.SendKeys(Keys.ArrowDown);
            subjectsFields.SendKeys(Keys.ArrowDown);
            subjectsFields.SendKeys(Keys.Enter);

            //sau clasa de actions sa completezi fieldul aici ai nevoie si de un build perform
            

            //tema1: pe widgets-auto complete sa inseram pe cele 2 fielduri
            //tema2: pe widgest-menu: select menu... e cu actiunea de Select..


        }
    }
}
