//1
//using System;

//class Animal
//{
//    public void MakeSound()
//    {
//        Console.WriteLine("Некоторый звук");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Animal animal = new Animal();
//        animal.MakeSound(); 
//    }
//}


//2
//using System;

//class Car
//{
//    public string Brand;
//    public string Model;
//    public int Year;
//}

//class Program
//{
//    static void Main()
//    {
//        Car car1 = new Car();
//        car1.Brand = "Toyota";
//        car1.Model = "Camry";
//        car1.Year = 2020;

//        Car car2 = new Car();
//        car2.Brand = "BMW";
//        car2.Model = "X5";
//        car2.Year = 2022;

//        Console.WriteLine($"Автомобиль 1: Марка - {car1.Brand}, Модель - {car1.Model}, Год - {car1.Year}");
//        Console.WriteLine($"Автомобиль 2: Марка - {car2.Brand}, Модель - {car2.Model}, Год - {car2.Year}");
//    }
//}


//3
//using System;

//class Person
//{
//    public string Name;
//    public int Age;
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();
//        person.Name = "Алексей";
//        person.Age = 30;

//        Console.WriteLine($"Человек: Имя - {person.Name}, Возраст - {person.Age}");
//    }
//}


//4
//using System;

//class Rectangle
//{
//    public double Width;
//    public double Height;

//    public double Area()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rectangle = new Rectangle();
//        rectangle.Width = 10.5;
//        rectangle.Height = 20.5;

//        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
//    }
//}


//5
//using System;

//class Student
//{
//    public string Name;
//    public int Age;
//    public double GPA;
//}

//class Program
//{
//    static void Main()
//    {
//        Student student1 = new Student();
//        student1.Name = "Иван";
//        student1.Age = 18;
//        student1.GPA = 4.5;

//        Student student2 = new Student();
//        student2.Name = "Мария";
//        student2.Age = 19;
//        student2.GPA = 4.8;

//        Console.WriteLine($"Студент 1: {student1.Name}, возраст: {student1.Age}, GPA: {student1.GPA}");
//        Console.WriteLine($"Студент 2: {student2.Name}, возраст: {student2.Age}, GPA: {student2.GPA}");
//    }
//}


//6
//using System;

//class Book
//{
//    public string Title;
//    public string Author;
//    public int Pages;
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();
//        book.Title = "Война и мир";
//        book.Author = "Лев Толстой";
//        book.Pages = 1225;

//        Console.WriteLine($"Книга: Название - {book.Title}, Автор - {book.Author}, Страницы - {book.Pages}");
//    }
//}


//7
//using System;

//class Circle
//{
//    public double Radius;

//    public double Area()
//    {
//        return Math.PI * Radius * Radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle();
//        circle.Radius = 5.0;

//        Console.WriteLine($"Площадь круга: {circle.Area():F2}");
//    }
//}


//8
//using System;

//class BankAccount
//{
//    public double Balance;
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();
//        account.Balance = 1000.50;

//        Console.WriteLine($"Баланс счета: {account.Balance}");
//    }
//}


//9
//using System;

//class Temperature
//{
//    public double Celsius;
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature();
//        temp.Celsius = 25.5;

//        Console.WriteLine($"Температура: {temp.Celsius}°C");
//    }
//}


//10
//using System;

//class Time
//{
//    public int Hours;
//    public int Minutes;
//    public int Seconds;
//}

//class Program
//{
//    static void Main()
//    {
//        Time time = new Time();
//        time.Hours = 14;
//        time.Minutes = 30;
//        time.Seconds = 45;

//        Console.WriteLine($"Время: {time.Hours}:{time.Minutes}:{time.Seconds}");
//    }
//}


//11
//using System;

//class Point
//{
//    public double X;
//    public double Y;
//}

//class Program
//{
//    static void Main()
//    {
//        Point point = new Point();
//        point.X = 3.0;
//        point.Y = 4.0;

//        Console.WriteLine($"Точка: X = {point.X}, Y = {point.Y}");
//    }
//}


//12
//using System;

//class Color
//{
//    public int R;
//    public int G;
//    public int B;
//}

//class Program
//{
//    static void Main()
//    {
//        Color color = new Color();
//        color.R = 255;
//        color.G = 0;
//        color.B = 0;

