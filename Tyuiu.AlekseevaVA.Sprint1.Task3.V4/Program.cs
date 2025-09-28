using Tyuiu.AlekseevaVA.Sprint1.Task3.V4.Lib;


namespace Tyuiu.AlekseevaVA.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Алексеева В. А. | ИИПб-25-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя искодные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook = 2.75;
            double priceCover = 0.5;
            int quantity = 7;
            
            Console.WriteLine("Цена тетради = " + priceNotebook);
            Console.WriteLine("Цена обложки = " + priceCover);
            Console.WriteLine("Количество комплектов = " + quantity);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double totalCost = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Console.WriteLine("Стоимость покупки = " + totalCost);
            Console.ReadLine();
        }
    }

}

