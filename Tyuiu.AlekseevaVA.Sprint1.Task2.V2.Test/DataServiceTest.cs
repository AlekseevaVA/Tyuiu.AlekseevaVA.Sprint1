using Tyuiu.AlekseevaVA.Sprint1.Task2.V2.Lib;

namespace Tyuiu.AlekseevaVA.Sprint1.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 180;
            var res = ds.ConvertAngleToRad(x);
            Assert.AreEqual(3.142, res);
        }
    }
}
