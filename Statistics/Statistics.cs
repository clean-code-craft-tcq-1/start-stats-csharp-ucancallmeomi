using System;
using System.Collections.Generic;

namespace Statistics
{
    public class StatsComputer
    {
        public double average;
        public double max;
        public double min;

        public class Stats
        {
            public double CalculateAvg(List<double> avgList)
            {

                double avg = 0;
                double sum = 0;

                foreach (double item in avgList)
                {
                    sum += item;
                }

                avg = sum / avgList.Count;

                return avg;
            }

            public double CalculateMin(List<double> minList)
            {
                double min;

                if (minList.Count > 0)
                {

                    min = minList[0];

                    foreach (double item in minList)
                    {
                        if (item < min)
                        {
                            min = item;
                        }

                    }

                }
                else
                {
                    min = Double.NaN;
                }

                return min;
            }

            public double CalculateMax(List<double> maxList)
            {
                double max;

                if (maxList.Count > 0)
                {

                    max = maxList[0];

                    foreach (double item in maxList)
                    {
                        if (item > max)
                        {
                            max = item;
                        }

                    }

                }
                else
                {
                    max = Double.NaN;
                }

                return max;
            }

        }


        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here

            Stats st = new Stats();
            average = st.CalculateAvg(numbers);
            min = st.CalculateMin(numbers);
            max = st.CalculateMax(numbers);

            return st;

        }
    }
}
