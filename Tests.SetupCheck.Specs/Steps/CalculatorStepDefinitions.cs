using TechTalk.SpecFlow;
using Tests.SetupCheck.SomeFunction;
using Xunit;

namespace Tests.SetupCheck.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _scenarioContext["Number1"] = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _scenarioContext["Number2"] = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var sut = new Calculator();
            _scenarioContext["Total"] = sut.AddTwoNumbers((int) _scenarioContext["Number1"], (int) _scenarioContext["Number2"]);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            int total = (int)_scenarioContext["Total"];

            Assert.Equal(result, total);
        }
    }
}
