using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation2.Sesiune_9.grupa1
{
    public class Grupa1PracticeForms
    {
        public IWebDriver Driver;
        public const string BaseUrl = "https://demoqa.com/";

        public const string FirstName = "Radu";
        public const string LastName = "Fifiita";
        public const string Email = "rf-test@email.com";
        public const string Age = "32";
        public const string Salary = "50000";
        public const string Department = "Software Dev";

        [SetUp]
        public void Setup()
        {
            // Initializare driver Chrome & pornire instanta browser
            Driver = new ChromeDriver();

            // Navigam la pagina de HOME: https://demoqa.com/
            Driver.Navigate().GoToUrl(BaseUrl);

            // Maximizare instanta browser
            Driver.Manage().Window.Maximize();
        }

        [TestCase("Male")]
        [TestCase("Female")]
        [TestCase("Other")]
        [TestCase("Monkey")]
        public void GenderTest(string userInputGender)
        {
            // Define jsExecutor
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;

            // Scroll
            jsExecutor.ExecuteScript("window.scrollTo(0, 500);");

            // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
            By formsSelector = By.XPath("//h5[text()='Forms']");

            // Initializam un webElement care ne permite interactiunea cu elementul din pagina
            IWebElement formsButton = Driver.FindElement(formsSelector);

            // Dam click pe element
            formsButton.Click();

            // Definim si initializam selector-ul pentru "Practice Form" side menu option
            By practiceFormSelector = By.XPath("//span[text()='Practice Form']");

            // Initialiam webElement-ul pentru Practice Form
            IWebElement practiceFormOption = Driver.FindElement(practiceFormSelector);

            // Dam click pe Practice Form option
            practiceFormOption.Click();

            // Definim si initializam selector-ul pentru Gender MALE
            By genderMaleSelector = By.Id("gender-radio-1");

            // Initializam webElement-ul pentru Gender MALE
            IWebElement genderMaleInput = Driver.FindElement(genderMaleSelector);

            // Definim si initializam selector-ul pentru Gender FEMALE
            By genderFemaleSelector = By.Id("gender-radio-2");

            // Initializam webElement-ul pentru Gender FEMALE
            IWebElement genderFemaleInput = Driver.FindElement(genderFemaleSelector);

            // Definim si initializam selector-ul pentru Gender OTHER
            By genderOtherSelector = By.Id("gender-radio-3");

            // Initializam webElement-ul pentru Gender OTHER
            IWebElement genderOtherInput = Driver.FindElement(genderOtherSelector);

            //if (genderMaleInput.GetDomAttribute("value") == userInputGender)
            //{
            //    jsExecutor.ExecuteScript("arguments[0].click();", genderMaleInput);
            //}
            //else if (genderFemaleInput.GetDomAttribute("value") == userInputGender)
            //{
            //    jsExecutor.ExecuteScript("arguments[0].click();", genderFemaleInput);
            //}
            //else
            //{
            //    jsExecutor.ExecuteScript("arguments[0].click();", genderOtherInput);
            //}


            // IF & SWITCH STATEMENT
            By genderMaleLabelSelector = By.XPath("//label[@for=\"gender-radio-1\"]");
            IWebElement genderMaleLabel = Driver.FindElement(genderMaleLabelSelector);

            By genderFemaleLabelSelector = By.XPath("//label[@for=\"gender-radio-2\"]");
            IWebElement genderFemaleLabel = Driver.FindElement(genderFemaleLabelSelector);

            By genderOtherLabelSelector = By.XPath("//label[@for=\"gender-radio-3\"]");
            IWebElement genderOtherLabel = Driver.FindElement(genderOtherLabelSelector);

            //if (genderMaleLabel.Text == userInputGender)
            //{
            //    genderMaleLabel.Click();
            //}
            //else if (genderFemaleLabel.Text == userInputGender)
            //{
            //    genderFemaleLabel.Click();
            //}
            //else
            //{
            //    genderOtherLabel.Click();
            //}

            switch (userInputGender)
            {
                case "Male":
                    genderMaleLabel.Click();
                    break;
                case "Female":
                    genderFemaleLabel.Click();
                    break;
                default:
                    genderOtherLabel.Click();
                    break;
            }


            //Sleep 5 sec
            Thread.Sleep(5000);
        }

        [TestCase("Sport")]
        [TestCase("Sports")]
        [TestCase("Reading")]
        [TestCase("Books")]
        [TestCase("Music")]
        public void HobbiesTest(string userInputHobby)
        {
            // Define jsExecutor
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;

            // Scroll
            jsExecutor.ExecuteScript("window.scrollTo(0, 500);");

            // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
            By formsSelector = By.XPath("//h5[text()='Forms']");

            // Initializam un webElement care ne permite interactiunea cu elementul din pagina
            IWebElement formsButton = Driver.FindElement(formsSelector);

            // Dam click pe element
            formsButton.Click();

            // Definim si initializam selector-ul pentru "Practice Form" side menu option
            By practiceFormSelector = By.XPath("//span[text()='Practice Form']");

            // Initialiam webElement-ul pentru Practice Form
            IWebElement practiceFormOption = Driver.FindElement(practiceFormSelector);

            // Dam click pe Practice Form option
            practiceFormOption.Click();

            By hobbySportsSelector = By.XPath("//label[@for=\"hobbies-checkbox-1\"]");
            IWebElement hobbySportsLabel = Driver.FindElement(hobbySportsSelector);

            By hobbyReadingSelector = By.XPath("//label[@for=\"hobbies-checkbox-2\"]");
            IWebElement hobbyReadingLabel = Driver.FindElement(hobbyReadingSelector);

            By hobbyMusicSelector = By.XPath("//label[@for=\"hobbies-checkbox-3\"]");
            IWebElement hobbyMusicLabel = Driver.FindElement(hobbyMusicSelector);

            switch (userInputHobby)
            {
                case "Sport":
                case "Sports":
                    hobbySportsLabel.Click();
                    break;
                case "Reading":
                case "Books":
                    hobbyReadingLabel.Click();
                    break;
                case "Music":
                    hobbyMusicLabel.Click();
                    break;
                default:
                    break;
            }

            Thread.Sleep(5000);
        }

        [TearDown]
        public void CleanUp()
        {
            if (Driver != null)
            {
                Driver.Quit();
                Driver.Dispose();
            }
        }
    }
}