//        Console.WriteLine($"Цвет: R = {color.R}, G = {color.G}, B = {color.B}");
//    }
//}


//13
//using System;

//class Email
//{
//    public string Address;
//}

//class Program
//{
//    static void Main()
//    {
//        Email email = new Email();
//        email.Address = "example@example.com";

//        Console.WriteLine($"Адрес электронной почты: {email.Address}");
//    }
//}


//14
//using System;

//class PhoneNumber
//{
//    public string Number;
//}

//class Program
//{
//    static void Main()
//    {
//        PhoneNumber phone = new PhoneNumber();
//        phone.Number = "+7 (123) 456-78-90";

//        Console.WriteLine($"Номер телефона: {phone.Number}");
//    }
//}


//15
//using System;

//class URL
//{
//    public string Address;
//}

//class Program
//{
//    static void Main()
//    {
//        URL url = new URL();
//        url.Address = "https://example.com";

//        Console.WriteLine($"Веб-адрес: {url.Address}");
//    }
//}


//16
//using System;

//class Dog
//{
//    public string Name;

//    public void Bark()
//    {
//        Console.WriteLine($"{Name} говорит: Гав!");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Dog dog = new Dog();
//        dog.Name = "Бобик";
//        dog.Bark();
//    }
//}


//17
//using System;

//class Rectangle
//{
//    public double Width;
//    public double Height;

//    public double Area()
//    {
//        return Width * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rectangle = new Rectangle();
//        rectangle.Width = 5.0;
//        rectangle.Height = 10.0;

//        Console.WriteLine($"Площадь прямоугольника: {rectangle.Area()}");
//    }
//}


//18
//using System;

//class Triangle
//{
//    public double Base;
//    public double Height;

//    public double Area()
//    {
//        return 0.5 * Base * Height;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Triangle triangle = new Triangle();
//        triangle.Base = 6.0;
//        triangle.Height = 8.0;

//        Console.WriteLine($"Площадь треугольника: {triangle.Area()}");
//    }
//}


//19
//using System;

//class Employee
//{
//    public string Name;
//    public double Salary;
//}

//class Program
//{
//    static void Main()
//    {
//        Employee employee = new Employee();
//        employee.Name = "Иван Иванов";
//        employee.Salary = 50000.0;

//        Console.WriteLine($"Сотрудник: {employee.Name}, Зарплата: {employee.Salary}");
//    }
//}


//20
//using System;

//class Product
//{
//    public string Name;
//    public double Price;
//    public string Quality;
//}

//class Program
//{
//    static void Main()
//    {
//        Product product = new Product();
//        product.Name = "Ноутбук";
//        product.Price = 45000.0;
//        product.Quality = "Высокое";

//        Console.WriteLine($"Продукт: {product.Name}, Цена: {product.Price}, Качество: {product.Quality}");
//    }
//}


//21
//using System;

//class Student
//{
//    public string Name;
//    public int Age;
//    public double AverageScore;
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();
//        student.Name = "Мария";
//        student.Age = 20;
//        student.AverageScore = 4.7;

//        Console.WriteLine($"Студент: {student.Name}, Возраст: {student.Age}, Средний балл: {student.AverageScore}");
//    }
//}


//22
//using System;

//class House
//{
//    public int Rooms;
//    public double Area;
//}

//class Program
//{
//    static void Main()
//    {
//        House house = new House();
//        house.Rooms = 3;
//        house.Area = 120.5;

//        Console.WriteLine($"Дом: Комнат: {house.Rooms}, Площадь: {house.Area} м²");
//    }
//}


//23
//using System;

//class Account
//{
//    public string AccountNumber;
//    public double Balance;
//}

//class Program
//{
//    static void Main()
//    {
//        Account account = new Account();
//        account.AccountNumber = "123456789";
//        account.Balance = 10000.0;

//        Console.WriteLine($"Счёт: Номер - {account.AccountNumber}, Баланс: {account.Balance}");
//    }
//}


//24
//using System;

//class Bicycle
//{
//    public string Brand;
//    public int Gears;
//}

