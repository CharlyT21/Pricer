using System;
namespace Price
{
    public class Option
    {
        protected double spot;
        protected double strike;
        protected double maturity;
        protected double rate;
        protected double volatility;
        protected char callPut;

        public Option(double _spot, double _strike, double _maturity, double _rate, double _volatility, char _callPut)
        {
            spot = _spot;
            strike = _strike;
            maturity = _maturity;
            rate = _rate;
            volatility = _volatility;
            callPut = _callPut;
        }

        public double Spot { get { return spot; } }
        public double Strike { get { return strike; } }
        public double Maturity { get { return maturity; } }
        public double Rate { get { return rate; } }
        public double Volatility { get { return volatility; } }
        public char CallPut { get { return callPut; } }
    }
}
