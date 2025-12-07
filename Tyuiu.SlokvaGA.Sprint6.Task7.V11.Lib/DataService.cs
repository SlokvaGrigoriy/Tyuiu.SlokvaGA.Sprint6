using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11.Lib
{
    public class DataService : ISprint6Task7V11
    {
        public int[,] GetMatrix(string path)
        {
            string[] allLines = File.ReadAllLines(path);

            var lines = allLines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

            int rows = lines.Length;

            int maxColumns = 0;
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries);
                if (values.Length > maxColumns)
                    maxColumns = values.Length;
            }

            int[,] matrix = new int[rows, maxColumns];

            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < maxColumns && j < values.Length; j++)
                {
                    if (!string.IsNullOrWhiteSpace(values[j]))
                    {
                        matrix[i, j] = int.Parse(values[j].Trim());
                        if (i == 4 && matrix[i, j] < 0)
                            matrix[i, j] = 9;
                    }
                }
            }
            return matrix;
        }
    }
}
