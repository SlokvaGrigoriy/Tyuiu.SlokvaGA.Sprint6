using Tyuiu.SlokvaGA.Sprint6.Task3.V17.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas = new int[5, 5] { { 22, 32, -16, 24, 27 },
                                          { 3, -20, 24, -20, 25 },
                                          { 21, 17, -8, -19, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };
            int[,] res = ds.Calculate(mas);
            
            int[,] wait = new int[5, 5] { { 22, 32, -16, -20, 27 },
                                          { 3, -20, 24, -19, 25 },
                                          { 21, 17, -8, 24, 17 },
                                          { 8, 22, 28, 27, 19 },
                                          { 11, 20, 12, 27, 29 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
