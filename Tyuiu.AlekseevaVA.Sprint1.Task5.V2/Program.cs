using System;
using Tyuiu.AlekseevaVA.Sprint1.Task5.V2.Lib;


namespace Tyuiu.AlekseevaVA.Sprint1.Task5.V2
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
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнила: Алексеева В. А. | ИИПб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая рещает следующую задачу : Дано значение     *");
            Console.WriteLine("* температуры в градусах Фаренгейта. Определить значение этой же          *");
            Console.WriteLine("* температуры в градусах Цельсия.                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            Console.WriteLine("Введите Temp:");
            double temp = Convert.ToDouble(Console.ReadLine());
          

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
            Console.WriteLine(res);

            Console.ReadKey();
        }

    }
}
