using BoDi;
using SpecflowExcerciseSelenium.Drivers;

namespace SpecflowExcerciseSelenium.Support
{
    [Binding]
    public sealed class Hooks
    {
        private readonly ScenarioContext scenarioContext;
        private readonly IObjectContainer objectContainer;
        private IWebDriver? driver;
        public DriverFactory? driverFactory;
        

        public Hooks(ScenarioContext scenarioContext, IObjectContainer objectContainer)
        {
            this.scenarioContext = scenarioContext;
            this.objectContainer = objectContainer;
        }

        

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
            driverFactory = new DriverFactory();
            driver = driverFactory.DriverInitiate(BrowserTypes.Chrome);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Globals.URL);
            objectContainer.RegisterInstanceAs<IWebDriver>(driver);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver = objectContainer.Resolve<IWebDriver>();
            driver.Quit();
        }
    }
}