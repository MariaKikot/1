using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(); // программа, которая выбирает рандомный выбор
            int a = rnd.Next(0, 255); // первое число
            int b = rnd.Next(0, 255); // второе
            int c = rnd.Next(0, 255); // третье
            int d = rnd.Next(0, 255); // четвертое
            Console.WriteLine($"{a} {b} {c} {d}");// программа, которая выводит 4 раздомных числа через пробел
        }
    }
}

