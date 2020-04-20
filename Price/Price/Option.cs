using System;
namespace Price
{
    public class Option : IOption
    {
        public double Spot { get; set; }
        public double Strike { get; set; }
        public double Maturity { get; set; } 
        public double Rate { get; set; } 
        public double Volatility { get; set; }
        public Enums.OptionType Type { get; set; }
        public double Price {get;set;}

        public Option(double _spot, double _strike, double _maturity, double _rate, double _volatility, Enums.OptionType type)
        {
            Spot = _spot;
            Strike = _strike;
            Maturity = _maturity;
            Rate = _rate;
            Volatility = _volatility;
            Type = type;
        }

        public double Price()
        {
            return Price;
        }


    }
}
