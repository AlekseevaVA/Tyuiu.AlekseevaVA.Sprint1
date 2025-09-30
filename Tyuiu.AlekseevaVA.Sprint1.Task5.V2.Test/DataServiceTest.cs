using Tyuiu.AlekseevaVA.Sprint1.Task5.V2.Lib;

namespace Tyuiu.AlekseevaVA.Sprint1.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 100;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);
            
            int wait = 38; 
            int result = Convert.ToInt32(res);
            Assert.AreEqual(wait, result);
        }
    }
}