//class Program
//{
//    static void Main()
//    {
//        Bicycle bicycle = new Bicycle();
//        bicycle.Brand = "Stels";
//        bicycle.Gears = 21;

//        Console.WriteLine($"Велосипед: Марка - {bicycle.Brand}, Количество передач: {bicycle.Gears}");
//    }
//}


//25
//using System;

//class Computer
//{
//    public string Processor;
//    public int RAM;
//}

//class Program
//{
//    static void Main()
//    {
//        Computer computer = new Computer();
//        computer.Processor = "Intel Core i7";
//        computer.RAM = 16;

//        Console.WriteLine($"Компьютер: Процессор - {computer.Processor}, Оперативная память: {computer.RAM} ГБ");
//    }
//}


//26
//using System;

//class Flower
//{
//    public string Name;
//    public string Color;
//}

//class Program
//{
//    static void Main()
//    {
//        Flower flower = new Flower();
//        flower.Name = "Роза";
//        flower.Color = "Красный";

//        Console.WriteLine($"Цветок: Название - {flower.Name}, Цвет: {flower.Color}");
//    }
//}


//27
//using System;

//class Laptop
//{
//    public string Brand;
//    public bool HasHeadphoneJack;
//    public int BatteryCells;
//}

//class Program
//{
//    static void Main()
//    {
//        Laptop laptop = new Laptop();
//        laptop.Brand = "Dell";
//        laptop.HasHeadphoneJack = true;
//        laptop.BatteryCells = 6;

//        Console.WriteLine($"Ноутбук: Марка - {laptop.Brand}, Наличие разъёма для наушников: {laptop.HasHeadphoneJack}, Количество элементов батареи: {laptop.BatteryCells}");
//    }
//}


//28
//using System;

//class Pen
//{
//    public string Color;
//    public string Brand;
//}

//class Program
//{
//    static void Main()
//    {
//        Pen pen = new Pen();
//        pen.Color = "Синий";
//        pen.Brand = "Parker";

//        Console.WriteLine($"Ручка: Цвет - {pen.Color}, Марка: {pen.Brand}");
//    }
//}


//29
//using System;

//class CoffeeCup
//{
//    public double Volume;
//    public bool IsFull;
//}

//class Program
//{
//    static void Main()
//    {
//        CoffeeCup cup = new CoffeeCup();
//        cup.Volume = 250.0;
//        cup.IsFull = true;

//        Console.WriteLine($"Чашка кофе: Объём: {cup.Volume} мл, Полная: {cup.IsFull}");
//    }
//}


//30
//using System;

//class Book
//{
//    public string Title;
//    public string Author;
//    public int Pages;
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();
//        book.Title = "Мастер и Маргарита";
//        book.Author = "Михаил Булгаков";
//        book.Pages = 480;

//        Console.WriteLine($"Книга: Название - {book.Title}, Автор: {book.Author}, Страницы: {book.Pages}");
//    }
//}

//31
//using System;

//class Calculator
//{
//    public int Add(int a, int b)
//    {
//        return a + b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calculator = new Calculator();
//        int result = calculator.Add(5, 7);
//        Console.WriteLine($"Результат сложения: {result}");
//    }
//}


//32
//using System;

//class StringHelper
//{
//    public string Reverse(string s)
//    {
//        char[] charArray = s.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        StringHelper helper = new StringHelper();
//        string reversed = helper.Reverse("hello");
//        Console.WriteLine($"Обратная строка: {reversed}");
//    }
//}


//33
//using System;

//class MathHelper
//{
//    public int Max(int a, int b)
//    {
//        return a > b ? a : b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MathHelper helper = new MathHelper();
//        int maxValue = helper.Max(10, 20);
//        Console.WriteLine($"Максимальное значение: {maxValue}");
//    }
//}


//34
//using System;

//class Temperature
//{
//    public double CelsiusToFahrenheit(double celsius)
//    {
//        return (celsius * 9 / 5) + 32;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature();
//        double fahrenheit = temp.CelsiusToFahrenheit(25);
//        Console.WriteLine($"Температура в Фаренгейтах: {fahrenheit}");
//    }
//}


//35
//using System;

