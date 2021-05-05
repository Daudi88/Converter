using System;
using TechTalk.SpecFlow;
using FluentAssertions;

namespace DBB.StepDefinitions
{
    [Binding]
    public class ConvertSteps
    {
        Converter.Converter converter = new Converter.Converter();
        private double cup;
        private double dl;
        private int decimals;

        [Given(@"that I need (.*) American cups?")]
        public void GivenThatINeedAnAmericanCup(double p0)
        {
            cup = p0;
        }

        [Given(@"the decimals are rounded to (.*)")]
        public void GivenTheDecimalsAreRoundedTo(int p0)
        {
            decimals = p0;
        }

        [When(@"the amount of cups is (.*)")]
        public void WhenTheAmountOfCupsIs(double p0)
        {
            cup = p0;
            dl = converter.ConvertCupToDl(cup);
            dl = Math.Round(dl, decimals);
        }

        [Then(@"the Swedish amount is (.*) dl")]
        public void ThenTheSwedishAmountIsDl(double p0)
        {
            dl.Should().Be(p0);
        }
    }
}
