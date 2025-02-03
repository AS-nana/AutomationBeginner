using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Security.Cryptography.X509Certificates;
using OpenQA.Selenium.Interactions;
using static OpenQA.Selenium.BiDi.Modules.BrowsingContext.Locator;

namespace Automation2.Sesiune_5
{ 
    public class StructuriRepetitive
{
    IWebDriver webDriver;
    [Test]

    public void StructuriRepetitivetMethod()
    {
        webDriver = new ChromeDriver();
        webDriver.Navigate().GoToUrl("https://demoqa.com/");
        webDriver.Manage().Window.Maximize();

        IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
        js.ExecuteScript("window.scrollTo(0,500)");

        IWebElement interactionsCard = webDriver.FindElement(By.XPath("//h5[text()='Interactions']"));
        interactionsCard.Click();

        IWebElement sortableButton = webDriver.FindElement(By.XPath("//span[text()='Sortable']"));
        sortableButton.Click();

        List<IWebElement> listInteractions = webDriver.FindElements(By.XPath("//div[@class='element-list collapse show']/ul[@class='menu-list']/li[@class='btn btn-light ']")).ToList();
        listInteractions[0].Click();

        List<IWebElement> listElements = webDriver.FindElements(By.XPath("//div[@class='vertical-list-container mt-4']/div")).ToList();
        //Console.WriteLine(listElements[0].Text);
        //Console.WriteLine(listElements[1].Text);
        for (int i = 0; i < listElements.Count; i++)
        {
            Console.WriteLine(listElements[i].Text);
        }
    }
        
        [Test]
        public void Test2Hobbies()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://demoqa.com/");
            webDriver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement formsElement = webDriver.FindElement(By.XPath("//h5[text()='Forms']"));
            formsElement.Click();

            IWebElement practiceFormElement = webDriver.FindElement(By.XPath("//span[text()='Practice Form']"));
            practiceFormElement.Click();

            js.ExecuteScript("window.scrollTo(0,1000)");

            //identificam fiecare element de hobbies
            IWebElement sportsElement = webDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-1']"));
            IWebElement readingElement = webDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-2']"));
            IWebElement musicElement = webDriver.FindElement(By.XPath("//label[@for='hobbies-checkbox-3']"));

            //definim lista de hobbies
            List<IWebElement> hobbiesList = new List<IWebElement>();
            hobbiesList.Add(sportsElement);
            hobbiesList.Add(readingElement);
            hobbiesList.Add(musicElement);

            string[] array = ["Sports", "Music"];

            foreach (IWebElement hobby in hobbiesList)
            {
                foreach (string item in array)
                {
                    if (hobby.Text.Equals(item))
                    {
                        hobby.Click();
                    }
                }

            }
        }
            //sterge elemente daca exista in campul de Subjects
            [Test]
            public void Test3SubjectsDelete()
            {
                webDriver = new ChromeDriver();
                webDriver.Navigate().GoToUrl("https://demoqa.com/");
                webDriver.Manage().Window.Maximize();

                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("window.scrollTo(0,1000)");

                IWebElement formsElement = webDriver.FindElement(By.XPath("//h5[text()='Forms']"));
                formsElement.Click();

                IWebElement practiceFormElement = webDriver.FindElement(By.XPath("//span[text()='Practice Form']"));
                practiceFormElement.Click();

                js.ExecuteScript("window.scrollTo(0,1000)");

                IWebElement subjectsFields = webDriver.FindElement(By.Id("subjectsInput"));

            /*Actions actions = new Actions(webDriver);

            List<string> subjects = new List<string> { "English", "Maths", "Chemistry", "Physics" };

            foreach (var subject in subjects)
            {
                actions.Click(subjectsFields)
                    .SendKeys(subject)                          //Send the subject name
                    .Pause(TimeSpan.FromMilliseconds(500))      //Pause for the dropdown to show
                    .SendKeys(Keys.Enter)                       //Select the subject from the dropdown
                    .Build()
                    .Perform();                                 //Perform the action

                System.Threading.Thread.Sleep(500);
            }*/

            subjectsFields.SendKeys("Biology");
            subjectsFields.SendKeys(Keys.Enter);
            subjectsFields.SendKeys("Arts");
            subjectsFields.SendKeys(Keys.Enter);
            subjectsFields.SendKeys("History");
            subjectsFields.SendKeys(Keys.Enter);


            //atata timp cat eu am un flag setat pe true sa stearga pe acel x

            List<IWebElement> removeSubects= webDriver.FindElements(By.XPath("//div[@class='css - xb97g8 subjects - auto - complete__multi - value__remove']")).ToList();
            bool subjectFlag = true;
            while (subjectFlag)
            { 
            foreach(IWebElement element in removeSubects)
                {
                    element.Click();
                }
                subjectFlag = false;
            }
        }   
        /*
        [TearDown]
        public void CleanUp()
        {
            if (webDriver != null)
            {
                webDriver.Quit();
                webDriver.Dispose();
            }
        }*/
    }

}