//class LengthConverter
//{
//    public double InchesToCentimeters(double inches)
//    {
//        return inches * 2.54;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        LengthConverter converter = new LengthConverter();
//        double centimeters = converter.InchesToCentimeters(10);
//        Console.WriteLine($"Длина в сантиметрах: {centimeters}");
//    }
//}


//36
//using System;

//class WeightConverter
//{
//    public double KilogramsToPounds(double kilograms)
//    {
//        return kilograms * 2.20462;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        WeightConverter converter = new WeightConverter();
//        double pounds = converter.KilogramsToPounds(70);
//        Console.WriteLine($"Вес в фунтах: {pounds}");
//    }
//}


//37
//using System;

//class ArrayHelper
//{
//    public int FindMax(int[] array)
//    {
//        int max = array[0];
//        foreach (int num in array)
//        {
//            if (num > max)
//                max = num;
//        }
//        return max;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        ArrayHelper helper = new ArrayHelper();
//        int[] numbers = { 3, 7, 2, 9, 5 };
//        int maxValue = helper.FindMax(numbers);
//        Console.WriteLine($"Максимальное значение в массиве: {maxValue}");
//    }
//}


//38
//using System;

//class StringValidator
//{
//    public bool IsValidEmail(string email)
//    {
//        return email.Contains("@") && email.Contains(".");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        StringValidator validator = new StringValidator();
//        bool isValid = validator.IsValidEmail("test@example.com");
//        Console.WriteLine($"Электронная почта корректна: {isValid}");
//    }
//}


//39
//using System;

//class NumberChecker
//{
//    public bool IsPrime(int number)
//    {
//        if (number <= 1) return false;
//        for (int i = 2; i <= Math.Sqrt(number); i++)
//        {
//            if (number % i == 0)
//                return false;
//        }
//        return true;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        NumberChecker checker = new NumberChecker();
//        bool isPrime = checker.IsPrime(17);
//        Console.WriteLine($"Число простое: {isPrime}");
//    }
//}


//40
//using System;

//class DateHelper
//{
//    public string GetDayOfWeek(DateTime date)
//    {
//        return date.DayOfWeek.ToString();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DateHelper helper = new DateHelper();
//        string dayOfWeek = helper.GetDayOfWeek(DateTime.Now);
//        Console.WriteLine($"Сегодня: {dayOfWeek}");
//    }
//}


//41
//using System;
//using System.IO;

//class FileHelper
//{
//    public string ReadFile(string path)
//    {
//        return File.ReadAllText(path);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        FileHelper helper = new FileHelper();
//        try
//        {
//            string content = helper.ReadFile("example.txt");
//            Console.WriteLine($"Содержимое файла: {content}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
//        }
//    }
//}


//42
//using System;

//class Logger
//{
//    public void Log(string message)
//    {
//        Console.WriteLine($"{DateTime.Now}: {message}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Logger logger = new Logger();
//        logger.Log("Сообщение для логирования");
//    }
//}


//43
//using System;

//class Validator
//{
//    public bool IsValidPassword(string password)
//    {
//        return password.Length >= 8;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Validator validator = new Validator();
//        bool isValid = validator.IsValidPassword("mypassword");
//        Console.WriteLine($"Пароль корректен: {isValid}");
//    }
//}


//44
//using System;

//class Formatter
//{
//    public string FormatText(string text)
//    {
//        return text.Trim();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Formatter formatter = new Formatter();
//        string formattedText = formatter.FormatText("   Hello, World!   ");
//        Console.WriteLine($"Отформатированный текст: '{formattedText}'");
//    }
//}


//45
//using System;

//class Counter
//{
//    private int value;

//    public void Increment()
//    {
//        value++;
//    }

//    public void Decrement()
//    {
//        value--;
//    }

//    public int GetValue()
//    {
//        return value;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Counter counter = new Counter();
//        counter.Increment();
//        counter.Increment();
//        counter.Decrement();
//        Console.WriteLine($"Текущее значение счётчика: {counter.GetValue()}");
//    }
//}


//46
//using System;

//class Person
//{
//    private string name;

//    public string Name
//    {
//        get { return name; }
//        set { name = value; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person();
//        person.Name = "Иван";
//        Console.WriteLine($"Имя: {person.Name}");
//    }
//}


//47
//using System;

//class Student
//{
//    private double gpa;

