using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            int[,] sortmas = (int[,])matrix.Clone();

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    if (sortmas[j, 3] > sortmas[j + 1, 3])
                    {
                        for (int k = 0; k < columns; k++)
                        {
                            int temp = sortmas[j, k];
                            sortmas[j, k] = sortmas[j + 1, k];
                            sortmas[j + 1, k] = temp;
                        }
                    }
                }
            }

            return sortmas;
        }
    }
}
