using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using static System.Collections.Specialized.BitVector32;

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

            IWebElement selectMenuDropdown = driver.FindElement(By.XPath("//div[@class=' css-1hwfws3']"));
            selectMenuDropdown.Click();

            IWebElement selectValue = driver.FindElement(By.XPath("//*[text()='Group 2, option 2']"));
            selectValue.Click();

            IWebElement selectOneDropdown = driver.FindElement(By.Id("selectOne"));
            selectOneDropdown.Click();
            IWebElement selectValueOneDropdown = driver.FindElement(By.XPath("//*[text()='Mr.']"));
            selectValueOneDropdown.Click();


            IWebElement selectOldStyle = driver.FindElement(By.Id("oldSelectMenu"));
            SelectElement DropDown = new SelectElement(selectOldStyle);
            //DropDown.SelectByValue("2");
            DropDown.SelectByText("Purple");

            IWebElement standardMultiSellect = driver.FindElement(By.Id("cars"));
            SelectElement DropDownAuto = new SelectElement(standardMultiSellect);
            //DropDown.SelectByValue("2");
            DropDownAuto.SelectByText("Opel");
            DropDownAuto.SelectByText("Audi");

            /*//nu imi iese Multiselect drop down
            IWebElement multiselectDropDown = driver.FindElement(By.XPath("//div[contains(@class, 'css-1hwfws3')]//div[contains(@class, 'placeholder') and text()='Select...']"));
            SelectElement multiDropDown = new SelectElement(multiselectDropDown);
            DropDown.SelectByValue("3");
            //multiDropDown.SelectByText("Black");*/

/*nu imi iese Multiselect drop down
IWebElement multiselect = driver.(By.XPath("//div[contains(@class, 'css-1hwfws3')]//div[contains(@class, 'placeholder') and text()='Select...']"));
 multiselect.SendKeys(Keys.ArrowDown);
 multiselect.SendKeys(Keys.Enter);*/










}
}
}