//    public double GPA
//    {
//        get { return gpa; }
//        set
//        {
//            if (value >= 0 && value <= 5)
//                gpa = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student();
//        student.GPA = 4.5;
//        Console.WriteLine($"Средний балл: {student.GPA}");
//    }
//}


//48
//using System;

//class BankAccount
//{
//    private double balance;

//    public double Balance
//    {
//        get { return balance; }
//        set
//        {
//            if (value >= 0)
//                balance = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();
//        account.Balance = 1000;
//        Console.WriteLine($"Баланс: {account.Balance}");
//    }
//}


//49
//using System;

//class Product
//{
//    private double price;

//    public double Price
//    {
//        get { return price; }
//        set
//        {
//            if (value >= 0)
//                price = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product product = new Product();
//        product.Price = 99.99;
//        Console.WriteLine($"Цена: {product.Price}");
//    }
//}


//50
//using System;

//class Car
//{
//    private int speed;

//    public int Speed
//    {
//        get { return speed; }
//        set
//        {
//            if (value >= 0)
//                speed = value;
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car();
//        car.Speed = 120;
//        Console.WriteLine($"Скорость: {car.Speed}");
//    }
//}

//51
//using System;

//class Temperature
//{
//    public double Celsius { get; set; }

//    public double Fahrenheit
//    {
//        get { return Celsius * 9 / 5 + 32; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature();
//        temp.Celsius = 25;
//        Console.WriteLine($"Температура: {temp.Celsius}°C = {temp.Fahrenheit}°F");
//    }
//}

//52
//using System;

//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public double Area
//    {
//        get { return Width * Height; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rect = new Rectangle();
//        rect.Width = 5;
//        rect.Height = 3;
//        Console.WriteLine($"Прямоугольник: {rect.Width}x{rect.Height}, Площадь: {rect.Area}");
//    }
//}
//53
//using System;

//class Circle
//{
//    public double Radius { get; set; }

//    public double Area
//    {
//        get { return Math.PI * Radius * Radius; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle();
//        circle.Radius = 7;
//        Console.WriteLine($"Круг: радиус {circle.Radius}, Площадь: {circle.Area:F2}");
//    }
//}
//54
//using System;

//class Employee
//{
//    public decimal Salary { get; set; }

//    public decimal AnnualSalary
//    {
//        get { return Salary * 12; }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee employee = new Employee();
//        employee.Salary = 50000;
//        Console.WriteLine($"Зарплата: {employee.Salary} руб./мес, Годовая: {employee.AnnualSalary} руб.");
//    }
//}
//55
//using System;

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book();
//        book.Title = "Война и мир";
//        book.Author = "Лев Толстой";
//        Console.WriteLine($"Книга: '{book.Title}', автор: {book.Author}");
//    }
//}
//56
//using System;

//class House
//{
//    public double Area { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        House house = new House();
//        house.Area = 85.5;
//        Console.WriteLine($"Площадь дома: {house.Area} м²");
//    }
//}
//57
//using System;

//class Computer
//{
//    public int RAM { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Computer computer = new Computer();
//        computer.RAM = 16;
//        Console.WriteLine($"Оперативная память: {computer.RAM} ГБ");
//    }
//}
//58
//using System;

//class Account
//{
//    public string Username { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Account account = new Account();
//        account.Username = "ivanov";
//        Console.WriteLine($"Имя пользователя: {account.Username}");
//    }
//}
//59
//using System;

//class Vehicle
//{
//    public string Brand { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Vehicle vehicle = new Vehicle();
//        vehicle.Brand = "Toyota";
//        Console.WriteLine($"Марка автомобиля: {vehicle.Brand}");
//    }
//}
//60
//using System;

//class Color
//{
//    public int Red { get; set; }
//    public int Green { get; set; }
//    public int Blue { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        Color color = new Color();
//        color.Red = 255;
//        color.Green = 128;
//        color.Blue = 0;
//        Console.WriteLine($"Цвет: R={color.Red}, G={color.Green}, B={color.Blue}");
//    }
//}
//61
//using System;

//class Person
//{
//    public int Age { get; }

//    public Person(int age)
//    {
//        Age = age;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person(25);
//        Console.WriteLine($"Возраст: {person.Age}");
//    }
//}
//62
//using System;

