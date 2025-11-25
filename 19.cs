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

//25
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
//            new Product { Name = "Мышь", Price = 1200 },
//            new Product { Name = "Монитор", Price = 25000 }
//        };

//        var expensiveFirst = products.OrderByDescending(p => p.Price).ToList();

//        foreach (var p in expensiveFirst)
//            Console.WriteLine($"{p.Name} — {p.Price} руб");
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

//31
//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var groups = numbers.GroupBy(n => n % 2 == 0 ? "Чётные" : "Нечётные");

//        foreach (var group in groups)
//        {
//            Console.WriteLine($"{group.Key}: {string.Join(", ", group)}");
//        }
//    }
//}

//32
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
//            new Person { Name = "Борис", Age = 30 },
//            new Person { Name = "Вера", Age = 25 }
//        };

//        var byAge = people.GroupBy(p => p.Age);

//        foreach (var group in byAge)
//        {
//            Console.WriteLine($"Возраст {group.Key}: {string.Join(", ", group.Select(p => p.Name))}");
//        }
//    }
//}

//33
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public string Name { get; set; } public string Category { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Name = "Ноутбук", Category = "Электроника" },
//            new Product { Name = "Книга", Category = "Книги" },
//            new Product { Name = "Телефон", Category = "Электроника" }
//        };

//        var grouped = products.GroupBy(p => p.Category);

//        foreach (var g in grouped)
//        {
//            Console.WriteLine($"{g.Key}: {g.Count()} шт. ({string.Join(", ", g.Select(p => p.Name))})");
//        }
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

//35
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee { public string Name { get; set; } public string Department { get; set; } public decimal Salary { get; set; } }

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

//        var salaryByDept = employees
//            .GroupBy(e => e.Department)
//            .Select(g => new { Dept = g.Key, TotalSalary = g.Sum(e => e.Salary) });

//        foreach (var item in salaryByDept)
//            Console.WriteLine($"{item.Dept}: общая зарплата = {item.TotalSalary} руб");
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

