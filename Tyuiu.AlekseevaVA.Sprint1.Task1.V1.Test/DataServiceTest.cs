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
            double a = 3.0;
            double x = 10.0;
            double y = 2.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(19.666666666666668, res);

        }
    }
}