//class Student
//{
//    public int ID { get; }

//    public Student(int id)
//    {
//        ID = id;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student(12345);
//        Console.WriteLine($"ID студента: {student.ID}");
//    }
//}
//63
//using System;

//class BankAccount
//{
//    public string AccountNumber { get; }

//    public BankAccount(string accountNumber)
//    {
//        AccountNumber = accountNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount("40817810099910004321");
//        Console.WriteLine($"Номер счета: {account.AccountNumber}");
//    }
//}
//64
//using System;

//class Product
//{
//    public string Code { get; }

//    public Product(string code)
//    {
//        Code = code;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product product = new Product("PRD-001");
//        Console.WriteLine($"Код товара: {product.Code}");
//    }
//}
//65
//using System;

//class Employee
//{
//    public string EmployeeID { get; }

//    public Employee(string employeeId)
//    {
//        EmployeeID = employeeId;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee employee = new Employee("EMP-2024001");
//        Console.WriteLine($"ID сотрудника: {employee.EmployeeID}");
//    }
//}
//66
//using System;

//class Car
//{
//    public string VIN { get; }

//    public Car(string vin)
//    {
//        VIN = vin;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("1HGCM82633A123456");
//        Console.WriteLine($"VIN код: {car.VIN}");
//    }
//}

//67
//using System;

//class House
//{
//    public string Address { get; }

//    public House(string address)
//    {
//        Address = address;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        House house = new House("ул. Ленина, д. 10, кв. 5");
//        Console.WriteLine($"Адрес: {house.Address}");
//    }
//}
//68
//using System;

//class Book
//{
//    public string ISBN { get; }

//    public Book(string isbn)
//    {
//        ISBN = isbn;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book("978-5-389-14815-3");
//        Console.WriteLine($"ISBN: {book.ISBN}");
//    }
//}
//69
//using System;

//class Computer
//{
//    public string SerialNumber { get; }

//    public Computer(string serialNumber)
//    {
//        SerialNumber = serialNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Computer computer = new Computer("SN-123456789");
//        Console.WriteLine($"Серийный номер: {computer.SerialNumber}");
//    }
//}
//70
//using System;

//class Document
//{
//    public DateTime CreatedDate { get; }

//    public Document()
//    {
//        CreatedDate = DateTime.Now;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Document document = new Document();
//        Console.WriteLine($"Дата создания: {document.CreatedDate}");
//    }
//}
//71
//using System;

//class Order
//{
//    public int OrderID { get; }

//    public Order(int orderId)
//    {
//        OrderID = orderId;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Order order = new Order(1001);
//        Console.WriteLine($"Номер заказа: {order.OrderID}");
//    }
//}
//72
//using System;

//class Invoice
//{
//    public string InvoiceNumber { get; }

//    public Invoice(string invoiceNumber)
//    {
//        InvoiceNumber = invoiceNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Invoice invoice = new Invoice("INV-2024-001");
//        Console.WriteLine($"Номер счета: {invoice.InvoiceNumber}");
//    }
//}
//73
//using System;

//class User
//{
//    public string UID { get; }

//    public User(string uid)
//    {
//        UID = uid;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        User user = new User("550e8400-e29b-41d4-a716-446655440000");
//        Console.WriteLine($"UID пользователя: {user.UID}");
//    }
//}
//74
//using System;

//class Device
//{
//    public string MAC { get; }

//    public Device(string mac)
//    {
//        MAC = mac;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Device device = new Device("00:1B:44:11:3A:B7");
//        Console.WriteLine($"MAC адрес: {device.MAC}");
//    }
//}
//75
//using System;

//class Ticket
//{
//    public string TicketNumber { get; }

//    public Ticket(string ticketNumber)
//    {
//        TicketNumber = ticketNumber;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Ticket ticket = new Ticket("TKT-2024000001");
//        Console.WriteLine($"Номер билета: {ticket.TicketNumber}");
//    }
//}
//76
//using System;

//class User
//{
//    private string password;

//    public string Password
//    {
//        set { password = value; }
//    }

