using System;

namespace Лаб1Задание1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = -1; //объявление переменной А и присваивание ей значение (сторона треугольника)
            if (A >= 0)
            {
                double S = A * A * Math.Sqrt(3) / 4; //объявление переменной S
                double R = A * Math.Sqrt(3) / 3; //объявление переменной R

                Console.WriteLine("S = " + S); //вывод переменной S
                Console.WriteLine("R = " + R); //вывод переменной R
            }
            else
            {
                Console.WriteLine("ОШИБКА!!! Сторона треугольника не имеет право быть отрицательной!!!");
            }
            Console.Read();
        }
    }
}
