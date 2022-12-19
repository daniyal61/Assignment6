using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Methods
    {
        public IWebDriver driver = new ChromeDriver();
        IWebElement element = null;
        public IWebElement Method1(string type, string value)
        {
            if (type == "xpath")
            {
                return element = driver.FindElement(By.XPath(value));
            }
            else if (type == "id")
            {
                return element = driver.FindElement(By.Id(value));
            }
            else if (type == "class")
            {
                return element = driver.FindElement(By.ClassName(value));
            }
            else if (type == "name")
            {
                return element = driver.FindElement(By.Name(value));
            }

            return element;
        }
    }
}