//    public bool ValidatePassword(string inputPassword)
//    {
//        return password == inputPassword;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        User user = new User();
//        user.Password = "mySecret123";
//    }
//}
//77
//using System;

//class BankAccount
//{
//    private string pin;

//    public string PIN
//    {
//        set { pin = value; }
//    }

//    public bool VerifyPIN(string inputPIN)
//    {
//        return pin == inputPIN;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount();
//        account.PIN = "1234";
//    }
//}
//78
//using System;

//class SecureDocument
//{
//    private string encryptionKey;

//    public string EncryptionKey
//    {
//        set { encryptionKey = value; }
//    }

//    public string Encrypt(string data)
//    {
//        return $"Encrypted({data}) with key: {encryptionKey}";
//    }
//}
//79
//using System;

//class Account
//{
//    private string token;

//    public string Token
//    {
//        set { token = value; }
//    }

//    public void Authenticate()
//    {
//        Console.WriteLine($"Authenticating with token: {token}");
//    }
//}
//81
//using System;

//class Logger
//{
//    private string apiKey;

//    public string ApiKey
//    {
//        set { apiKey = value; }
//    }

//    public void Log(string message)
//    {
//        Console.WriteLine($"Logging with API key: {apiKey.Substring(0, 3)}...");
//    }
//}
//82
//using System;

//class EmailService
//{
//    private string smtpPassword;

//    public string SMTPPassword
//    {
//        set { smtpPassword = value; }
//    }

//    public void SendEmail(string to, string subject)
//    {
//        Console.WriteLine($"Sending email to {to} using SMTP password");
//    }
//}
//83
//using System;

//class SecureConnection
//{
//    private string connectionString;

//    public string ConnectionString
//    {
//        set { connectionString = value; }
//    }

//    public void Connect()
//    {
//        Console.WriteLine($"Connecting with: {connectionString.Substring(0, 10)}...");
//    }
//}
//84
//using System;

//class Authenticator
//{
//    private string secret;

//    public string Secret
//    {
//        set { secret = value; }
//    }

//    public string GenerateToken()
//    {
//        return $"Token based on: {secret.Substring(0, 3)}...";
//    }
//}
//85
//using System;

//class PaymentService
//{
//    private string creditCard;

//    public string CreditCard
//    {
//        set { creditCard = value; }
//    }

//    public void ProcessPayment(decimal amount)
//    {
//        Console.WriteLine($"Processing payment of {amount} with card: {creditCard.Substring(creditCard.Length - 4)}");
//    }
//}
//86
//using System;

//class VPNClient
//{
//    private string vpnPassword;

//    public string VPNPassword
//    {
//        set { vpnPassword = value; }
//    }

//    public void ConnectToVPN()
//    {
//        Console.WriteLine("Connected to VPN securely");
//    }
//}
//87
//using System;

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person person = new Person("Анна", 25);
//        person.DisplayInfo();
//    }
//}
//88
//using System;

//class Student
//{
//    public int ID { get; set; }
//    public string Name { get; set; }

//    public Student(int id, string name)
//    {
//        ID = id;
//        Name = name;
//    }

//    public void ShowStudentInfo()
//    {
//        Console.WriteLine($"Студент ID: {ID}, Имя: {Name}");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Student student = new Student(101, "Мария Иванова");
//        student.ShowStudentInfo();
//    }
//}
//89
//using System;

//class Rectangle
//{
//    public double Length { get; set; }
//    public double Width { get; set; }

//    public Rectangle(double length, double width)
//    {
//        Length = length;
//        Width = width;
//    }

//    public double CalculateArea()
//    {
//        return Length * Width;
//    }

//    public double CalculatePerimeter()
//    {
//        return 2 * (Length + Width);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Rectangle rectangle = new Rectangle(5, 3);
//        Console.WriteLine($"Площадь: {rectangle.CalculateArea()}");
//        Console.WriteLine($"Периметр: {rectangle.CalculatePerimeter()}");
//    }
//}
//90
//using System;

//class Circle
//{
//    public double Radius { get; set; }

//    public Circle(double radius)
//    {
//        Radius = radius;
//    }

//    public double CalculateArea()
//    {
//        return Math.PI * Radius * Radius;
//    }