//39
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Sale { public DateTime Date { get; set; } public decimal Amount { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var sales = new List<Sale>
//        {
//            new Sale { Date = new DateTime(2025, 1, 15), Amount = 10000 },
//            new Sale { Date = new DateTime(2025, 1, 20), Amount = 15000 },
//            new Sale { Date = new DateTime(2025, 2, 5), Amount = 20000 }
//        };

//        var byMonth = sales
//            .GroupBy(s => new { s.Date.Year, s.Date.Month })
//            .Select(g => new
//            {
//                Month = $"{g.Key.Year}-{g.Key.Month:D2}",
//                Total = g.Sum(s => s.Amount)
//            });

//        foreach (var item in byMonth)
//            Console.WriteLine($"Месяц {item.Month}: {item.Total} руб");
//    }
//}

//40
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product
//{
//    public string Category { get; set; }
//    public string Subcategory { get; set; }
//    public string Name { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Category = "Электроника", Subcategory = "Смартфоны", Name = "iPhone" },
//            new Product { Category = "Электроника", Subcategory = "Ноутбуки", Name = "MacBook" },
//            new Product { Category = "Одежда", Subcategory = "Обувь", Name = "Кроссовки" }
//        };

//        var nested = products
//            .GroupBy(p => p.Category)
//            .Select(cg => new
//            {
//                Category = cg.Key,
//                Subcategories = cg.GroupBy(p => p.Subcategory)
//                                  .Select(sg => new { Subcategory = sg.Key, Items = sg.Select(p => p.Name) })
//            });

//        foreach (var cat in nested)
//        {
//            Console.WriteLine($"► {cat.Category}");
//            foreach (var sub in cat.Subcategories)
//            {
//                Console.WriteLine($"   └─ {sub.Subcategory}: {string.Join(", ", sub.Items)}");
//            }
//        }
//    }
//}

//41
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Student { public int Id { get; set; } public string Name { get; set; } }
//public class Grade { public int StudentId { get; set; } public string Subject { get; set; } public int Score { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var students = new List<Student>
//        {
//            new Student { Id = 1, Name = "Иван" },
//            new Student { Id = 2, Name = "Мария" }
//        };

//        var grades = new List<Grade>
//        {
//            new Grade { StudentId = 1, Subject = "Математика", Score = 5 },
//            new Grade { StudentId = 1, Subject = "Физика", Score = 4 },
//            new Grade { StudentId = 2, Subject = "Математика", Score = 5 }
//        };

//        var result = students
//            .Join(grades,
//                  s => s.Id,
//                  g => g.StudentId,
//                  (s, g) => new { s.Name, g.Subject, g.Score });

//        foreach (var r in result)
//            Console.WriteLine($"{r.Name} — {r.Subject}: {r.Score}");
//    }
//}

//42
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Employee { public int Id { get; set; } public string Name { get; set; } public int DeptId { get; set; } }
//public class Department { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var employees = new List<Employee>
//        {
//            new Employee { Id = 1, Name = "Алексей", DeptId = 10 },
//            new Employee { Id = 2, Name = "Ольга", DeptId = 20 }
//        };

//        var departments = new List<Department>
//        {
//            new Department { Id = 10, Name = "IT" },
//            new Department { Id = 20, Name = "HR" }
//        };

//        var joined = employees
//            .Join(departments,
//                  e => e.DeptId,
//                  d => d.Id,
//                  (e, d) => new { e.Name, Department = d.Name });

//        foreach (var j in joined)
//            Console.WriteLine($"{j.Name} работает в отделе {j.Department}");
//    }
//}

//43
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Customer { public int Id { get; set; } public string Name { get; set; } }
//public class Order { public int CustomerId { get; set; } public decimal Amount { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var customers = new List<Customer>
//        {
//            new Customer { Id = 1, Name = "Иван" },
//            new Customer { Id = 2, Name = "Пётр" },
//            new Customer { Id = 3, Name = "Анна" }
//        };

//        var orders = new List<Order>
//        {
//            new Order { CustomerId = 1, Amount = 5000 },
//            new Order { CustomerId = 1, Amount = 3000 }
//        };

//        var leftJoin = customers
//            .GroupJoin(orders,
//                       c => c.Id,
//                       o => o.CustomerId,
//                       (c, os) => new { c.Name, Orders = os.DefaultIfEmpty() })
//            .SelectMany(x => x.Orders.Select(o => new { x.Name, Amount = o?.Amount ?? 0 }));

//        foreach (var r in leftJoin)
//            Console.WriteLine($"{r.Name} → заказ на {r.Amount} руб");
//    }
//}

//44
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public int Id { get; set; } public string Name { get; set; } public int ManufacturerId { get; set; } }
//public class Manufacturer { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Id = 101, Name = "iPhone 15", ManufacturerId = 1 }
//        };

//        var manufacturers = new List<Manufacturer>
//        {
//            new Manufacturer { Id = 1, Name = "Apple" },
//            new Manufacturer { Id = 2, Name = "Samsung" }
//        };

//        var result = products
//            .Join(manufacturers,
//                  p => p.ManufacturerId,
//                  m => m.Id,
//                  (p, m) => $"{p.Name} — производитель: {m.Name}");

//        foreach (var r in result)
//            Console.WriteLine(r);
//    }
//}

//45
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class OrderDetail { public int OrderId { get; set; } public int ProductId { get; set; } public int Quantity { get; set; } }
//public class Price { public int ProductId { get; set; } public DateTime Date { get; set; } public decimal Value { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var details = new List<OrderDetail>
//        {
//            new OrderDetail { OrderId = 100, ProductId = 5, Quantity = 2 }
//        };

//        var prices = new List<Price>
//        {
//            new Price { ProductId = 5, Date = new DateTime(2025, 1, 1), Value = 1000 }
//        };

//        var result = details
//            .Join(prices,
//                  d => new { d.ProductId, Date = new DateTime(2025, 1, 1) },
//                  p => new { p.ProductId, p.Date },
//                  (d, p) => new { d.OrderId, d.ProductId, d.Quantity, Total = d.Quantity * p.Value });

//        foreach (var r in result)
//            Console.WriteLine($"Заказ {r.OrderId}: {r.Total} руб");
//    }
//}

//46
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Customer { public int Id { get; set; } public string Name { get; set; } }
//public class Order { public int Id { get; set; } public int CustomerId { get; set; } public int ProductId { get; set; } }
//public class Product { public int Id { get; set; } public string Name { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var customers = new List<Customer> { new Customer { Id = 1, Name = "Иван" } };
//        var orders = new List<Order> { new Order { Id = 10, CustomerId = 1, ProductId = 100 } };
//        var products = new List<Product> { new Product { Id = 100, Name = "Ноутбук" } };

//        var report = customers
//            .Join(orders, c => c.Id, o => o.CustomerId, (c, o) => new { c.Name, o.Id, o.ProductId })
//            .Join(products, x => x.ProductId, p => p.Id, (x, p) => $"{x.Name} заказал {p.Name}");

//        foreach (var r in report)
//            Console.WriteLine(r);
//    }
//}

//47
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Department { public int Id { get; set; } public string Name { get; set; } }
//public class Employee { public string Name { get; set; } public int DeptId { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var depts = new List<Department>
//        {
//            new Department { Id = 1, Name = "IT" },
//            new Department { Id = 2, Name = "HR" }
//        };

//        var emps = new List<Employee>
//        {
//            new Employee { Name = "Алексей", DeptId = 1 },
//            new Employee { Name = "Ольга", DeptId = 1 }
//        };

//        var result = depts.GroupJoin(emps,
//            d => d.Id,
//            e => e.DeptId,
//            (d, employees) => new { Dept = d.Name, Employees = employees.Select(e => e.Name) });

//        foreach (var r in result)
//        {
//            Console.WriteLine($"{r.Dept}: {string.Join(", ", r.Employees.DefaultIfEmpty("нет сотрудников"))}");
//        }
//    }
//}

//48
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var colors = new[] { "Красный", "Синий" };
//        var sizes = new[] { "S", "M", "L" };

//        var combinations = colors
//            .SelectMany(c => sizes, (c, s) => $"{c} {s}");

//        foreach (var combo in combinations)
//            Console.WriteLine(combo);
//        Kuiper Belt
//    }
//}

//49
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Product { public int Id { get; set; } public string Name { get; set; } public bool IsActive { get; set; } }
//public class Stock { public int ProductId { get; set; } public int Quantity { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var products = new List<Product>
//        {
//            new Product { Id = 1, Name = "Телефон", IsActive = true },
//            new Product { Id = 2, Name = "Старый товар", IsActive = false }
//        };

//        var stock = new List<Stock>
//        {
//            new Stock { ProductId = 1, Quantity = 10 },
//            new Stock { ProductId = 2, Quantity = 5 }
//        };

//        var result = products
//            .Where(p => p.IsActive)
//            .Join(stock,
//                  p => p.Id,
//                  s => s.ProductId,
//                  (p, s) => new { p.Name, s.Quantity });

//        foreach (var r in result)
//            Console.WriteLine($"{r.Name} — на складе: {r.Quantity}");
//    }
//}

//50
//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class UserDto { public int UserId { get; set; } public string FullName { get; set; } }
//public class Profile { public int Id { get; set; } public string Email { get; set; } }

//class Program
//{
//    static void Main()
//    {
//        var users = new List<UserDto>
//        {
//            new UserDto { UserId = 1, FullName = "Иван Петров" }
//        };

//        var profiles = new List<Profile>
//        {
//            new Profile { Id = 1, Email = "ivan@example.com" }
//        };

//        var combined = users
//            .Join(profiles,
//                  u => u.UserId,
//                  p => p.Id,
//                  (u, p) => new { u.FullName, p.Email });

//        foreach (var c in combined)
//            Console.WriteLine($"{c.FullName} → {c.Email}");
//    }
//}
//using System.Collections.ObjectModel;

//51
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int>();

//        numbers.Add(10);
//        numbers.Add(20);
//        numbers.AddRange(new[] { 30, 40, 50 });
//        numbers.Insert(1, 15);

//        Console.WriteLine(string.Join(", ", numbers));

//        numbers.Remove(30);
//        numbers.RemoveAt(0);

//        Console.WriteLine(string.Join(", ", numbers));
//        Console.WriteLine($"Count: {numbers.Count}");
//    }
//}

//52
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 12, 23, 8, 45, 17, 30, 42 };

