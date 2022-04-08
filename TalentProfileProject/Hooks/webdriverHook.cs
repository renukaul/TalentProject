using OpenQA.Selenium.Chrome;
using TalentProfileProject.Utilities;
using TechTalk.SpecFlow;

namespace TalentProfileProject.Hooks
{
    [Binding]
    public sealed class webdriverHook : CommonServices
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        //[BeforeScenario]
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Example of filtering hooks using tags. (in this case, this 'before scenario' hook will execute if the feature/scenario contains the tag '@tag1')
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=hooks#tag-scoping

            //TODO: implement logic that has to run before executing each scenario
            driver = new ChromeDriver();
            LoginPage();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
            driver.Close();
            driver.Quit();
        }


        

    }
}