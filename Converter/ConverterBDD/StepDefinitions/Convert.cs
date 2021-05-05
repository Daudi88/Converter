using System;
using TechTalk.SpecFlow;

namespace ConverterBDD.StepDefinitions
{
    [Binding]
    public class Convert
    {
        [Given(@"that I need an American cup")]
        public void GivenThatINeedAnAmericanCup()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the decimals are rounded to (.*)")]
        public void GivenTheDecimalsAreRoundedTo(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the amount of cups is (.*)")]
        public void WhenTheAmountOfCupsIs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the Swedish amount is (.*) dl")]
        public void ThenTheSwedishAmountIsDl(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
