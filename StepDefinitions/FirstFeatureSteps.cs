using TechTalk.SpecFlow;
using Xunit;
using Xunit.Abstractions;

namespace specflow.vscode
{
    [Binding]
    public class FirstFeatureSteps
    {
        private readonly ITestOutputHelper _output;

        private FirstFeatureSteps(ITestOutputHelper output)
        {
            _output = output;
        }

        [Given(@"a gherkin test")]
        public void GivenAGherkinTest()
        {
            _output.WriteLine("in the given step");
        }

        [When(@"the test is run in vscode")]
        public void WhenTheTestIsRunInVscode()
        {
            _output.WriteLine("in the when step");
        }

        [Then(@"the test result is (.*)")]
        public void ThenTheTestResultIsARealResult(string result)
        {
            _output.WriteLine("in the then step");
            if(result == "pass"){
                Assert.True(true);
            }
            else if(result == "fail"){
                Assert.True(false);
            }
            else {
                Assert.Equal("True or false", result);
            }
            // Assert.True(true);
        }
    }
}