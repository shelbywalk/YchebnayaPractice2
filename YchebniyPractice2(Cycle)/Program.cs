using System;

namespace YchebniyPractice2_Cycle_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Console.WriteLine("Задание 1");
            int n = 200;
            while (n % 17 != 0 || n <= 200)
            {
                n++;
            }
            Console.WriteLine(n);

            //Zadanie 2
            Console.WriteLine("Задание 2");
            double distance = 10;
            int d = 1;
            while (distance < 20)
            {
                distance *= 1.05;
                d++;
            }
            Console.WriteLine($"20км: {d}");
            distance = 10;
            d = 1;
            while (distance < 100)
            {
                distance *= 1.05;
                d++;
            }
            Console.WriteLine($"Сумма пробега 100 км: {d}");

            //Zadanie 3
            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите число факториала");
            int j = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= j; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"Факториал {j} равен {factorial}");

            //Zadanie 4
            Console.WriteLine("Задание 4");
            int a = 20;
            for (int i = 2; i <= a; i++)
            {
                if (n % i == 0)
                    Console.WriteLine("Делитель:" + i); ;
                break;
            }
        }
    }
}
