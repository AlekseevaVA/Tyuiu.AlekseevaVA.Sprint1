using Tyuiu.AlekseevaVA.Sprint1.Task1.V1.Lib;


namespace Tyuiu.AlekseevaVA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 9;
            double x = 2;
            double y = 1;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(54,67, res);

        }
    }
}
