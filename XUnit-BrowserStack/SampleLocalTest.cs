using Xunit;
using OpenQA.Selenium.Remote;
using System.Text.RegularExpressions;

namespace XUnit_BrowserStack
{
    public class SampleLocalTest : IClassFixture<BaseFixture>
    {

        private readonly BaseFixture baseFixture;

        public SampleLocalTest(BaseFixture baseFixture)
        {
            this.baseFixture = baseFixture;
        }

        [Fact]
        [Trait("Category", "sample-local-test")]
        public void BStackLocalTest()
        {
            RemoteWebDriver driver = baseFixture.GetDriver("chrome", "local");
            driver.Navigate().GoToUrl("https://www.bentley.com/");
            Assert.Contains("Home | Bentley | Infrastructure Engineering Software", driver.Title);
        }
    }
}
