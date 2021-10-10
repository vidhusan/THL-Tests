using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestForTHL
{
    public class GoogleHomePage
    {

        private IWebDriver Driver { get; set; }
        //public string MuiLink { get; private set; }

        public GoogleHomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        internal void Open()
        {
            Driver.Navigate().GoToUrl("http://www.google.co.nz");
        }

        internal void SearchItem(string keyword)
        {
            Driver.FindElement(By.Name("q")).SendKeys(keyword);
            Driver.FindElement(By.XPath("//div[@class='FPdoLc lJ9FBc']/center/input[@type='submit']")).Click();
            if (keyword == "Maui")
            {
                VerifyMuiLink();
            }
            if (keyword == "Britz")
            {
                VerifyBritzLink();
            }
        }

        internal MuiHomePage ClickMauiLink()
        {
            Driver.FindElement(By.XPath("//div[@class='tF2Cxc']/div[@class='yuRUbf']/a[@href='https://www.maui-rentals.com/']")).Click();
            return new MuiHomePage(Driver);

        }

        internal BritzHomePage ClickBritzLink()
        {
            Driver.FindElement(By.XPath("//div[@class='tF2Cxc']/div[@class='yuRUbf']/a[@href='https://www.britz.com/']")).Click();
            return new BritzHomePage(Driver);

        }
        public string VerifyMuiLink()
        {
          return Driver.FindElement(By.XPath("//div[@class='tF2Cxc']/div[@class='yuRUbf']/a[@href='https://www.maui-rentals.com/']/h3")).Text;
          
        }

        public string VerifyBritzLink()
        {
            return Driver.FindElement(By.XPath("//div[@class='tF2Cxc']/div[@class='yuRUbf']/a[@href='https://www.britz.com/']/h3")).Text;

        }
        internal void Close()
        {
            Driver.Quit();
        }
    }
}
