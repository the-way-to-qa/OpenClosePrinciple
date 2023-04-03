using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Net.Http;
using TestReporter;

namespace OpenClosePrinciple.Tests
{
    [TestFixture]
    public class NavigationTests
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;

        private readonly TestReporter.TestReporter? testReporter;

        [SetUp]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void TestNavigateToHomePage() { 
            driver?.Navigate().GoToUrl("https://www.ilabquality.com/");
            testReporter?.LogScreenshot("Screenshot Captured!");
        }

        [TearDown]
        public void TestCleanup() => driver?.Quit();

    }
}
