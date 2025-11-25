//using System.Collections.ObjectModel;

//1
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 25, 50, 75, 100, 150 };

//        var result = numbers.Where(x => x > 50).ToList();

//        Console.WriteLine("Числа больше 50:");
//        Console.WriteLine(string.Join(", ", result));
//    }
//}

//2
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var even = numbers.Where(x => x % 2 == 0).ToList();

//        Console.WriteLine("Чётные числа:");
//        Console.WriteLine(string.Join(", ", even));
//    }
//}

//3
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] fruits = { "Apple", "Banana", "Apricot", "Orange", "Avocado" };

//        var startsWithA = fruits.Where(s => s.StartsWith("A")).ToList();

//        Console.WriteLine("Начинаются на A:");
//        Console.WriteLine(string.Join(", ", startsWithA));
//    }
//}

//4
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Анна", Age = 25 },
//            new Person { Name = "Борис", Age = 42 },
//            new Person { Name = "Вера", Age = 38 },
//            new Person { Name = "Глеб", Age = 19 }
//        };

//        var adults = people.Where(p => p.Age > 30).ToList();

//        Console.WriteLine("Старше 30 лет:");
//        foreach (var p in adults)
//            Console.WriteLine($"{p.Name} — {p.Age} лет");
//    }
//}

//5
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 4, 7, 12, 15, 23, 27, 30, 33 };

//        var divisibleBy3 = numbers.Where(x => x % 3 == 0).ToList();

//        Console.WriteLine("Делятся на 3:");
//        Console.WriteLine(string.Join(", ", divisibleBy3));
//    }
//}

//6
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public double AverageGrade { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иван", AverageGrade = 4.8 },
//            new Student { Name = "Мария", AverageGrade = 3.9 },
//            new Student { Name = "Пётр", AverageGrade = 5.0 },
//            new Student { Name = "Ольга", AverageGrade = 4.2 }
//        };

//        var excellent = students.Where(s => s.AverageGrade > 4.0).ToList();

//        Console.WriteLine("Средний балл > 4.0:");
//        foreach (var s in excellent)
//            Console.WriteLine($"{s.Name} — {s.AverageGrade}");
//    }
//}

//7
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "Hi", "Hello", "World", "Programming" };

//        var longWords = words.Where(w => w.Length > 5).ToList();

//        Console.WriteLine("Длиннее 5 символов:");
//        Console.WriteLine(string.Join(", ", longWords));
//    }
//}

//8
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Price = 85000 },
//            new Product { Name = "Наушники", Price = 350 },
//            new Product { Name = "Мышь", Price = 120 },
//            new Product { Name = "Клавиатура", Price = 450 }
//        };

//        var midPrice = products.Where(p => p.Price >= 100 && p.Price <= 500).ToList();

//        Console.WriteLine("Товары 100–500 руб:");
//        foreach (var p in midPrice)
//            Console.WriteLine($"{p.Name} — {p.Price} руб");
//    }
//}

//9
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { -5, 12, 0, -8, 27, -3, 15 };

//        var positive = numbers.Where(x => x > 0).ToList();

//        Console.WriteLine("Положительные числа:");
//        Console.WriteLine(string.Join(", ", positive));
//    }
//}

