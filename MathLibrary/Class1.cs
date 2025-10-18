namespace MathLibrary
{
    public class Calculator
    {
        //<summary>
        // сложение
        //</summary>
        public static double Add(double a, double b) =>  a + b;
        
        //<summary>
        // вычитание
        //</summary>
        public static double Subtract(double a, double b) =>  a - b;

        //<summary>
        // умножение
        //</summary>
        public static double Multiply(double a, double b) =>  a * b;

        //<summary>
        // деление
        //</summary>
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("На ноль делить нельзя");
            
            return a / b;
        }

        //<summary>
        // проверка простого числа
        //</summary>
        public static bool IsPrime(int number)
        {
            if (number < 2) return false;
            return true;
        }

        //<summary>
        // возведение в степень
        //</summary>
        public static double Power(double number, double power) => Math.Pow(number, power);

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
        
        //<summary>
        // вычисление площади круга
        //</summary>
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным", nameof(radius));
            
            return Math.PI * radius * radius;
        }

        //<summary>
        // конвертация температур
        //</summary>
        public static double ConvertTemperature(double value, string fromUnit, string toUnit)
        {
            if (string.IsNullOrWhiteSpace(fromUnit) || string.IsNullOrWhiteSpace(toUnit))
                throw new ArgumentException("Единицы измерения не могут быть пустыми");
            
            fromUnit = fromUnit.ToUpper();
            toUnit = toUnit.ToUpper();

            // цельсий в другие единицы
            if (fromUnit == "C")
            {
                return toUnit switch
                {
                    "F" => (value * 9 / 5) + 32,     // Цельсий в Фаренгейт
                    "C" => value,                    // Цельсий в Цельсий
                    _ => throw new ArgumentException($"Неподдерживаемая единица измерения: {toUnit}")
                };
            }
            // Фаренгейт в другие единицы
            else if (fromUnit == "F")
            {
                return toUnit switch
                {
                    "C" => (value - 32) * 5 / 9,     // Фаренгейт в Цельсий
                    "F" => value,                    // Фаренгейт в Фаренгейт
                    _ => throw new ArgumentException($"Неподдерживаемая единица измерения: {toUnit}")
                };
            }
            else
            {
                throw new ArgumentException($"Неподдерживаемая единица измерения: {fromUnit}");
            }
        }

        //<summary>
        // расчет гипотенузы прямоугольного треугольника
        //</summary>
        public static double CalculateHypotenuse(double a, double b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException("Длины катетов не могут быть отрицательными");
            
            return Math.Sqrt(a * a + b * b);
        }
    }
}