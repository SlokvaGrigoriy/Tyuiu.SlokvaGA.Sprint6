using System.Text;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SlokvaGA.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            StringBuilder result = new StringBuilder();

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (word.IndexOf('n', System.StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            if (result.Length > 0)
                                result.Append(' ');
                            result.Append(word);
                        }
                    }
                }
            }
            return result.ToString();
        }
    }
}
