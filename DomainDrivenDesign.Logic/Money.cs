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

        public Money(int fiftyCents, int oneRands, int twoRands, int fiveRands, int tenRands, int twentyRands, int fiftyRands)
        {
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
    }
}
