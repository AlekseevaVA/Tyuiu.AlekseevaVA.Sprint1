using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AlekseevaVA.Sprint1.Task3.V4.Lib
{
    public class DataService : ISprint1Task3V4
    {
        public double PurchaseAmount(double priceNotebook, double priceCover, int quantity)
        {
            double setPrice = priceNotebook + priceCover;
            double totalCost = setPrice * quantity;
            return Math.Round(totalCost, 3);
        }
    }
}
