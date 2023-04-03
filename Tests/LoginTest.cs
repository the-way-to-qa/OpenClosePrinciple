using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class LoginTest
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [TestInitialize]
    public void TestInitialize()
    {
        driver = new ChromeDriver();
        loginPage = new LoginPage(driver);
    }

}
