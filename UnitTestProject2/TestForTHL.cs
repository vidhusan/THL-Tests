using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestForTHL
{
    [TestClass]
    [TestCategory("Practice")]
    public class UnitTest1
    {
        private readonly IWebDriver driver = new ChromeDriver();

        
        [TestMethod]
        public void SearchMaui()
        {
            var GoogleHomePage = new GoogleHomePage(driver);
            GoogleHomePage.Open();
            GoogleHomePage.SearchItem("Maui");
            //Verify Mui home page link is listed in search results
            Assert.AreEqual("maui Motorhomes | Australasia's Largest Rental Vehicle Co.", GoogleHomePage.VerifyMuiLink());

            var MauiHomePage = GoogleHomePage.ClickMauiLink();
            //Verify Mui home page is loaded by checking the banner
            Assert.AreEqual("Book your motorhome here", MauiHomePage.HomePageBanner);
            GoogleHomePage.Close();
        }


        [TestMethod]
        public void SearchBritz()
        {
            var GoogleHomePage = new GoogleHomePage(driver);
            GoogleHomePage.Open();
            GoogleHomePage.SearchItem("Britz");
			//Verify Britz home page link is listed in search results
            Assert.AreEqual("Britz Campervans | Australasia's Largest Rental Vehicle Co.", GoogleHomePage.VerifyBritzLink());

            var BritzHomePage = GoogleHomePage.ClickBritzLink();
			//Verify Britz home page is loaded by checking the banner
            Assert.AreEqual("Welcome to Britz Campervans", BritzHomePage.HomePageBanner);
            GoogleHomePage.Close();
        }

        [TestMethod]
		public void GotoBritzAustralia()
        {
            var BritzHomePage = new BritzHomePage(driver);
            BritzHomePage.Open();
            var BritzAustralia = BritzHomePage.ClickOnBritzAustraliaLink();
            //Verify Britz Australia's home page is loaded by checking the banner
            Assert.AreEqual("Campervan Hire Australia", BritzAustralia.BritzHomePageBanner);
            BritzHomePage.Close();

        }

    }
}
