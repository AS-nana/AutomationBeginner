using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation2
{

    //Pe site www.demoqa.com, adauga linie noua in tabelul web tables din Elements
    public class Tests
    {
        IWebDriver driver;
        [Test]

        public void TestMethod()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://demoqa.com/");
            driver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0,1000)");

            IWebElement elementButton = driver.FindElement(By.XPath("//div[@class='card mt-4 top-card'][1]"));
            elementButton.Click();

            IWebElement webTablesButton = driver.FindElement(By.XPath("//span[text()='Web Tables']"));
            webTablesButton.Click();

            IWebElement webTablesAddButton = driver.FindElement(By.Id("addNewRecordButton"));
            webTablesAddButton.Click();

            IWebElement popupFirstName = driver.FindElement(By.Id("firstName"));
            IWebElement popupLastName = driver.FindElement(By.Id("lastName"));
            IWebElement popupEmail = driver.FindElement(By.Id("userEmail"));
            IWebElement popupAge = driver.FindElement(By.Id("age"));
            IWebElement popupSalary = driver.FindElement(By.Id("salary"));
            IWebElement popupDepartment = driver.FindElement(By.Id("department"));
            
            
            popupFirstName.SendKeys("Mihai");
            popupLastName.SendKeys("Abramovici");
            popupEmail.SendKeys("ma@mail.com");
            popupAge.SendKeys("45");
            popupSalary.SendKeys("4000");
            popupDepartment.SendKeys("HR");


            //Click fortat din java pe submit
            //IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            //jse.ExecuteScript("argument[0].click();", submitButton);


            //Click pe submit, dar nu tot timpu poate va functiona si uneori e indicat prin javaexecutor sa faci acest lucru
            IWebElement submitButton = driver.FindElement(By.Id("submit"));
            submitButton.Click();

            //identific datele din randul nou inserat
            IWebElement newRowWebTable = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]"));

            Console.WriteLine(newRowWebTable.Text);
            //verific daca datele scrise sunt cele pe care le cer. dar asa nu fac decat sa imi confirme ca sunt acolo dar nu stim daca ordinea in care sunt inserate e si corecta


            // Assert.True(newRowWebTable.Text.Contains("Mihai"));            // mai corect sa scriu asa Assert.That(newRowWebTable.Text.Contains("Mihai"));
            // Assert.True(newRowWebTable.Text.Contains("Abramovici"));
            // Assert.True(newRowWebTable.Text.Contains("ma@mail.com"));
            // Assert.True(newRowWebTable.Text.Contains("45"));
            // Assert.True(newRowWebTable.Text.Contains("4000"));
            // Assert.True(newRowWebTable.Text.Contains("HR"));
           

            //verific pe rand in fiecare coloana ca sunt valorile asteptate, adica in oridinea corecta in tabel

            IWebElement FirstName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][1]"));
            IWebElement LastName = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][2]"));
            IWebElement Email = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][4]"));
            IWebElement Age = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][3]"));
            IWebElement Salary = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][5]"));
            IWebElement Department = driver.FindElement(By.XPath("//div[@class='rt-tr-group'][4]//div[@class='rt-td'][6]"));

            Assert.That(FirstName.Text.Equals("Mihai"));
            Assert.That(LastName.Text.Equals("Abramovici"));
            Assert.That(Email.Text.Equals("ma@mail.com"));
            Assert.That(Age.Text.Equals("45"));
            Assert.That(Salary.Text.Equals("4000"));
            Assert.That(Department.Text.Equals("HR"));
            
        }
        //[TearDown]
        //public void TearDown()
        //{
        //   if (driver != null)
        //   {
        //      driver.Dispose();
        //        driver.Quit();
        //    }
        //}
    }
}