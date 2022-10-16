using MyRomanizingLibrary;

namespace SpecFlowRomanizingSteps.Specs.StepDefinitions
{
    [Binding]
    public sealed class RomanizingSteps
    {

        private readonly ScenarioContext _scenarioContext;
        private Romanizer _romanizer = new Romanizer();

        public RomanizingSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given(@"input of (.*)")]
        public void GivenInputOf(int p0)
        {
            _romanizer.Number = p0;
        }

        [When(@"converted to Roman numerals")]
        public void WhenConvertedToRomanNumerals()
        {
            _romanizer.Convert();
            
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string numeral)
        {
            _romanizer.Numeral.Should().Be(numeral);
        }

    }
}