//10
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public int ExperienceYears { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Алексей", Salary = 80000, ExperienceYears = 5 },
//            new Employee { Name = "Дарья", Salary = 120000, ExperienceYears = 3 },
//            new Employee { Name = "Егор", Salary = 65000, ExperienceYears = 1 },
//            new Employee { Name = "Света", Salary = 95000, ExperienceYears = 4 }
//        };

//        decimal avgSalary = employees.Average(e => e.Salary);

//        var valuable = employees
//            .Where(e => e.Salary > avgSalary && e.ExperienceYears > 2)
//            .ToList();

//        Console.WriteLine($"Средняя зарплата: {avgSalary:0} руб");
//        Console.WriteLine("Ценные сотрудники:");
//        foreach (var e in valuable)
//            Console.WriteLine($"{e.Name} — {e.Salary} руб, стаж {e.ExperienceYears} лет");
//    }
//}

//11
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        var squares = numbers.Select(x => x * x).ToList();

//        Console.WriteLine("Квадраты: " + string.Join(", ", squares));
//    }
//}

//12
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person { public string Name { get; set; } public int Age { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Анна", Age = 25 },
//            new Person { Name = "Борис", Age = 30 }
//        };

//        var names = people.Select(p => p.Name).ToList();

//        Console.WriteLine("Имена: " + string.Join(", ", names));
//    }
//}

//13
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person { public string Name { get; set; } public int Age { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Виктор", Age = 27 },
//            new Person { Name = "Ольга", Age = 34 }
//        };

//        var info = people.Select(p => $"{p.Name} - {p.Age}").ToList();

//        Console.WriteLine("Информация:");
//        foreach (var s in info) Console.WriteLine(s);
//    }
//}

//14
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "C#", "Java", "Python", "Go" };

//        var lengths = words.Select(w => w.Length).ToList();

//        Console.WriteLine("Длины: " + string.Join(", ", lengths));
//    }
//}

//15
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public string Category { get; set; }
//}

//public class ProductDto
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Price = 75000, Category = "Электроника" }
//        };

//        var dtos = products.Select(p => new ProductDto
//        {
//            Name = p.Name,
//            Price = p.Price
//        }).ToList();

//        foreach (var dto in dtos)
//            Console.WriteLine($"{dto.Name}: {dto.Price} руб");
//    }
//}

//16
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        decimal[] pricesRub = { 5000, 12500, 8000 };

//        var pricesUsd = pricesRub.Select(p => p / 100m).ToList();

//        Console.WriteLine("Цены в USD: " + string.Join(", ", pricesUsd));
//    }
//}

//17
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public decimal Salary { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Мария", Age = 29, Salary = 120000 }
//        };

//        var projection = employees.Select(e => new
//        {
//            FullName = e.Name.ToUpper(),
//            YearlySalary = e.Salary * 12,
//            IsAdult = e.Age >= 18
//        }).ToList();

//        foreach (var item in projection)
//            Console.WriteLine($"{item.FullName}, годовая з/п: {item.YearlySalary}, взрослый: {item.IsAdult}");
//    }
//}

//18
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] items = { "яблоко", "банан", "груша" };

//        var withPrefix = items.Select(x => "Фрукт: " + x).ToList();

//        Console.WriteLine(string.Join(" | ", withPrefix));
//    }
//}

//19
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class User
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public string Email { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var users = new List<User>
//        {
//            new User { FirstName = "Иван", LastName = "Петров", Email = "ivan@example.com" }
//        };

//        var formatted = users.Select(u => new
//        {
//            Display = $"[{u.FirstName} {u.LastName}] <{u.Email.ToLower()}>"
//        }).ToList();

//        foreach (var f in formatted)
//            Console.WriteLine(f.Display);
//    }
//}

//20
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public int Grade { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Алексей", Grade = 5 },
//            new Student { Name = "Елена", Grade = 4 }
//        };

//        var tuples = students.Select(s => (s.Name, s.Grade)).ToList();

//        foreach (var (name, grade) in tuples)
//            Console.WriteLine($"{name} — оценка {grade}");
//    }
//}

//21
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 5, 2, 8, 1, 9 };

//        var sorted = numbers.OrderBy(x => x).ToList();

//        Console.WriteLine("По возрастанию: " + string.Join(" → ", sorted));
//    }
//}

//22
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] names = { "Олег", "Анна", "Виктор", "Мария", "Борис" };

//        var reversed = names.OrderByDescending(n => n).ToList();

//        Console.WriteLine("От Z до A: " + string.Join(" → ", reversed));
//    }
//}

//23
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var people = new List<Person>
//        {
//            new Person { Name = "Иван", Age = 25 },
//            new Person { Name = "Анна", Age = 30 },
//            new Person { Name = "Пётр", Age = 25 },
//            new Person { Name = "Мария", Age = 30 }
//        };

//        var sorted = people
//            .OrderBy(p => p.Age)
//            .ThenBy(p => p.Name)
//            .ToList();

//        foreach (var p in sorted)
//            Console.WriteLine($"{p.Name} — {p.Age} лет");
//    }
//}

//24
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "C#", "Python", "Go", "JavaScript", "Hi" };

//        var byLength = words.OrderBy(w => w.Length).ToList();

//        Console.WriteLine("От коротких к длинным: " + string.Join(" → ", byLength));
//    }
//}


//26
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student
//{
//    public string Name { get; set; }
//    public int Score { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иванов", Score = 85 },
//            new Student { Name = "Петров", Score = 92 },
//            new Student { Name = "Сидоров", Score = 92 },
//            new Student { Name = "Козлов", Score = 78 }
//        };

//        var ranked = students
//            .OrderByDescending(s => s.Score)
//            .ThenBy(s => s.Name)
//            .ToList();

//        foreach (var s in ranked)
//            Console.WriteLine($"{s.Name} — {s.Score} баллов");
//    }
//}

//27
//using System;
//using System.Linq;

//class Program
//{
//    static int CountDivisors(int n)
//    {
//        int count = 0;
//        for (int i = 1; i <= n; i++)
//            if (n % i == 0) count++;
//        return count;
//    }

//    static void Main()
//    {
//        int[] numbers = { 12, 5, 24, 7, 18, 9, 11 };

//        var sorted = numbers
//            .OrderBy(CountDivisors)
//            .ThenBy(n => n)
//            .ToList();

//        Console.WriteLine("По количеству делителей: " + string.Join(", ", sorted));
//    }
//}

//28
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public decimal Salary { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Name = "Алексей", Department = "IT", Salary = 120000 },
//            new Employee { Name = "Ольга", Department = "HR", Salary = 90000 },
//            new Employee { Name = "Дмитрий", Department = "IT", Salary = 140000 }
//        };

//        var sorted = employees
//            .OrderBy(e => e.Department)
//            .ThenByDescending(e => e.Salary)
//            .ToList();

//        foreach (var e in sorted)
//            Console.WriteLine($"{e.Department} → {e.Name}: {e.Salary} руб");
//    }
//}

//29
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        DateTime[] dates =
//        {
//            new DateTime(2023, 12, 25),
//            new DateTime(2022, 8, 15),
//            new DateTime(2024, 1, 1)
//        };

//        var chronological = dates.OrderBy(d => d).ToList();

//        foreach (var d in chronological)
//            Console.WriteLine(d.ToString("yyyy-MM-dd"));
//    }
//}

//30
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Name { get; set; }
//    public string Category { get; set; }
//    public int Popularity { get; set; } 
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Книга A", Category = "Книги", Popularity = 150 },
//            new Product { Name = "Книга B", Category = "Книги", Popularity = 200 },
//            new Product { Name = "Телефон X", Category = "Гаджеты", Popularity = 500 }
//        };

//        var sorted = products
//            .OrderBy(p => p.Category)
//            .ThenByDescending(p => p.Popularity)
//            .ToList();

//        foreach (var p in sorted)
//            Console.WriteLine($"{p.Category} → {p.Name} ({p.Popularity})");
//    }
//}

//34
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student { public string Name { get; set; } public string Faculty { get; set; } public double Grade { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Name = "Иван", Faculty = "IT", Grade = 4.8 },
//            new Student { Name = "Мария", Faculty = "IT", Grade = 4.5 },
//            new Student { Name = "Пётр", Faculty = "Экономика", Grade = 4.2 }
//        };

//        var avgByFaculty = students
//            .GroupBy(s => s.Faculty)
//            .Select(g => new { Faculty = g.Key, AvgGrade = g.Average(s => s.Grade) });

//        foreach (var item in avgByFaculty)
//            Console.WriteLine($"{item.Faculty}: средний балл = {item.AvgGrade:F2}");
//    }
//}


//36
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Order { public string Client { get; set; } public decimal Amount { get; set; } public int OrderId { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var orders = new List<Order>
//        {
//            new Order { Client = "Иванов", Amount = 5000, OrderId = 1 },
//            new Order { Client = "Иванов", Amount = 15000, OrderId = 2 },
//            new Order { Client = "Петров", Amount = 8000, OrderId = 3 }
//        };

//        var maxByClient = orders
//            .GroupBy(o => o.Client)
//            .Select(g => new
//            {
//                Client = g.Key,
//                MaxAmount = g.Max(o => o.Amount),
//                OrderId = g.First(o => o.Amount == g.Max(x => x.Amount)).OrderId
//            });

//        foreach (var item in maxByClient)
//            Console.WriteLine($"{item.Client}: самый дорогой заказ #{item.OrderId} на {item.MaxAmount} руб");
//    }
//}

//37
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "Яблоко", "Банан", "Арбуз", "Груша", "Апельсин" };

//        var byFirstLetter = words.GroupBy(w => w[0]);

//        foreach (var g in byFirstLetter.OrderBy(g => g.Key))
//        {
//            Console.WriteLine($"{g.Key}: {string.Join(", ", g)}");
//        }
//    }
//}

//38
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var events = new List<DateTime>
//        {
//            new DateTime(2025, 1, 10),
//            new DateTime(2025, 1, 11),
//            new DateTime(2025, 1, 10),
//            new DateTime(2025, 1, 12)
//        };

//        var byDate = events
//            .GroupBy(e => e.Date)
//            .Select(g => new { Date = g.Key.ToString("yyyy-MM-dd"), Count = g.Count() })
//            .OrderBy(x => x.Date);

//        foreach (var item in byDate)
//            Console.WriteLine($"{item.Date}: {item.Count} событий");
//    }
//}