//        int firstBig = numbers.Find(x => x > 20);
//        Console.WriteLine($"Первый > 20: {firstBig}");

//        List<int> allBig = numbers.FindAll(x => x > 20);
//        Console.WriteLine($"Все > 20: {string.Join(", ", allBig)}");

//        List<int> evens = numbers.FindAll(x => x % 2 == 0);
//        Console.WriteLine($"Чётные: {string.Join(", ", evens)}");
//    }
//}

//53
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        string text = "the quick brown fox jumps over the lazy dog the fox";
//        string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//        Dictionary<string, int> count = new Dictionary<string, int>();

//        foreach (string word in words)
//        {
//            if (count.ContainsKey(word))
//                count[word]++;
//            else
//                count[word] = 1;
//        }

//        foreach (var pair in count)
//            Console.WriteLine($"{pair.Key} → {pair.Value}");
//    }
//}

//54
//using System;
//using System.Collections.Generic;

//class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>
//        {
//            new Student { Id = 1, Name = "Анна", Age = 20 },
//            new Student { Id = 2, Name = "Борис", Age = 19 },
//            new Student { Id = 3, Name = "Вера", Age = 21 }
//        };

//        students.Add(new Student { Id = 4, Name = "Глеб", Age = 20 });

//        foreach (Student s in students)
//            Console.WriteLine($"{s.Id}. {s.Name}, {s.Age}");
//    }
//}

