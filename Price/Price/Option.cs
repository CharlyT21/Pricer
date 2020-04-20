using System;
namespace Price
{
   public enum Callput
    {
        Call,
        Put
    }

    public class Option
    {
        public double Spot { get; set; }
        public double Strike { get; set; }
        public double Maturity { get; set; } 
        public double Rate { get; set; } 
        public double Volatility { get; set; }
        public Callput CallPut { get; set; }

        public Option(double _spot, double _strike, double _maturity, double _rate, double _volatility, Callput _callPut)
        {
            Spot = _spot;
            Strike = _strike;
            Maturity = _maturity;
            Rate = _rate;
            Volatility = _volatility;
            CallPut = _callPut;
        }

        public double Price()
        {
            return 0;
        }


    }
}
