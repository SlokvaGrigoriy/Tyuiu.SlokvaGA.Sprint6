using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                valueArray[i] = Math.Round(((2 * x - 3) / (Math.Cos(x)+x)) + 5, 2);
            }
            return valueArray;
        }
    }
}
