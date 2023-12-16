using System;
using TechTalk.SpecFlow;

namespace PracTest
{
    [Binding]
    public class Feature1StepDefinitions
    {
        [Given(@"g(.*)")]
        public void GivenG(int p0)
        {
            //throw new PendingStepException();
        }

        [When(@"w(.*)")]
        public void WhenW(int p0)
        {
            //throw new PendingStepException();
        }

        [Then(@"t(.*)")]
        public void ThenT(int p0)
        {
            //throw new PendingStepException();
        }
    }
}
