using Tyuiu.SlokvaGA.Sprint6.Task5.V29.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Files\InPutDataFileTask5V29.txt";

            Assert.IsTrue(File.Exists(path));

            DataService ds = new DataService();
            double[] res = ds.LoadFromDataFile(path);

            double[] waitArray = { 12.000, 12.890, 35.000, 13.830, 12.760 };

            CollectionAssert.AreEqual(waitArray, res);
        }
    }
}
