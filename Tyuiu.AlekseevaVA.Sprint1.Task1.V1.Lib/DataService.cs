using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlekseevaVA.Sprint1.Task1.V1.Lib
{
    public class DataService : ISprint1Task1V1
    {
        public double Calculate(double a, double x, double y)
        {

            double result =  x / 3 / y + 6 * a;
            return Math.Round(result, 2);
        }
    }
}
