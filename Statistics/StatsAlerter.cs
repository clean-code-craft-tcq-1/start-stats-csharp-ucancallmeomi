using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics
{
    public class StatsAlerter 
    {
        private float maxThreshold;
        private IAlerter[] alerters;
        
        public StatsAlerter(float maxThreshold, IAlerter[] alerters)
        {
            this.maxThreshold = maxThreshold;
            this.alerters = alerters;

        }

        public void checkAndAlert(List<double> alertList)
        {
            EmailAlert em = (EmailAlert)alerters[0];
            LEDAlert ld = (LEDAlert)alerters[1];

            foreach (double item in alertList)
            {

                if (item > (double)maxThreshold)
                {
                    em.Alert();
                    ld.Alert();
                }
            }

        }

    }
}
