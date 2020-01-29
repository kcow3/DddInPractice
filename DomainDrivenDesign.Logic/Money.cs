using System;

namespace DomainDrivenDesign.Logic
{
    public sealed class Money
    {
        public int FiftyCentCount { get; private set; }
        public int OneRandCount { get; private set; }
        public int TwoRandCount { get; private set; }
        public int FiveRandCount { get; private set; }
        public int TenRandCount { get; private set; }
        public int TwentyRandCount { get; private set; }
        public int FiftyRandCount { get; private set; }

        public decimal Amount => FiftyCentCount * 0.5m + OneRandCount * 1 + TwoRandCount * 2 + FiveRandCount * 5 + TenRandCount * 10 + TwentyRandCount * 20 + FiftyRandCount * 50;

        public Money(int fiftyCents, int oneRands, int twoRands, int fiveRands, int tenRands, int twentyRands, int fiftyRands)
        {
            if (fiftyCents < 0
                || oneRands < 0
                || twoRands < 0
                || fiveRands < 0
                || tenRands < 0
                || twentyRands < 0
                || fiftyRands < 0)
                throw new InvalidOperationException();

            FiftyCentCount = fiftyCents;
            OneRandCount = oneRands;
            TwoRandCount = twoRands;
            FiveRandCount = fiveRands;
            TenRandCount = tenRands;
            TwentyRandCount = twentyRands;
            FiftyRandCount = fiftyRands;
        }

        //Operator to add two money objects together.
        public static Money operator +(Money left, Money right)
        {
            Money sum = new Money
                (
                    left.FiftyCentCount + right.FiftyCentCount,
                    left.OneRandCount + right.OneRandCount,
                    left.TwoRandCount + right.TwoRandCount,
                    left.FiveRandCount + right.FiveRandCount,
                    left.TenRandCount + right.TenRandCount,
                    left.TwentyRandCount + right.TwentyRandCount,
                    left.FiftyRandCount + right.FiftyRandCount
                );
            return sum;
        }

        public static Money operator -(Money left, Money right)
        {
            Money sum = new Money
                (
                    left.FiftyCentCount - right.FiftyCentCount,
                    left.OneRandCount - right.OneRandCount,
                    left.TwoRandCount - right.TwoRandCount,
                    left.FiveRandCount - right.FiveRandCount,
                    left.TenRandCount - right.TenRandCount,
                    left.TwentyRandCount - right.TwentyRandCount,
                    left.FiftyRandCount - right.FiftyRandCount
                );
            return sum;
        }

    }
}
