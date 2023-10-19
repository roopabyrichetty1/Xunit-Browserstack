using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;

namespace XUnit_BrowserStack
{
    public class SampleTest : IClassFixture<BaseFixture>
    {

        private readonly BaseFixture baseFixture;

        public SampleTest(BaseFixture baseFixture)
        {
            this.baseFixture = baseFixture;
        }

        [Fact]
        [Trait("Category", "sample-test")]
        public void BStackSampleTest()
        {
            //RemoteWebDriver driver = baseFixture.GetDriver("chrome", "single");
            //WebDriverWait webDriverWait = new WebDriverWait(driver, TimeSpan.FromMilliseconds(2000));
            //driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("https://www.bentley.com/");
            //Assert.Equal("Home | Bentley | Infrastructure Engineering Software", driver.Title);
            ChromeOptions chromeOptions = new ChromeOptions();
            //chromeOptions.setCapabili("browserVersion", "74");
            //chromeOptions.setCapability("platformName", "Windows 10");
            WebDriver driver = new RemoteWebDriver(new Uri("http://www.myexamplebrowserstack.com"), chromeOptions);
            driver.Navigate().GoToUrl("https://www.bentley.com/");



        }
    }
}
