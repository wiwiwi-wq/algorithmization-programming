1
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            double c = double.Parse(Console.ReadLine());

            SolveQuadraticEquation(a, b, c);
        }

        static void SolveQuadraticEquation(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни уравнения: x1 = {x1:F4}, x2 = {x2:F4}");
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Уравнение имеет один корень: x = {x:F4}");
            }
            else
            {
                Console.WriteLine("Уравнение не имеет вещественных корней.");
            }
        }
    }
}

2
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите цифру a: ");
            int a = int.Parse(Console.ReadLine());

            bool containsFive = ContainsDigit(number, 5);
            bool containsA = ContainsDigit(number, a);

            Console.WriteLine(containsFive ? "Цифра 5 входит в число." : "Цифра 5 не входит в число.");
            Console.WriteLine(containsA ? $"Цифра {a} входит в число." : $"Цифра {a} не входит в число.");
        }

        static bool ContainsDigit(int number, int digit)
        {
            return number.ToString().Contains(digit.ToString());
        }
    }
}

3
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двузначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool containsThreeAndSeven = ContainsDigits(number, new int[] { 3, 7 });
            bool containsFourEightNine = ContainsDigits(number, new int[] { 4, 8, 9 });

            Console.WriteLine(containsThreeAndSeven ? "Цифры 3 и 7 входят в число." : "Цифры 3 и 7 не входят в число.");
            Console.WriteLine(containsFourEightNine ? "Цифра 4, 8 или 9 входит в число." : "Цифр 4, 8 или 9 нет в числе.");
        }

        static bool ContainsDigits(int number, int[] digits)
        {
            string numberStr = number.ToString();
            foreach (int digit in digits)
            {
                if (!numberStr.Contains(digit.ToString()))
                    return false;
            }
            return true;
        }
    }
}

4
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 99: ");
            int number = int.Parse(Console.ReadLine());

            string kopecksForm = GetKopecksForm(number);
            Console.WriteLine($"{number} {kopecksForm}");
        }

        static string GetKopecksForm(int number)
        {
            int lastDigit = number % 10;
            int lastTwoDigits = number % 100;

            if (lastTwoDigits >= 11 && lastTwoDigits <= 19)
                return "копеек";
            else if (lastDigit == 1)
                return "копейка";
            else if (lastDigit >= 2 && lastDigit <= 4)
                return "копейки";
            else
                return "копеек";
        }
    }
}

5
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите четырёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPalindrome = IsPalindrome(number);
            Console.WriteLine(isPalindrome ? "Число является палиндромом." : "Число не является палиндромом.");
        }

        static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();
            return numberStr[0] == numberStr[3] && numberStr[1] == numberStr[2];
        }
    }
}

6
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите шестизначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool isLucky = IsLuckyNumber(number);
            Console.WriteLine(isLucky ? "Число является счастливым." : "Число не является счастливым.");
        }

        static bool IsLuckyNumber(int number)
        {
            string numberStr = number.ToString();
            int firstSum = numberStr[0] + numberStr[1] + numberStr[2];
            int secondSum = numberStr[3] + numberStr[4] + numberStr[5];

            return firstSum == secondSum;
        }
    }
}

7
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число от 1 до 365: ");
            int dayNumber = int.Parse(Console.ReadLine());

            string dayOfWeek = GetDayOfWeek(dayNumber);
            Console.WriteLine($"День недели: {dayOfWeek}");
        }

        static string GetDayOfWeek(int dayNumber)
        {
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            return daysOfWeek[(dayNumber - 1) % 7];
        }
    }
}

8
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите угол α в градусах: ");
            double alpha = double.Parse(Console.ReadLine()) * Math.PI / 180;
            Console.Write("Введите начальную скорость v0: ");
            double v0 = double.Parse(Console.ReadLine());
            Console.Write("Введите расстояние R: ");
            double R = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту цели h: ");
            double h = double.Parse(Console.ReadLine());

            bool isHit = IsTargetHit(alpha, v0, R, h);
            Console.WriteLine(isHit ? "Снаряд попадёт в цель." : "Снаряд не попадёт в цель.");
        }

        static bool IsTargetHit(double alpha, double v0, double R, double h)
        {
            double t = R / (v0 * Math.Cos(alpha));
            double y = v0 * t * Math.Sin(alpha) - 9.8 * t * t / 2;
            return Math.Abs(y - h) < 0.1;
        }
    }
}

