using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = Math.Cos(x) + x;

                if (Math.Abs(denominator) < 0.0000001)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double result = (2 * x + 6) / denominator - 3;
                    valueArray[i] = Math.Round(result, 2);
                }
            }
            return valueArray;
        }
    }
}