using OpenQA.Selenium;

namespace TestForTHL
{
    internal class MuiHomePage
    {
        private IWebDriver Driver;

        public MuiHomePage(IWebDriver driver)
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
    }
}