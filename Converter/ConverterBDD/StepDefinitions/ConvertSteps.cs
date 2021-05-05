using System;
using TechTalk.SpecFlow;

namespace ConverterBDD.StepDefinitions
{
    [Binding]
    public class ConvertSteps
    {
        [Given(@"that I need an American cup")]
        public void GivenThatINeedAnAmericanCup()
        {
        }
        
        [Given(@"the decimals are rounded to (.*)")]
        public void GivenTheDecimalsAreRoundedTo(int p0)
        {
        }
        
        [When(@"the amount of cups is (.*)")]
        public void WhenTheAmountOfCupsIs(int p0)
        {
        }
        
        [Then(@"the Swedish amount is (.*) dl")]
        public void ThenTheSwedishAmountIsDl(Decimal p0)
        {
        }
    }
}
