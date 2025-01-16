using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.ComponentModel.DataAnnotations;

//namespace Automation2.Sesiune_7
//{
    //    public class TemaWebTables
    //    {

    //        public void AddRecords(IWebDriver driver, string firstName, string lastName, int age, string email, int salary, string department);
    //        {
    //        IWebElement addNewRecordButton = driver.FindElement(By.Id("addNewRecordButton"));
    //        addNewRecordButton.Click();
        
    //        driver.FindElement(By.Id("firstName")).SendKeys(firstName);
    //        driver.FindElement(By.Id("lastName")).SendKeys(lastName);
    //        driver.FindElement(By.Id("age")).SendKeys(age);
    //        driver.FindElement(By.Id("userEmail")).SendKeys(email);
    //        driver.FindElement(By.Id("salary")).SendKeys(salary);
    //        driver.FindElement(By.Id("department")).SendKeys(department);

    //        IWebElement submitButton = driver.FindElement(By Id("submit"));
    //        IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
    //        jse.ExecuteScript("argument[0].click();", submitButton);

    //        List<IWebElement> currentListOfRecords = driver.FindElements(By.XPath("//div[@class='rt-tbody']/div/div[@class='rt-tr -odd' or @class='rt-tr -even']")).ToList();
    //        int rowCount = currentListOfRecords.Count;

    //        string baseXpath = $"//div[@class='rt-tr-group'][{rowCount}]";

    //        IWebElement addedFirstName = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][1]"));
    //        IWebElement addedLastName = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][2]"));
    //        IWebElement addedEmail = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][4]"));
    //        IWebElement addedAge = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][3]"));
    //        IWebElement addedSalary = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][5]"));
    //        IWebElement addedDepartment = driver.FindElement(By.XPath($"{baseXpath}//div[@class='rt-td'][6]"));

    //        Assert.AreEqual(addedFirstName.Text, firstName);
    //        Assert.AreEqual(addedLastName.Text, lastName);
    //        Assert.AreEqual(addedAge.Text, age);
    //        Assert.AreEqual(addedEmail, email);
    //        Assert.AreEqual(addedSalary.Text, salary);
    //        Assert.AreEqual(addedDepartment.Text, department);
    //        }

    //        IWebDriver driver;
    //        [Test]
    //        public void Test()
    //        {
    //            IWebDriver driver = new ChromeDriver();
    //            driver.Navigate().GoToUrl("https://demoqa.com/");
    //            driver.Manage().Window.Maximize();

    //            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
    //            js.ExecuteScript("window.scrollTo(0,1000)");

    //            IWebElement elementButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
    //            elementButton.Click();

    //            IWebElement webTablesButton = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
    //            webTablesButton.Click();

    //            AddRecords(driver, "Maria", "Sturza", "35", "msturza@mail.com", "1200", "HR");
    //        }
    
    //    }
    //}