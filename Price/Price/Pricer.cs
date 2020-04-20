using System;
namespace Price
{
    public class Pricer
    {
        protected IOption option;

        public Pricer(IOption _option)
        {
            option = _option;
        }

        public double BlackScholes()
        {
            double price = 0;
            double S = option.Spot;
            double K = option.Strike;
            double T = option.Maturity;
            double r = option.Rate;
            double v = option.Volatility;

            double d1 = (Math.Log(S / K) + (r + v * v / 2.0) * T) / (v * Math.Sqrt(T));
            double d2 = d1 - v * Math.Sqrt(T);

            switch (option.CallPut)
            {
                case Callput.Call:
                    price = S * CND(d1) - K * Math.Exp(-r * T) * CND(d2);
                    Console.WriteLine(" BnS Call price = " + price);
                    return price;

                case Callput.Put:
                    price = (K * Math.Exp(-r * T) * CND(-d2)) - (S * CND(-d1));
                    Console.WriteLine(" BnS Put price = " + price);
                    return price;
            }
            Console.WriteLine("Error");
            return 0;
        }

        private double CND(double X)
        {
            double L = 0.0;
            double K = 0.0;
            double dCND = 0.0;
            const double a1 = 0.31938153;
            const double a2 = -0.356563782;
            const double a3 = 1.781477937;
            const double a4 = -1.821255978;
            const double a5 = 1.330274429;
            L = Math.Abs(X);
            K = 1.0 / (1.0 + 0.2316419 * L);
            dCND = 1.0 - 1.0 / Math.Sqrt(2 * Convert.ToDouble(Math.PI.ToString())) *
                Math.Exp(-L * L / 2.0) * (a1 * K + a2 * K * K + a3 * Math.Pow(K, 3.0) +
                a4 * Math.Pow(K, 4.0) + a5 * Math.Pow(K, 5.0));

            if (X < 0)
            {
                return 1.0 - dCND;
            }
            else
            {
                return dCND;
            }
        }
    }
}