//55
//using System;
//using System.Collections.Generic;

//class Student
//{
//    public string Name { get; set; }
//    public int Group { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Student> students = new List<Student>
//        {
//            new Student { Name = "Анна", Group = 101 },
//            new Student { Name = "Борис", Group = 102 },
//            new Student { Name = "Вера", Group = 101 },
//            new Student { Name = "Глеб", Group = 103 },
//            new Student { Name = "Диана", Group = 102 }
//        };

//        Dictionary<int, List<Student>> groups = new Dictionary<int, List<Student>>();

//        foreach (Student s in students)
//        {
//            if (!groups.ContainsKey(s.Group))
//                groups[s.Group] = new List<Student>();
//            groups[s.Group].Add(s);
//        }

//        foreach (var pair in groups)
//        {
//            Console.WriteLine($"Группа {pair.Key}:");
//            foreach (Student s in pair.Value)
//                Console.WriteLine($"  {s.Name}");
//        }
//    }
//}


//56
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> list = new List<int> { 50, 10, 40, 30, 20, 60 };

//        list.Sort();
//        Console.WriteLine("После Sort: " + string.Join(" ", list));

//        list.Reverse();
//        Console.WriteLine("После Reverse: " + string.Join(" ", list));

//        list.Sort();
//        int pos = list.BinarySearch(40);
//        Console.WriteLine("BinarySearch(40) → индекс: " + pos);

//        int notFound = list.BinarySearch(999);
//        Console.WriteLine("BinarySearch(999) → " + (notFound < 0 ? "не найден" : notFound));
//    }
//}

//57
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, decimal> prices = new Dictionary<string, decimal>
//        {
//            ["Apple"] = 0.95m,
//            ["Banana"] = 1.20m,
//            ["Orange"] = 1.50m
//        };

//        prices["Milk"] = 2.30m;

//        foreach (var p in prices)
//            Console.WriteLine($"{p.Key}: {p.Value:C}");
//    }
//}

//58
//using System;
//using System.Collections.Generic;

//class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, Product> catalog = new Dictionary<int, Product>
//        {
//            [101] = new Product { Name = "Laptop", Price = 999.99m },
//            [102] = new Product { Name = "Mouse", Price = 25.50m }
//        };

//        catalog[103] = new Product { Name = "Keyboard", Price = 75.00m };

//        foreach (var item in catalog)
//            Console.WriteLine($"{item.Key}: {item.Value.Name} – {item.Value.Price:C}");
//    }
//}

//59
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<Tuple<int, string>> items = new List<Tuple<int, string>>
//        {
//            Tuple.Create(1, "One"),
//            Tuple.Create(2, "Two"),
//            Tuple.Create(3, "Three")
//        };

//        items.Add(Tuple.Create(4, "Four"));

//        foreach (var t in items)
//            Console.WriteLine($"{t.Item1} → {t.Item2}");
//    }
//}

//60
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        SortedDictionary<string, int> sorted = new SortedDictionary<string, int>
//        {
//            ["Banana"] = 5,
//            ["Apple"] = 3,
//            ["Orange"] = 8
//        };

//        sorted["Cherry"] = 2;

//        foreach (var kvp in sorted)
//            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//}

//61
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, HashSet<string>> groups = new Dictionary<int, HashSet<string>>();

//        groups[1] = new HashSet<string> { "Anna", "Boris" };
//        groups[1].Add("Anna");
//        groups[1].Add("Victor");

//        groups[2] = new HashSet<string> { "Anna", "Diana" };

//        foreach (var g in groups)
//        {
//            Console.WriteLine($"Group {g.Key}: {string.Join(", ", g.Value)}");
//        }
//    }
//}

//62
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 3, 7, 2, 9, 1, 6, 8, 4 };

//        var even = numbers.Where(x => x % 2 == 0).ToList();
//        var sortedDesc = numbers.OrderByDescending(x => x).ToList();
//        var sum = numbers.Sum();
//        var firstBig = numbers.FirstOrDefault(x => x > 7);

