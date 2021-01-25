using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows = false;

        public void Alert()
        {
            Console.WriteLine("LED started glowing");
            ledGlows = true;
        }

    }
}
