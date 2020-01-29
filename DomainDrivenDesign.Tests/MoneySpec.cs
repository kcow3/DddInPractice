using DomainDrivenDesign.Logic;
using FluentAssertions;
using System;
using Xunit;

namespace DomainDrivenDesign.Tests
{
    public class MoneySpec
    {
        [Fact]
        public void SumOfTwoMoneyObjectsCorrect()
        {
            var m1 = new Money(1, 1, 1, 1, 1, 1, 1);
            var m2 = new Money(1, 1, 1, 1, 1, 1, 1);
            var sum = m1 + m2;

            sum.FiftyCentCount.Should().Be(2);
            sum.OneRandCount.Should().Be(2);
            sum.TwoRandCount.Should().Be(2);
            sum.FiftyRandCount.Should().Be(2);
            sum.TenRandCount.Should().Be(2);
            sum.TwentyRandCount.Should().Be(2);
            sum.FiftyRandCount.Should().Be(2);
        }

        [Theory]
        [InlineData(-1, 0, 0, 0, 0, 0, 0)]
        [InlineData(0, -1, 0, 0, 0, 0, 0)]
        [InlineData(0, 0, -1, 0, 0, 0, 0)]
        [InlineData(0, 0, 0, -1, 0, 0, 0)]
        [InlineData(0, 0, 0, 0, -1, 0, 0)]
        [InlineData(0, 0, 0, 0, 0, -1, 0)]
        [InlineData(0, 0, 0, 0, 0, 0, -1)]
        public void CannotCreateNagativeMoney(int FiftyCentCount, int OneRandCount, int TwoRandCount, int FiveRandCount, int TenRandCount, int TwentyRandCount, int FiftyRandCount)
        {
            Action action = () => new Money(FiftyCentCount, OneRandCount, TwoRandCount, FiveRandCount, TenRandCount, TwentyRandCount, FiftyRandCount);

            action.Should().Throw<InvalidOperationException>();
        }

        [Theory]
        [InlineData(0, 0, 0, 0, 0, 0, 0, 0)]
        [InlineData(1, 0, 0, 0, 0, 0, 0, 0.5)]
        [InlineData(0, 1, 0, 0, 0, 0, 0, 1)]
        [InlineData(0, 0, 1, 0, 0, 0, 0, 2)]
        [InlineData(0, 0, 0, 1, 0, 0, 0, 5)]
        [InlineData(0, 0, 0, 0, 1, 0, 0, 10)]
        [InlineData(0, 0, 0, 0, 0, 1, 0, 20)]
        [InlineData(0, 0, 0, 0, 0, 0, 1, 50)]
        public void CalculateMoneyAmountCorrectly(int FiftyCentCount, int OneRandCount, int TwoRandCount, int FiveRandCount, int TenRandCount, int TwentyRandCount, int FiftyRandCount, decimal sumExpected)
        {
            var m = new Money(FiftyCentCount, OneRandCount, TwoRandCount, FiveRandCount, TenRandCount, TwentyRandCount, FiftyRandCount);
            m.Amount.Should().Be(sumExpected);
        }

        [Fact]
        public void SubOfTwoMoneyObjectsCorrect()
        {
            var m1 = new Money(0, 0, 0, 0, 0, 0, 1); //50 - 20 = 30
            var m2 = new Money(0, 0, 0, 0, 0, 0, 2);

            var test = m2 - m1;
            test.Amount.Should().Be(50);
           
        }


    }
}
