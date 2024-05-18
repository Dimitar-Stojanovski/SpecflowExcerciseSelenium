
using SpecflowExcerciseSelenium.Support;

namespace SpecflowExcerciseSelenium.Pages
{
    [Binding]
    public class WebTablesPage:BasePage
    {
        private By addNewRecordBtn => By.Id("addNewRecordButton");
        private By _firstNameInput => By.Id("firstName");
        private By _lastNameInput => By.Id("lastName");
        private By _emailInput => By.Id("userEmail");
        private By _ageInput => By.Id("age");
        private By _salaryInput => By.Id("salary");
        private By _departmentInput => By.Id("department");
        
        private By _submitButton = By.CssSelector("#submit");




        public WebTablesPage(IWebDriver driver) : base(driver) => this.driver = driver;

        public void ClickAddButton()
        {
            wait.Until(x => x.FindElement(addNewRecordBtn));
            driver.FindElement(addNewRecordBtn).Click();
            
        }

        public void NavigateToUrl() => driver.Navigate().GoToUrl($"{Globals.URL}/webtables");
       
        public void EnterFirstName(string firstName) => driver.FindElement(_firstNameInput).SendKeys(firstName);
        
        public void EnterLastName(string lastname) => driver.FindElement(_lastNameInput).SendKeys(lastname);

        public void EnterEmail(string email) => driver.FindElement(_emailInput).SendKeys(email);

        public void EnterAge(int age) => driver.FindElement(_ageInput).SendKeys(age.ToString());

        public void EnterSalary(int salary) => driver.FindElement(_salaryInput).SendKeys(salary.ToString());
       
        public void EnterDepartment(string department) => driver.FindElement(_departmentInput).SendKeys(department);

        public void ClickSubmitButton() => driver.FindElement(_submitButton).Click();



        public IEnumerable<string> GetRecordsFromTable()
            => driver.FindElements(By.XPath("//div[@class='rt-tbody']/div/div/div")).Select(x => x.Text);

    }
}