9
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool isSumTwoDigit = IsSumTwoDigit(number);
            bool isProductThreeDigit = IsProductThreeDigit(number);

            Console.WriteLine(isSumTwoDigit ? "Сумма цифр является двузначным числом." : "Сумма цифр не является двузначным числом.");
            Console.WriteLine(isProductThreeDigit ? "Произведение цифр является трёхзначным числом." : "Произведение цифр не является трёхзначным числом.");
        }

        static bool IsSumTwoDigit(int number)
        {
            int sum = number / 100 + (number / 10) % 10 + number % 10;
            return sum >= 10 && sum <= 99;
        }

        static bool IsProductThreeDigit(int number)
        {
            int product = (number / 100) * ((number / 10) % 10) * (number % 10);
            return product >= 100 && product <= 999;
        }
    }
}

10
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());

            bool isProductGreaterThanB = IsProductGreaterThanB(number, b);
            bool isSumMultipleOfThree = IsSumMultipleOfThree(number);

            Console.WriteLine(isProductGreaterThanB ? "Произведение цифр больше числа b." : "Произведение цифр не больше числа b.");
            Console.WriteLine(isSumMultipleOfThree ? "Сумма цифр кратна трём." : "Сумма цифр не кратна трём.");
        }

        static bool IsProductGreaterThanB(int number, int b)
        {
            int product = (number / 100) * ((number / 10) % 10) * (number % 10);
            return product > b;
        }

        static bool IsSumMultipleOfThree(int number)
        {
            int sum = number / 100 + (number / 10) % 10 + number % 10;
            return sum % 3 == 0;
        }
    }
}

11
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool allDigitsSame = AllDigitsSame(number);
            bool hasSameDigits = HasSameDigits(number);

            Console.WriteLine(allDigitsSame ? "Все цифры одинаковые." : "Не все цифры одинаковые.");
            Console.WriteLine(hasSameDigits ? "Есть одинаковые цифры." : "Нет одинаковых цифр.");
        }

        static bool AllDigitsSame(int number)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;
            return firstDigit == secondDigit && secondDigit == thirdDigit;
        }

        static bool HasSameDigits(int number)
        {
            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;
            return firstDigit == secondDigit || firstDigit == thirdDigit || secondDigit == thirdDigit;
        }
    }
}

12
using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Введите координату y: ");
            double y = double.Parse(Console.ReadLine());

            bool isInArea = IsInArea(x, y);
            Console.WriteLine(isInArea ? "Точка лежит в области." : "Точка не лежит в области.");
        }

        static bool IsInArea(double x, double y)
        {
            return y <= 2 && y >= 2 - Math.Pow(x, 2);
        }
    }
}

13
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты точки A1:");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки A2:");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты точки A3:");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());

            bool canDrawPerpendicular = CanDrawPerpendicular(x1, y1, x2, y2, x3, y3);
            Console.WriteLine(canDrawPerpendicular ? "Можно провести перпендикулярную прямую через точку A3."
                                                    : "Нельзя провести перпендикулярную прямую через точку A3.");
        }

        static bool CanDrawPerpendicular(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            if ((x1 == x2) && (y1 == y2))
                return false;

            if (x1 == x2)
                return y3 != y1;

            if (y1 == y2)
                return x3 != x1;

            double k = (y2 - y1) / (x2 - x1);

            return true;
        }
    }
}

14
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите средний балл по диплому (от 3 до 5): ");
            double averageGrade = double.Parse(Console.ReadLine());

            Console.Write("Введите стаж работы по специальности (в годах): ");
            int experience = int.Parse(Console.ReadLine());

            double rating = CalculateRating(averageGrade, experience);
            Console.WriteLine($"Рейтинг: {rating:F2}");

            if (rating >= 45)
                Console.WriteLine("Вы приняты в магистратуру.");
            else
                Console.WriteLine("Вы не прошли по конкурсу.");
        }

        static double CalculateRating(double averageGrade, int experience)
        {
            double coefficient;
            if (experience < 2)
                coefficient = 1;
            else if (experience <= 5)
                coefficient = 1 + 0.1 * experience;
            else if (experience <= 16)
                coefficient = 1.5;
            else
                coefficient = 1.6;

            return averageGrade * coefficient;
        }
    }
}

