using System.Configuration;

namespace SpecflowExcerciseSelenium.Pages
{
    [Binding]
    public class BasePage
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        private static double timeout = Convert.ToDouble(ConfigurationManager.AppSettings["timeout"]);

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
        }
    }
}
