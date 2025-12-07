using Tyuiu.SlokvaGA.Sprint6.Task7.V11.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string testFile = @"TestMatrix.csv";

            File.WriteAllText(testFile,
                "1;4;18;17;2;13;14;-14;1;-18\n" +
                "-15;18;7;-3;-3;-6;-1;-17;18;-18\n" +
                "10;-15;2;-2;-8;-16;1;3;-2;-13\n" +
                "-4;-7;13;-7;-11;11;7;-20;-10;-16\n" +
                "14;-8;-2;20;5;0;5;1;-6;-17\n" +
                "10;12;-1;8;2;3;15;-17;4;-4\n" +
                "8;-19;0;20;1;-9;10;7;2;1\n" +
                "-14;-15;6;1;-11;-9;11;13;0;13\n" +
                "-14;16;-6;5;11;-1;-11;-6;5;-7\n" +
                "-17;17;-8;-20;5;12;20;13;-7;15");

            try
            {
                int[,] matrix = ds.GetMatrix(testFile);
                for (int j = 0; j < 10; j++)
                    if (matrix[4, j] < 0) Assert.AreEqual(9, matrix[4, j]);
            }
            finally
            {
                if (File.Exists(testFile)) File.Delete(testFile);
            }
        }
    }
}
