using Tyuiu.AlekseevaVA.Sprint1.Task4.V17.Lib;

namespace Tyuiu.AlekseevaVA.Sprint1.Task4.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 1;
            double wait = 0.447;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
