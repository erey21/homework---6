using System;

namespace homework___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание № 6");
            Console.WriteLine("Введите номер операции: \n1. Сложение \n2. Вычитание \n3. Умножение");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input) {
                case 1:
                    Console.WriteLine("Сложение");
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    break;
                default:
                    Console.WriteLine("Операция не определена");
                    break;
            }
        }
    }
}
