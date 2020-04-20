using System;

namespace Price
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Option opt1 = new Option(100.0, 105.0, 1.0, 0.05, 0.15, Callput.Call);
            Pricer pricer = new Pricer(opt1);
            pricer.BlackScholes();
        }
    }
}
