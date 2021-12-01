using System;

namespace Laba4._1
{
    class Program
    {
        private static double A, B;
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("          MENU            ");
                Console.WriteLine("1. Ввести A");
                Console.WriteLine("2. Ввести B");
                Console.WriteLine("3. Выполнить операцию «+»");
                Console.WriteLine("4. Выполнить операцию «-»");
                Console.WriteLine("5. Выполнить операцию «*»");
                Console.WriteLine("6. Выполнить операцию «/»");
                Console.WriteLine("Выберите пункт меню");
                char ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case '1':
                        InputA(Console.ReadLine());
                        break;
                    case '2':
                        InputB(Console.ReadLine());
                        break;
                    case '3':
                        Plus(A, B);
                        break;
                    case '4':
                        Minus(A, B);
                        break;
                    case '5':
                        Mult(A, B);
                        break;
                    case '6':
                        Del(A, B);
                        break;
                    default:
                        Console.WriteLine("Произошла ошибка, введите заного");
                        break;
                }
            }
            
            static void InputA(string input)
            {


                A = double.Parse(input);


            }
            static void InputB(string input)
            {


                B = double.Parse(input);


            }
            static void Plus(double a, double b) => Console.WriteLine(a + b);

            static void Minus(double a, double b) => Console.WriteLine(a - b);

            static void Mult(double a, double b) => Console.WriteLine(a * b);

            static void Del(double a, double b) => Console.WriteLine(a / b);
        }
    }
}
