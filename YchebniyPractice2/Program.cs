using System;

namespace YchebniyPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1

            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите число:");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                a += 5;
            }
            else if (a < 0)
            {
                a -= 5;
            }
            Console.WriteLine($"Результат: {a}");

            //Zadanie 2

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите три числа:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int b3 = Convert.ToInt32(Console.ReadLine());
            int maxNumber = b1;
            if (b2 > maxNumber)
            {
                maxNumber = b2;
            }
            if (b3 > maxNumber)
            {
                maxNumber = b3;
            }
            Console.WriteLine($"Наибольшее число:{maxNumber}");

            //Zadanie 3

            Console.WriteLine("Задание 3");
            Console.WriteLine("Введите три числа:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number1 > 0)
            {
                sum += number1;
            }
            if (number2 > 0)
            {
                sum += number2;
            }
            if (number3 > 0)
            {
                sum += number3;
            }
            Console.WriteLine($"Сумма положительных чисел: {sum}");

            //Zadanie 4

            Console.WriteLine("Задание 4");
            Console.Write("Введите число:");
            int x = int.Parse(Console.ReadLine());
            if (x > 10)
            {
                x *= 2;
            }
            Console.WriteLine($"Результат: {x}");

            //Zadanie 5
            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите число от 1 до 7");
            int dayNumber = int.Parse(Console.ReadLine());
            switch(dayNumber)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Неверный номер");
                    break;

            }
        }

    }
}
