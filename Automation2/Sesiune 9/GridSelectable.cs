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

namespace Automation2.HWSelectableGrid
{
    public class HWGridSelectable
    {

        IWebDriver webDriver;
        [Test]

        public void GridSelect()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://demoqa.com/");
            webDriver.Manage().Window.Maximize();

            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            js.ExecuteScript("window.scrollTo(0,500)");

            IWebElement interactionsCard = webDriver.FindElement(By.XPath("//h5[text()='Interactions']"));
            interactionsCard.Click();

            IWebElement selectableButton = webDriver.FindElement(By.XPath("//span[text()='Selectable']"));
            selectableButton.Click();


            IWebElement selectableGrid = webDriver.FindElement(By.Id("demo-tab-grid"));
            selectableGrid.Click();

            List<IWebElement> listRows = webDriver.FindElements(By.XPath("//div[starts-with(@id,'row')]")).ToList();
            /*listRows[0].Click();

            List<IWebElement> listCells = webDriver.FindElements(By.XPath("//div[starts-with(@id,'row')]/li")).ToList();
            listCells[0].Click();
            listCells[2].Click();
            listCells[4].Click();
            listCells[6].Click();
            listCells[8].Click();
            */
            foreach (var row in listRows)
            {
                List<IWebElement> rowCellList = row.FindElements(By.XPath("./li")).ToList();

                foreach (var cell in rowCellList)
                {
                    if (int.TryParse(cell.Text, out int cellNumber) && cellNumber % 2 != 0)
                    {
                        cell.Click();
                        Console.WriteLine($"Clicked on cell with number: {cellNumber}");
                    }
                }
            }


            /*List<IWebElement> listRows = webDriver.FindElements(By.XPath("//div[starts-with(@id,'row')]")).ToList();

            for (int i = 0; i < listRows.Count; i++)
            {
                //List to store the cells for each row 
                List<IWebElement> rowCellList = listRows[i].FindElements(By.XPath("./li")).ToList();

                //iterate the CELL list
                for (int j = 0; j < rowCellList.Count; j++)
                {
                    if (i % 2 == 0)
                        if (j % 2 == 0)
                        {
                            rowCellList[j].Click();
                            Console.WriteLine($"Clicked on {rowCellList[j].Text} cell");
                        }
                        else
                        {
                            if (j % 2 != 0)
                            {
                                rowCellList[j].Click();
                                Console.WriteLine($"Clicked on {rowCellList[j].Text}");
                            }
                        }
                }
            }*/



        }
    }
    }
