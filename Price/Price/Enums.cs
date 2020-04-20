using System;
namespace Price
{
    public static class Enums
    {
        public static enum OptionType
        {
            Call,
            Put
        }

        public static enum Engine
        {
            BlackScholes,
            MonteCarlo
        }
    }
}