15
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите координаты трёх вершин прямоугольника:");
            Console.Write("x1: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y1: ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("x2: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y2: ");
            int y2 = int.Parse(Console.ReadLine());

            Console.Write("x3: ");
            int x3 = int.Parse(Console.ReadLine());
            Console.Write("y3: ");
            int y3 = int.Parse(Console.ReadLine());

            FindFourthVertex(x1, y1, x2, y2, x3, y3);
        }

        static void FindFourthVertex(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            int x4, y4;

            if (x1 == x2)
                x4 = x3;
            else if (x1 == x3)
                x4 = x2;
            else
                x4 = x1;

            if (y1 == y2)
                y4 = y3;
            else if (y1 == y3)
                y4 = y2;
            else
                y4 = y1;

            Console.WriteLine($"Координаты четвёртой вершины: ({x4}, {y4})");
        }
    }
}

16
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четырёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            bool isSumEqual = IsSumEqual(number);
            bool isSumMultipleOfSeven = IsSumMultipleOfSeven(number);

            Console.WriteLine(isSumEqual ? "Сумма двух первых цифр равна сумме двух последних."
                                           : "Сумма двух первых цифр не равна сумме двух последних.");
            Console.WriteLine(isSumMultipleOfSeven ? "Сумма цифр кратна 7."
                                                   : "Сумма цифр не кратна 7.");
        }

        static bool IsSumEqual(int number)
        {
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            return (firstDigit + secondDigit) == (thirdDigit + fourthDigit);
        }

        static bool IsSumMultipleOfSeven(int number)
        {
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            int sum = firstDigit + secondDigit + thirdDigit + fourthDigit;
            return sum % 7 == 0;
        }
    }
}

17
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите четырёхзначное число: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Введите число a: ");
            int a = int.Parse(Console.ReadLine());

            bool isProductMultipleOfThree = IsProductMultipleOfThree(number);
            bool isAMultipleOfProduct = IsAMultipleOfProduct(number, a);

            Console.WriteLine(isProductMultipleOfThree ? "Произведение цифр кратно трём."
                                                         : "Произведение цифр не кратно трём.");
            Console.WriteLine(isAMultipleOfProduct ? $"Число {a} кратно произведению цифр."
                                                   : $"Число {a} не кратно произведению цифр.");
        }

        static bool IsProductMultipleOfThree(int number)
        {
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            int product = firstDigit * secondDigit * thirdDigit * fourthDigit;
            return product % 3 == 0;
        }

        static bool IsAMultipleOfProduct(int number, int a)
        {
            int firstDigit = number / 1000;
            int secondDigit = (number / 100) % 10;
            int thirdDigit = (number / 10) % 10;
            int fourthDigit = number % 10;

            int product = firstDigit * secondDigit * thirdDigit * fourthDigit;
            return product != 0 && a % product == 0;
        }
    }
}

18
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите сторону a первого прямоугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону b первого прямоугольника: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите сторону c второго прямоугольника: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Введите сторону d второго прямоугольника: ");
            double d = double.Parse(Console.ReadLine());

            bool canFit = CanFit(a, b, c, d);
            Console.WriteLine(canFit ? "Прямоугольник со сторонами a, b помещается в прямоугольник со сторонами c, d."
                                      : "Прямоугольник со сторонами a, b не помещается в прямоугольник со сторонами c, d.");
        }

        static bool CanFit(double a, double b, double c, double d)
        {
            return (a <= c && b <= d) || (a <= d && b <= c);
        }
    }

19
using System;

namespace ConsoleApp3
    {
        class Program
        {
            static void Main()
            {
                Console.Write("Введите размер a кирпича: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Введите размер b кирпича: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Введите размер c кирпича: ");
                double c = double.Parse(Console.ReadLine());

                Console.Write("Введите размер x отверстия: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Введите размер y отверстия: ");
                double y = double.Parse(Console.ReadLine());

                bool canFit = CanFit(a, b, c, x, y);
                Console.WriteLine(canFit ? "Кирпич пройдет в отверстие."
                                          : "Кирпич не пройдет в отверстие.");
            }

            static bool CanFit(double a, double b, double c, double x, double y)
            {
                return (a <= x && b <= y) || (a <= y && b <= x) ||
                       (a <= x && c <= y) || (a <= y && c <= x) ||
                       (b <= x && c <= y) || (b <= y && c <= x);
            }
        }
    }
}