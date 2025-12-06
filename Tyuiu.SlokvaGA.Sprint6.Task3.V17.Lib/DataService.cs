using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] res = (int[,])matrix.Clone();

            int[] column4 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                column4[i] = res[i, 3];
            }

            Array.Sort(column4);

            for (int i = 0; i < 3; i++)
            {
                res[i, 3] = column4[i];
            }

            return res;
        }
    }
}
