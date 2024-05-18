using OpenQA.Selenium;
using SpecflowExcerciseSelenium.Pages;
using TechTalk.SpecFlow.Assist;

namespace SpecflowExcerciseSelenium.StepDefinitions
{
    [Binding]
    public class WebTablesStepDefinitions
    {
        private readonly IWebDriver driver;
        private WebTablesPage tablesPage;

        public WebTablesStepDefinitions( IWebDriver driver) 
        {

           
            this.driver = driver;
            tablesPage = new WebTablesPage(driver);
        }

        [Given(@"I navigate to the webtables URL")]
        public void GivenINavigateToTheWebtablesURL()
        {
            tablesPage.NavigateToUrl();
        }

        [Given(@"I click add button")]
        public void GivenIClickAddButton()
        {
            tablesPage.ClickAddButton();
            Thread.Sleep(3000);

        }

        [When(@"I enter all required inputs")]
        public void WhenIEnterAllRequiredInputs(Table table)
        {
            dynamic datas = table.CreateDynamicSet();
            foreach (var data in datas)
            {
                tablesPage.EnterFirstName(data.firstname);
                tablesPage.EnterLastName(data.lastname);
                tablesPage.EnterEmail(data.email);
                tablesPage.EnterAge(data.age);
                tablesPage.EnterSalary(data.salary);
                tablesPage.EnterDepartment(data.department);
                    
                           
                    
                          
            }
        }

        [When(@"I click submit button")]
        public void WhenIClickSubmitButton()
        {
           tablesPage.ClickSubmitButton();
        }

        [Then(@"I want to verify that the user is created")]
        public void ThenIWantToVerifyThatTheUserIsCreated()
        {
            tablesPage.GetRecordsFromTable().Should()
                 .Contain("John")
                 .And.Contain("Doe")
                 .And.Contain("john@mail.com")
                 .And.Contain("13")
                 .And.Contain("1500")
                 .And.Contain("Marketing")
                 .And.HaveCountGreaterThanOrEqualTo(3);
        }
    }
}
