using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = 2 * x - 0.5;

                if (denominator == 0)
                {
                    valueArray[i] = 0;
                }
                else
                {
                    double result = 5 - 3 * x + (1 + Math.Sin(x)) / denominator;
                    valueArray[i] = Math.Round(result, 2);
                }
            }
            return valueArray;
        }
    }
}
