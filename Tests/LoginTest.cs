using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;


namespace OpenClosePrinciple.Tests
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver? driver;
        private LoginPage? loginPage;

        [SetUp]
        public void TestInitialize()
        {
            driver = new ChromeDriver();
            loginPage = new LoginPage(driver);
        }

        [Test]
        public void TestLogin() => driver?.Navigate().GoToUrl("https://www.ilabquality.com/");

        [TearDown]
        public void TestCleanup() => driver?.Quit();

    }
}