//        Console.WriteLine("Чётные: " + string.Join(" ", even));
//        Console.WriteLine("По убыванию: " + string.Join(" ", sortedDesc));
//        Console.WriteLine("Сумма: " + sum);
//        Console.WriteLine("Первое > 7: " + firstBig);
//    }
//}

//63
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, object> person = new Dictionary<string, object>
//        {
//            ["Name"] = "Alex",
//            ["Age"] = 30,
//            ["IsAdmin"] = true,
//            ["Scores"] = new int[] { 85, 92, 78 }
//        };

//        person["City"] = "Moscow";

//        foreach (var kvp in person)
//            Console.WriteLine($"{kvp.Key}: {kvp.Value} ({kvp.Value.GetType().Name})");
//    }
//}

//64
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Queue<string> queue = new Queue<string>();
//        queue.Enqueue("Первый");
//        queue.Enqueue("Второй");
//        queue.Enqueue("Третий");

//        Console.WriteLine("Queue:");
//        while (queue.Count > 0)
//            Console.WriteLine(queue.Dequeue());

//        Stack<int> stack = new Stack<int>();
//        stack.Push(10);
//        stack.Push(20);
//        stack.Push(30);

//        Console.WriteLine("\nStack:");
//        while (stack.Count > 0)
//            Console.WriteLine(stack.Pop());
//    }
//}

//65
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        var evenSquared = numbers
//            .Where(x => x % 2 == 0)
//            .Select(x => x * x)
//            .ToList();

//        Console.WriteLine(string.Join(" ", evenSquared));
//    }
//}

//66
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, int> ages = new Dictionary<string, int>
//        {
//            ["Anna"] = 25,
//            ["Boris"] = 30
//        };

//        string name = "Victor";
//        if (ages.ContainsKey(name))
//            Console.WriteLine($"{name}: {ages[name]}");
//        else
//            Console.WriteLine($"{name} не найден");

//        ages.TryGetValue("Anna", out int age);
//        Console.WriteLine($"Anna: {age}");
//    }
//}

//67
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        SortedList<string, decimal> prices = new SortedList<string, decimal>
//        {
//            ["Banana"] = 1.2m,
//            ["Apple"] = 0.95m,
//            ["Orange"] = 1.5m
//        };

//        prices["Cherry"] = 3.1m;

//        foreach (var p in prices)
//            Console.WriteLine($"{p.Key}: {p.Value}");
//    }
//}

//68
//using System;
//using System.Collections.Generic;
//using System.Collections.Specialized;

//class Program
//{
//    static void Main()
//    {
//        ObservableCollection<string> items = new ObservableCollection<string>();

//        items.CollectionChanged += (s, e) =>
//        {
//            Console.WriteLine($"Действие: {e.Action}, элементов добавлено/удалено: {e.NewItems?.Count ?? e.OldItems?.Count}");
//        };

//        items.Add("Элемент 1");
//        items.Add("Элемент 2");
//        items.Remove("Элемент 1");
//    }
//}

//69
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, List<int>> data = new Dictionary<string, List<int>>
//        {
//            ["Группа A"] = new List<int> { 10, 20, 30 },
//            ["Группа B"] = new List<int> { 40, 50 }
//        };

//        data["Группа A"].Add(99);

//        foreach (var kvp in data)
//        {
//            Console.WriteLine($"{kvp.Key}: {string.Join(", ", kvp.Value)}");
//        }
//    }
//}

//70
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        LinkedList<int> list = new LinkedList<int>();
//        list.AddLast(10);
//        list.AddLast(20);
//        var node = list.AddLast(30);
//        list.AddBefore(node, 25);

//        foreach (int value in list)
//            Console.WriteLine(value);
//    }
//}

//71
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> words = new List<string> { "cat", "dog", "bird", "cat", "fish" };

//        Console.WriteLine(words.Contains("dog"));
//        Console.WriteLine(words.IndexOf("cat"));
//        Console.WriteLine(words.LastIndexOf("cat"));
//        Console.WriteLine(words.IndexOf("wolf"));
//    }
//}

//72
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, string> statusMap = new Dictionary<int, string>
//        {
//            [200] = "OK",
//            [404] = "Not Found",
//            [500] = "Server Error"
//        };

//        statusMap[201] = "Created";

//        Console.WriteLine(statusMap[404]);
//        Console.WriteLine(statusMap.ContainsKey(403) ? statusMap[403] : "Unknown");
//    }
//}

//73
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<double> values = new List<double> { 1.1, 2.2, 3.3 };

