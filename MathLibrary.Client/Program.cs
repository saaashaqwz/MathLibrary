using MathLibrary;

namespace MathLibrary.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрация работы ===\n");

            double a = 2, b = 5, c = 2, number = 4, power = 2;
            int facNumber = 2;

            Console.WriteLine($"Сложение {a} + {b} = {Calculator.Add(a, b)}");
            Console.WriteLine($"Вычитание {a} - {b} = {Calculator.Subtract(a, b)}");
            Console.WriteLine($"Умножение {a} * {b} = {Calculator.Multiply(a, b)}");
            Console.WriteLine($"Деление {a} / {b} = {Calculator.Divide(a, b)}");
            Console.WriteLine($"{number} возводится в(во) {power} = {Calculator.Power(number, power)}");
            Console.WriteLine($"Факториал числа {facNumber} = {Calculator.Factorial(facNumber)}");
            
            try
            {
                Calculator.Divide(a, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.WriteLine("\n === Проверка на простые числа ===");
            int[] numbers = { 1, 13, 27, 31, 48 };

            foreach (int num in numbers)
            {
                bool isPrime = Calculator.IsPrime(num);
                Console.WriteLine($"Число {num} простое? - {isPrime}");
            }
            
            Console.WriteLine("\n === Решение квадратных уравнений ===");
            
            //два корня
            double a1 = 1, b1 = -3, c1 = 2;
            double? x1_1, x2_1;
            bool hasSolution1 = Calculator.SolveQuadratic(a1, b1, c1, out x1_1, out x2_1);
            Console.WriteLine($"Уравнение: {a1}x² + {b1}x + {c1} = 0");
            if (hasSolution1)
            {
                Console.WriteLine($"Корни: x1 = {x1_1}, x2 = {x2_1}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }

            //один корень
            double a2 = 1, b2 = -2, c2 = 1;
            double? x1_2, x2_2;
            bool hasSolution2 = Calculator.SolveQuadratic(a2, b2, c2, out x1_2, out x2_2);
            Console.WriteLine($"\nУравнение: {a2}x² + {b2}x + {c2} = 0");
            if (hasSolution2)
            {
                Console.WriteLine($"Корень: x = {x1_2} (кратность 2)");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }

            //нет корней
            double a3 = 1, b3 = 0, c3 = 1;
            double? x1_3, x2_3;
            bool hasSolution3 = Calculator.SolveQuadratic(a3, b3, c3, out x1_3, out x2_3);
            Console.WriteLine($"\nУравнение: {a3}x² + {b3}x + {c3} = 0");
            if (hasSolution3)
            {
                Console.WriteLine($"Корни: x1 = {x1_3}, x2 = {x2_3}");
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
            }

            //линейное уравнение
            double a4 = 0, b4 = 2, c4 = -4;
            double? x1_4, x2_4;
            bool hasSolution4 = Calculator.SolveQuadratic(a4, b4, c4, out x1_4, out x2_4);
            Console.WriteLine($"\nУравнение: {b4}x + {c4} = 0");
            if (hasSolution4)
            {
                Console.WriteLine($"Корень: x = {x1_4}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }
        }
    }
}