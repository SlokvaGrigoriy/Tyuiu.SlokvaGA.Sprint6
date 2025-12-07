using Tyuiu.SlokvaGA.Sprint6.Task6.V4.Lib;

namespace Tyuiu.SlokvaGA.Sprint6.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\Files\InPutDataFileTask6V4.txt";
            File.WriteAllText(path, "SnBC dYG\nnnndrM zLfkixV\nuHV RbvnKtNW");
            Assert.AreEqual("SnBC nnndrM RbvnKtNW", ds.CollectTextFromFile(path));
        }
    }
}
