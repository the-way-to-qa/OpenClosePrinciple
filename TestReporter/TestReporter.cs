using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestReporter
{
    public class TestReporter
    {
        private IWebDriver? driver;
        public TestReporter(IWebDriver driver) => this.driver = driver;

        public void LogScreenshot(string message)
        {
            if (driver == null)
            {
                throw new InvalidOperationException("Driver Object is null...try again.");
            }
            string screenshotName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss") + ".jpeg";
            string screenshotPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TestScreenshots", screenshotName);

            try
            {
                Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Jpeg);
                TestContext.AddTestAttachment(screenshotPath, message);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }

        [TestFixture]
        public class CaptureScreenShotTests
        {
            private IWebDriver? driver;
            private TestReporter? reporter;

            [SetUp]
            public void SetUp()
            {
                driver = new ChromeDriver();
                reporter = new TestReporter(driver);
            }
            [Test]
            public void GoToHomePageAndCaptureScreenshot()
            {
                driver?.Navigate().GoToUrl("https://ilabquality.com");
                reporter?.LogScreenshot("CAPTURED!");
                driver?.Quit();

            }
        }
        
        

    }
}
