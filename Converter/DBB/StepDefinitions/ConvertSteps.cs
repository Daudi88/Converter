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
        private double tabelSpoon;

        [Given(@"that the decimals are rounded to (.*)")]
        public void GivenThatTheDecimalsAreRoundedTo(int p0)
        [Given(@"that I need (.*) American cups?")]
        public void GivenThatINeedAnAmericanCup(double p0)
        {
            cup = p0;
        }

        [Given(@"that I need (.*) American tablespoons?")]
        public void GivenThatINeedAnAmericanTablespoons(double p0)
        {
            tableSpoon = p0;
        }

        [Given(@"the decimals are rounded to (.*)")]
        public void GivenTheDecimalsAreRoundedTo(int p0)
        {
            decimals = p0;
        }

        [When(@"the amount of cups are (.*)")]
        public void WhenTheAmountOfCupsAre(double p0)
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