//    public double CalculateCircumference()
//    {
//        return 2 * Math.PI * Radius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Circle circle = new Circle(7);
//        Console.WriteLine($"Площадь круга: {circle.CalculateArea():F2}");
//        Console.WriteLine($"Длина окружности: {circle.CalculateCircumference():F2}");
//    }
//}
//using System;

//class BankAccount
//{
//    public string AccountNumber { get; set; }
//    public decimal Balance { get; set; }

//    public BankAccount(string accountNumber, decimal initialBalance)
//    {
//        AccountNumber = accountNumber;
//        Balance = initialBalance;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BankAccount account = new BankAccount("123456789", 1000.50m);
//        Console.WriteLine($"Счет: {account.AccountNumber}, Баланс: {account.Balance}");
//    }
//}

//91
//using System;

//class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int Year { get; set; }

//    public Car(string brand, string model, int year)
//    {
//        Brand = brand;
//        Model = model;
//        Year = year;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Car car = new Car("Toyota", "Camry", 2022);
//        Console.WriteLine($"Автомобиль: {car.Brand} {car.Model} {car.Year} года");
//    }
//}

//92
//using System;

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Pages { get; set; }

//    public Book(string title, string author, int pages)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book("Война и мир", "Лев Толстой", 1225);
//        Console.WriteLine($"Книга: '{book.Title}', автор: {book.Author}, страниц: {book.Pages}");
//    }
//}

//93
//using System;

//class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Pages { get; set; }

//    public Book(string title, string author, int pages)
//    {
//        Title = title;
//        Author = author;
//        Pages = pages;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Book book = new Book("Война и мир", "Лев Толстой", 1225);
//        Console.WriteLine($"Книга: '{book.Title}', автор: {book.Author}, страниц: {book.Pages}");
//    }
//}

//94
//using System;

//class Employee
//{
//    public string Name { get; set; }
//    public decimal Salary { get; set; }

//    public Employee(string name, decimal salary)
//    {
//        Name = name;
//        Salary = salary;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Employee employee = new Employee("Иван Сидоров", 75000.50m);
//        Console.WriteLine($"Сотрудник: {employee.Name}, Зарплата: {employee.Salary} руб.");
//    }
//}

//95
//using System;

//class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }

//    public Product(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Product product = new Product("Ноутбук", 59999.99m);
//        Console.WriteLine($"Товар: {product.Name}, Цена: {product.Price} руб.");
//    }
//}

//96
//using System;

//class House
//{
//    public string Address { get; set; }
//    public int Rooms { get; set; }

//    public House(string address, int rooms)
//    {
//        Address = address;
//        Rooms = rooms;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        House house = new House("ул. Ленина, д. 10", 4);
//        Console.WriteLine($"Дом по адресу: {house.Address}, Комнат: {house.Rooms}");
//    }
//}

//97
//using System;

//class Triangle
//{
//    public double SideA { get; set; }
//    public double SideB { get; set; }
//    public double SideC { get; set; }

//    public Triangle(double a, double b, double c)
//    {
//        SideA = a;
//        SideB = b;
//        SideC = c;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Triangle triangle = new Triangle(3, 4, 5);
//        Console.WriteLine($"Треугольник со сторонами: {triangle.SideA}, {triangle.SideB}, {triangle.SideC}");
//    }
//}
//98
//using System;

//class Time
//{
//    public int Hours { get; set; }
//    public int Minutes { get; set; }
//    public int Seconds { get; set; }

//    public Time(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Time time = new Time(14, 30, 45);
//        Console.WriteLine($"Время: {time.Hours:00}:{time.Minutes:00}:{time.Seconds:00}");
//    }
//}

//99
//using System;

//class Temperature
//{
//    public double Celsius { get; set; }

//    public Temperature(double celsius)
//    {
//        Celsius = celsius;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Temperature temp = new Temperature(23.5);
//        Console.WriteLine($"Температура: {temp.Celsius}°C");
//    }
//}
//100
//using System;

//class Color
//{
//    public int R { get; set; }
//    public int G { get; set; }
//    public int B { get; set; }

//    public Color(int r, int g, int b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Color color = new Color(255, 128, 0);
//        Console.WriteLine($"Цвет: RGB({color.R}, {color.G}, {color.B})");
//    }
//}