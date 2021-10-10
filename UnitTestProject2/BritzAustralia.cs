using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestForTHL
{
    internal class BritzAustralia
    {
        private IWebDriver Driver { get; set; }

        public BritzAustralia(IWebDriver driver)
        {
            Driver = driver;
        }

        public string BritzHomePageBanner
        {
            get
            {
                return Driver.FindElement(By.XPath("//div[@class='[ gutterPrimary ]']/h1[@class='[ bannerH1 ]']")).Text;
            }
            internal set { }
        }
    }
}