//        values.Add(4.4);
//        values.Insert(1, 9.9);
//        values.Remove(2.2);
//        values.RemoveAt(0);

//        Console.WriteLine(string.Join(" ", values));
//    }
//}

//74
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        string text = "cat dog bird cat fish dog cat";
//        string[] words = text.Split(' ');

//        Dictionary<string, int> freq = new Dictionary<string, int>();

//        foreach (string w in words)
//        {
//            if (freq.ContainsKey(w))
//                freq[w]++;
//            else
//                freq[w] = 1;
//        }

//        foreach (var kvp in freq)
//            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//}

//75
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var list = new List<KeyValuePair<string, int>>
//        {
//            new KeyValuePair<string, int>("A", 10),
//            new KeyValuePair<string, int>("B", 20)
//        };

//        list.Add(new KeyValuePair<string, int>("C", 30));

//        foreach (var kvp in list)
//            Console.WriteLine($"{kvp.Key} = {kvp.Value}");
//    }
//}

//76
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, int> scores = new Dictionary<string, int>
//        {
//            ["Anna"] = 85,
//            ["Boris"] = 92,
//            ["Vera"] = 78,
//            ["Gleb"] = 95
//        };

//        foreach (var kvp in scores.Where(k => k.Value > 90))
//            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
//    }
//}

//77
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static Dictionary<int, int> cache = new Dictionary<int, int>();

//    static int Fib(int n)
//    {
//        if (cache.ContainsKey(n)) return cache[n];
//        int result = n <= 1 ? n : Fib(n - 1) + Fib(n - 2);
//        cache[n] = result;
//        return result;
//    }

//    static void Main()
//    {
//        Console.WriteLine(Fib(10));
//        Console.WriteLine(Fib(8));
//        Console.WriteLine($"Кеш: {string.Join(", ", cache)}");
//    }
//}

//78
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, object> storage = new Dictionary<int, object>
//        {
//            [1] = 42,
//            [2] = "Hello",
//            [3] = true,
//            [4] = new[] { 1, 2, 3 }
//        };

//        storage[5] = 3.14;

//        foreach (var kvp in storage)
//            Console.WriteLine($"{kvp.Key}: {kvp.Value} ({kvp.Value.GetType().Name})");
//    }
//}

//79
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//        numbers.RemoveAll(x => x % 3 == 0);
//        Console.WriteLine("После RemoveAll (кратные 3): " + string.Join(" ", numbers));

//        numbers.RemoveRange(0, 2);
//        Console.WriteLine("После RemoveRange(0,2): " + string.Join(" ", numbers));
//    }
//}

//80
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var sales = new Dictionary<string, Dictionary<string, int>>
//        {
//            ["2025"] = new Dictionary<string, int>
//            {
//                ["Январь"] = 1200,
//                ["Февраль"] = 1500
//            },
//            ["2024"] = new Dictionary<string, int>
//            {
//                ["Январь"] = 900,
//                ["Декабрь"] = 1800
//            }
//        };

//        sales["2025"]["Март"] = 1400;

//        foreach (var year in sales)
//        {
//            Console.WriteLine(year.Key);
//            foreach (var month in year.Value)
//                Console.WriteLine($"  {month.Key}: {month.Value}");
//        }
//    }
//}

//81
//using System;
//using System.Collections.Generic;

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Person> people = new List<Person>
//        {
//            new Person { Name = "Anna", Age = 30 },
//            new Person { Name = "Boris", Age = 25 },
//            new Person { Name = "Vera", Age = 35 }
//        };

//        people.Sort((a, b) => a.Age.CompareTo(b.Age));

//        foreach (var p in people)
//            Console.WriteLine($"{p.Name} – {p.Age}");
//    }
//}

//82
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>
//        {
//            ["Фрукты"] = new List<string> { "Яблоко", "Банан" },
//            ["Овощи"] = new List<string> { "Морковь" }
//        };

//        categories["Фрукты"].Add("Груша");
//        if (!categories.ContainsKey("Ягоды"))
//            categories["Ягоды"] = new List<string>();

//        categories["Ягоды"].Add("Клубника");

//        foreach (var cat in categories)
//        {
//            Console.WriteLine(cat.Key + ":");
//            foreach (var item in cat.Value)
//                Console.WriteLine("  " + item);
//        }
//    }
//}

//83
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> source = new List<int> { 10, 20, 30, 40, 50, 60, 70 };

