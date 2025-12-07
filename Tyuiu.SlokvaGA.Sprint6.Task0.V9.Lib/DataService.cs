using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task0.V9.Lib
{
    public class DataService : ISprint6Task0V9
    {
        public double Calculate(int x)
        {
            double var = 3;
            return Math.Round((4 - Math.Pow(var, 3))/Math.Pow(var, 2), 3);
        }
    }
}
