namespace MathLibrary
{
    public class Calculator
    {
        //<summary>
        // сложение
        //</summary>
        public static double Add(double a, double b)
        {
            return a + b;
        }

        //<summary>
        // вычитание
        //</summary>
        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        //<summary>
        // умножение
        //</summary>
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        //<summary>
        // деление
        //</summary>
        public static double Divide(double a, double b)
        {
            if(b == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            else
                return a / b;
        }

        //<summary>
        // проверка простого числа
        //</summary>
        public static bool IsPrime(int number)
        {
            if(number < 2)
                return false;
            else
                return true;
        }

        //<summary>
        // возведение в степень
        //</summary>
        public static double Power(double number, double power)
        {
            return Math.Pow(number, power);
        }

        //<summary>
        // вычисление факториала
        //</summary>
        public static int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал определен только для неотрицательных чисел", nameof(n));
            else if(n == 0)
                return 0;
            else
                return n * (n - 1);
        }

        //<summary>
        // решение квадратного уравнения
        //</summary>
        public static bool SolveQuadratic(double a, double b, double c, out double? x1, out double? x2)
        {
            x1 = null;
            x2 = null;

            //проверка на линейное уравнение
            if (a == 0)
            {
                if (b == 0)
                {
                    return c == 0; 
                }
        
                x1 = -c / b;
                return true;
            }

            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                //корней нет
                return false;
            }
            else if (discriminant == 0)
            {
                //один корень
                x1 = -b / (2 * a);
                x2 = x1;
                return true;
            }
            else
            {
                //два корня
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                x1 = (-b - sqrtDiscriminant) / (2 * a);
                x2 = (-b + sqrtDiscriminant) / (2 * a);
                return true;
            }
        }
    }
}




