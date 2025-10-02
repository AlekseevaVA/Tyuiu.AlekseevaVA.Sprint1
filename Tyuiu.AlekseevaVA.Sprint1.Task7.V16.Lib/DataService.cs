using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlekseevaVA.Sprint1.Task7.V16.Lib
{
    public class DataService : ISprint1Task7V16
    {
        public double Calculate(double x)
        {
            return Math.Round(Math.Sin(Math.Abs(x)) + Math.Cos(x * x) / (3 * x * x * x) - Math.Sin(Math.Sqrt(x * x - 1)), 3);


        }


    }
    
}
    
