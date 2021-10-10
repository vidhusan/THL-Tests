using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestForTHL
{
    internal class BritzHomePage
    {
        private IWebDriver Driver { get; set; }

        public BritzHomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public string HomePageBanner
        {
            get
            {
                return Driver.FindElement(By.XPath("//div[@class='[ gutterPrimary ]']/h1[@class='[ bannerH1 ]']")).Text;
            }
            internal set { }
        }

        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://www.britz.com/");
        }

        internal BritzAustralia ClickOnBritzAustraliaLink()
        {
            Driver.FindElement(By.LinkText("Britz Australia")).Click();
            return new BritzAustralia(Driver);
        }
        internal void Close()
        {
            Driver.Quit();
        }

        internal void BookButtonClick()
        {
            Driver.FindElement(By.XPath("//button/span[contains(text(), 'Book')]")).Click();
            //Driver.FindElement(By.XPath("//button[@data-toggle='bookingComponentAlt']/svg")).Click();
        }
    }
}