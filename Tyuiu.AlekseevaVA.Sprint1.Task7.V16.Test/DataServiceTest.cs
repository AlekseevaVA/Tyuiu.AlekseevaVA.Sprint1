using Tyuiu.AlekseevaVA.Sprint1.Task7.V16.Lib;

namespace Tyuiu.AlekseevaVA.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2; 
            double wait = -0.105;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);


        }
    }
}
