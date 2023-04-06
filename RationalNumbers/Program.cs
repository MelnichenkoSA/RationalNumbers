using System;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("Введите числитель");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель");
            int y = int.Parse(Console.ReadLine());
            RationalNumbers a = new RationalNumbers(x, y);
            Console.WriteLine("Введите числитель");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите знаменатель");
            y = int.Parse(Console.ReadLine());
            RationalNumbers b = new RationalNumbers(x, y);

            while (true)
            {
                a.ToString();
                b.ToString();
                Console.WriteLine("Что вы хотите сделать?\n1)Сложение \n2)Вычитание \n3)Умножение \n4)Деление \n5)Первая больше второй \n6)Первая меньше второй \n7)Равны ли дроби \n8)Не равны ли дроби");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        RationalNumbers addition = a + b;
                        Console.WriteLine($"Результат сложения: {addition}\n");
                        continue;
                    case 2:
                        RationalNumbers substraction = a - b;
                        Console.WriteLine($"Результат вычитания: {substraction}\n");
                        continue;
                    case 3:
                        RationalNumbers multiplication = a * b;
                        Console.WriteLine($"Результат умножения: {multiplication}\n");
                        continue;
                    case 4:
                        RationalNumbers division = a / b;
                        Console.WriteLine($"Результат деления: {division}\n");
                        continue;
                    case 5:
                        bool isGreater = a > b;
                        Console.WriteLine($"Первая дробь больше второй? {isGreater}\n");
                        continue;
                    case 6:
                        bool isLess = a < b;
                        Console.WriteLine($"Первая дробь меньше второй? {isLess}\n");
                        continue;
                    case 7:
                        bool isEquals = a == b;
                        Console.WriteLine($"Обе дроби равны? {isEquals}\n");
                        continue;
                    case 8:
                        bool isNotEquals = a != b;
                        Console.WriteLine($"Обе дроби не равны? {isNotEquals}\n");
                        continue;
                    default:
                        break;
                }
                break;
            }

        }
    }
}
