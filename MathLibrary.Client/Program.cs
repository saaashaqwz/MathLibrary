using MathLibrary;

namespace MathLibrary.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрация работы ===\n");

            double a = 10, b = 4, number = 4, power = 2;
            int facNumber = 2;

            Console.WriteLine($"Сложение {a} + {b} = {Calculator.Add(a, b)}");
            Console.WriteLine($"Вычитание {a} - {b} = {Calculator.Subtract(a, b)}");
            Console.WriteLine($"Умножение {a} * {b} = {Calculator.Multiply(a, b)}");
            Console.WriteLine($"Деление {a} / {b} = {Calculator.Divide(a, b)}");

            try
            {
                Calculator.Divide(a, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.WriteLine("\n === Проверка на простые числа ===");
            int[] numbers = { 1, 13, 27, 31, 48, 56, 65 };

            foreach (int num in numbers)
            {
                bool isPrime = Calculator.IsPrime(num);
                Console.WriteLine($"Число {num} простое? - {isPrime}");
            }
        }
    }
}