//        int[] arr = new int[10];
//        source.CopyTo(2, arr, 5, 3);
//        Console.WriteLine("CopyTo: " + string.Join(" ", arr));

//        List<int> range = source.GetRange(1, 4);
//        Console.WriteLine("GetRange(1,4): " + string.Join(" ", range));

//        source.InsertRange(3, new[] { 99, 88, 77 });
//        Console.WriteLine("После InsertRange: " + string.Join(" ", source));
//    }
//}

//84
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, HashSet<string>> groups = new Dictionary<int, HashSet<string>>
//        {
//            [1] = new HashSet<string> { "Anna", "Boris" },
//            [2] = new HashSet<string> { "Boris", "Vera" }
//        };

//        groups[1].Add("Anna");
//        groups[1].Add("Gleb");

//        foreach (var g in groups)
//        {
//            Console.WriteLine($"Группа {g.Key}: {string.Join(", ", g.Value)}");
//        }
//    }
//}

//85
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

//        var slice1 = chars.GetRange(2, 3);
//        Console.WriteLine("Срез [2..5): " + string.Join("", slice1));

//        var slice2 = chars.GetRange(0, chars.Count);
//        Console.WriteLine("Полный список: " + string.Join("", slice2));

//        chars.InsertRange(4, new[] { 'X', 'Y' });
//        Console.WriteLine("После вставки: " + string.Join("", chars));
//    }
//}

//86
//using System;
//using System.Collections.Generic;

//class TypedStorage<T>
//{
//    private Dictionary<string, T> store = new Dictionary<string, T>();

//    public void Set(string key, T value) => store[key] = value;
//    public T Get(string key) => store.ContainsKey(key) ? store[key] : default(T);
//    public bool Contains(string key) => store.ContainsKey(key);
//}

//class Program
//{
//    static void Main()
//    {
//        var intStore = new TypedStorage<int>();
//        intStore.Set("Max", 100);
//        intStore.Set("Min", 0);

//        var stringStore = new TypedStorage<string>();
//        stringStore.Set("Name", "Alex");

//        Console.WriteLine(intStore.Get("Max"));
//        Console.WriteLine(stringStore.Get("Name"));
//    }
//}

//87
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int?> values = new List<int?>
//        {
//            10, null, 30, null, 50, 42
//        };

//        values.Add(null);
//        values.Add(100);

//        foreach (var v in values)
//            Console.WriteLine(v.HasValue ? v.Value.ToString() : "null");

//        var sum = 0;
//        foreach (var v in values)
//            if (v.HasValue) sum += v.Value;

//        Console.WriteLine($"Сумма непустых: {sum}");
//    }
//}

//88
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, string> users = new Dictionary<int, string>
//        {
//            [1] = "Anna",
//            [2] = "Boris",
//            [5] = "Vera"
//        };

//        if (users.TryGetValue(2, out string name))
//            Console.WriteLine($"ID 2: {name}");

//        if (!users.TryGetValue(99, out name))
//            Console.WriteLine("ID 99 не найден");
//    }
//}

//89
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> list = new List<string>(20);

//        Console.WriteLine($"Capacity: {list.Capacity}, Count: {list.Count}");

//        list.Add("A"); list.Add("B"); list.Add("C");

//        Console.WriteLine($"После добавления 3: Capacity={list.Capacity}, Count={list.Count}");

//        list.TrimExcess();
//        Console.WriteLine($"После TrimExcess: Capacity={list.Capacity}");
//    }
//}

//90
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, decimal> accounts = new Dictionary<string, decimal>
//        {
//            ["Сбережения"] = 15000.50m,
//            ["Кредитная карта"] = -2500.00m,
//            ["Инвестиции"] = 48200.75m
//        };

//        accounts["Зарплата"] = 5000m;

//        foreach (var a in accounts)
//            Console.WriteLine($"{a.Key}: {a.Value:C}");
//    }
//}

//91
//using System;
//using System.Collections.Generic;

//class PositiveNumbers : List<int>
//{
//    public new void Add(int value)
//    {
//        if (value <= 0) throw new ArgumentException("Только положительные!");
//        base.Add(value);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var positives = new PositiveNumbers();
//        positives.Add(10);
//        positives.Add(20);


//        Console.WriteLine(string.Join(" ", positives));
//    }
//}

//92
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var data = new Dictionary<int, List<KeyValuePair<string, object>>>
//        {
//            [1] = new List<KeyValuePair<string, object>>
//            {
//                new("Name", "Anna"),
//                new("Age", 28),
//                new("Active", true)
//            },
//            [2] = new List<KeyValuePair<string, object>>
//            {
//                new("Name", "Boris"),
//                new("Score", 95.5),
//                new("Tags", new[] { "pro", "vip" })
//            }
//        };

