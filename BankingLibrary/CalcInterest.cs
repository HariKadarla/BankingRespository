using System;

namespace BankingLibrary
{
    public class CalcInterest : ICalcInterest
    {
        public int Calculate(int Principle, int RateOfInterest, int Years)
        {
            int SimpleInt = Principle * RateOfInterest * Years / 100;
            return SimpleInt;
        }
    }
}
