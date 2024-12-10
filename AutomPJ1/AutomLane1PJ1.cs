
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AutomLane1PJ1;

public class TextBoxTests
{
    public IWebDriver Driver;
    public const string BaseUrl = "https://demoqa.com/";

    public const string FullName = "Radu Fifiita";
    public const string Email = "rf-test@email.com";
    public const string CurrentAddress = "Initial address 123";
    public const string PermanentAddress = "Secondary address 1243546@!@#$%";

    [Test]
    public void FillInFormTest()
    {
        // Initializare driver Chrome & pornire instanta browser
        Driver = new ChromeDriver();

        // Navigam la pagina de HOME: https://demoqa.com/
        Driver.Navigate().GoToUrl(BaseUrl);

        // Maximizare instanta browser
        Driver.Manage().Window.Maximize();

        // Define jsExecutor
        IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)Driver;

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 500);");

        // Definim si initializam un selector (pentru a identifica unic un nod in DOM-ul paginii)
        By elementSelector = By.XPath("//h5[text()='Elements']");

        // Initializam un webElement care ne permite interactiunea cu elementul din pagina
        IWebElement elementButton = Driver.FindElement(elementSelector);

        // Dam click pe element
        elementButton.Click();

        // Definim si initializam selector-ul pentru "Text Box" side menu option
        By textBoxSelector = By.XPath("//span[text()='Text Box']");

        // Initialiam webElement-ul pentru TextBox
        IWebElement textBoxOption = Driver.FindElement(textBoxSelector);

        // Dam click pe Text Box option
        textBoxOption.Click();


        // Definim si initializam selector-ul pentru "Full Name" input field
        By fullNameSelector = By.Id("userName");
        IWebElement fullNameInput = Driver.FindElement(fullNameSelector);

        // Introducem valoare in campul de input "Full Name"
        fullNameInput.SendKeys(FullName);

        // Definim si initializam selector-ul pentru "Submit" button
        By submitButtonSelector = By.Id("submit");
        IWebElement submitButton = Driver.FindElement(submitButtonSelector);

        // Scroll
        jsExecutor.ExecuteScript("window.scrollTo(0, 1000);");

        // CLick pe SUBMIT button
        submitButton.Click();

        // Definim si initializam selector-ul pentru "Name" output
        By nameOutputSelector = By.Id("name");
        IWebElement nameOutput = Driver.FindElement(nameOutputSelector);

        Thread.Sleep(5000);

        // Assert
        Assert.That(nameOutput.Text.Contains(FullName));
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
}}