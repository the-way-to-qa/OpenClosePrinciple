using OpenQA.Selenium;


namespace OpenClosePrinciple.PageObjects
{
    public class BasePageObject
    {
        protected IWebDriver? driver;
        public BasePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Click(By locator)
        {
            driver?.FindElement(locator).Click();
        }

        public void FillTextBox(By locator, string text)
        {
            driver?.FindElement(locator).SendKeys(text);
        }

        public void Type(By locator, string text) { 
            driver?.FindElement(locator)?.SendKeys(text);
        }
    }
}