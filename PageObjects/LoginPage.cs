using OpenQA.Selenium;
using OpenClosePrinciple.PageObjects;

public class LoginPage : BasePageObject
{
    public LoginPage(IWebDriver driver) : base(driver) { }


    public void Login(string username, string password)
    {
        FillTextBox(By.Id("username"), username);
        FillTextBox(By.Id("password"), password);
        Click(By.Id("login"));
    }
}

