using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class EmailAlert : IAlerter
    {

        public bool emailSent = false;

        public void Alert()
        {

            Console.WriteLine("Email Sent");
            emailSent = true;
        }

    }
}