//        foreach (var entry in data)
//        {
//            Console.WriteLine($"ID {entry.Key}:");
//            foreach (var pair in entry.Value)
//                Console.WriteLine($"  {pair.Key}: {pair.Value}");
//        }
//    }
//}

//93
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<int> list = new List<int> { 10, 20, 30 };

//        list.AddRange(new[] { 40, 50, 60 });
//        Console.WriteLine("После AddRange: " + string.Join(" ", list));

//        list.InsertRange(2, new[] { 99, 88, 77 });
//        Console.WriteLine("После InsertRange(2): " + string.Join(" ", list));
//    }
//}

//94
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var json = new Dictionary<string, object>
//        {
//            ["name"] = "Alex",
//            ["age"] = 30,
//            ["isAdmin"] = true,
//            ["scores"] = new[] { 85, 92, 78 },
//            ["address"] = new Dictionary<string, object>
//            {
//                ["city"] = "Moscow",
//                ["zip"] = "101000"
//            }
//        };

//        Console.WriteLine(json["name"]);
//        Console.WriteLine(((int[])json["scores"])[1]);
//        Console.WriteLine(((Dictionary<string, object>)json["address"])["city"]);
//    }
//}

//95
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        List<string> fruits = new List<string> { "apple", "banana", "orange", "banana" };

//        Console.WriteLine(fruits.Contains("banana"));
//        Console.WriteLine(fruits.Contains("grape"));

//        Console.WriteLine(fruits.IndexOf("banana"));
//        Console.WriteLine(fruits.IndexOf("orange"));
//        Console.WriteLine(fruits.IndexOf("grape"));
//    }
//}

//96
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<int, string> dict = new Dictionary<int, string>
//        {
//            [1] = "One",
//            [2] = "Two"
//        };

//        Console.WriteLine($"Count: {dict.Count}");
//        Console.WriteLine($"ContainsKey(1): {dict.ContainsKey(1)}");

//        dict.Clear();
//        Console.WriteLine($"После Clear — Count: {dict.Count}");
//        Console.WriteLine($"IsEmpty: {dict.Count == 0}");
//    }
//}

//97
//using System;
//using System.Collections.Generic;

//enum Day { Monday, Tuesday, Wednesday, Thursday, Friday }

//class Program
//{
//    static void Main()
//    {
//        List<Day> workDays = new List<Day>
//        {
//            Day.Monday, Day.Tuesday, Day.Wednesday, Day.Thursday, Day.Friday
//        };

//        workDays.Add(Day.Friday);

//        foreach (Day d in workDays)
//            Console.WriteLine(d);

//        Console.WriteLine($"Пятница есть: {workDays.Contains(Day.Friday)}");
//    }
//}

//98
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<string, Func<int, int>> operations = new Dictionary<string, Func<int, int>>
//        {
//            ["square"] = x => x * x,
//            ["double"] = x => x * 2,
//            ["inc"] = x => x + 1,
//            ["negate"] = x => -x
//        };

//        Console.WriteLine(operations["square"](5));
//        Console.WriteLine(operations["double"](10));
//        Console.WriteLine(operations["inc"](99));
//    }
//}

//99
//using System;
//using System.Collections.Generic;

//class Publisher<T>
//{
//    private List<Action<T>> subscribers = new List<Action<T>>();

//    public void Subscribe(Action<T> handler) => subscribers.Add(handler);
//    public void Unsubscribe(Action<T> handler) => subscribers.Remove(handler);

//    public void Notify(T data)
//    {
//        foreach (var sub in subscribers)
//            sub(data);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var pub = new Publisher<string>();

//        pub.Subscribe(msg => Console.WriteLine("A: " + msg));
//        pub.Subscribe(msg => Console.WriteLine("B: " + msg.ToUpper()));

//        pub.Notify("Привет!");
//    }
//}

//100
//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        Dictionary<DateTime, string> log = new Dictionary<DateTime, string>();

//        log[DateTime.Now] = "Приложение запущено";
//        log[DateTime.Now.AddSeconds(5)] = "Пользователь вошёл";
//        log[DateTime.Now.AddMinutes(1)] = "Данные сохранены";

//        foreach (var entry in log)
//            Console.WriteLine($"{entry.Key:yyyy-MM-dd HH:mm:ss} | {entry.Value}");
//    }
//}