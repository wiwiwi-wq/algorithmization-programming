using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text.RegularExpressions;
using System.Diagnostics;

//1
//public class Counter
//{
//    private static int count = 0;

//    public static void Increment() => count++;
//    public static void Decrement() => count--;
//    public static int GetCount() => count;
//    public static void Reset() => count = 0;
//}

//2
//public static class Calculator
//{
//    public static double Add(double a, double b) => a + b;
//    public static double Subtract(double a, double b) => a - b;
//    public static double Multiply(double a, double b) => a * b;
//    public static double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
//}

//3
//public class StaticInitializer
//{
//    public static string AppName { get; private set; }
//    public static DateTime InitializationTime { get; private set; }

//    static StaticInitializer()
//    {
//        AppName = "MyApplication";
//        InitializationTime = DateTime.Now;
//    }
//}

//4
//public static class Logger
//{
//    private static readonly string logFile = "app.log";

//    public static void Log(string message)
//    {
//        string logEntry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
//        File.AppendAllText(logFile, logEntry + Environment.NewLine);
//    }
//}

//5
//public class Configuration
//{
//    private static string connectionString;

//    public static string ConnectionString
//    {
//        get => connectionString;
//        set => connectionString = value;
//    }
//}

//6
//public class ObjectCounter
//{
//    private static int objectCount = 0;

//    public ObjectCounter() => objectCount++;
//    ~ObjectCounter() => objectCount--;
//    public static int GetObjectCount() => objectCount;
//}

//7
//public static class ConfigManager
//{
//    private static readonly Dictionary<string, string> config = new Dictionary<string, string>();

//    public static void SetValue(string key, string value) => config[key] = value;
//    public static string GetValue(string key) => config.ContainsKey(key) ? config[key] : null;
//    public static void RemoveValue(string key) => config.Remove(key);
//}

//8
//public static class MathHelper
//{
//    public static double Power(double number, int exponent) => Math.Pow(number, exponent);
//    public static double SquareRoot(double number) => Math.Sqrt(number);
//    public static double Absolute(double number) => Math.Abs(number);
//    public static int Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
//}

//9
//public static class AppInfo
//{
//    public static readonly string Version = "1.0.0";
//    public static readonly string BuildDate = "2024-01-01";
//}

//10
//public static class ValidationHelper
//{
//    public static bool IsValidEmail(string email) =>
//        !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");

//    public static bool IsValidPhone(string phone) =>
//        !string.IsNullOrEmpty(phone) && phone.Length >= 10 && System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$");

//    public static bool IsStrongPassword(string password) =>
//        !string.IsNullOrEmpty(password) && password.Length >= 8;
//}

//11
//public static class DateTimeHelper
//{
//    public static int GetDaysBetween(DateTime start, DateTime end) => (end - start).Days;
//    public static bool IsWeekend(DateTime date) => date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
//    public static DateTime AddBusinessDays(DateTime date, int days) => date.AddDays(days);
//}

//12
//public static class StringHelper
//{
//    public static string Reverse(string input)
//    {
//        char[] charArray = input.ToCharArray();
//        Array.Reverse(charArray);
//        return new string(charArray);
//    }

//    public static string Truncate(string input, int maxLength) =>
//        input.Length <= maxLength ? input : input.Substring(0, maxLength) + "...";

//    public static bool IsNullOrEmpty(string input) => string.IsNullOrEmpty(input);
//}

//13
//public static class ApplicationState
//{
//    private static int activeUsers = 0;
//    private static string applicationMode = "Production";
//    private static DateTime startTime = DateTime.Now;

//    public static void UserLoggedIn() => activeUsers++;
//    public static void UserLoggedOut() => activeUsers--;
//    public static int GetActiveUsers() => activeUsers;
//    public static string GetApplicationMode() => applicationMode;
//    public static void SetApplicationMode(string mode) => applicationMode = mode;
//    public static TimeSpan GetUptime() => DateTime.Now - startTime;
//}

//14
//public static class FileHelper
//{
//    public static long GetFileSize(string filePath) => new FileInfo(filePath).Length;
//    public static string ReadAllText(string filePath) => File.ReadAllText(filePath);
//    public static void WriteAllText(string filePath, string content) => File.WriteAllText(filePath, content);
//    public static bool FileExists(string filePath) => File.Exists(filePath);
//    public static void DeleteFile(string filePath) => File.Delete(filePath);
//}

//15
//public static class Constants
//{
//    public const double PI = Math.PI;
//    public const double E = Math.E;
//    public const string COMPANY_NAME = "MyCompany";
//    public const int MAX_USERS = 1000;
//    public const int MIN_PASSWORD_LENGTH = 8;
//}

//16
//public static class HashHelper
//{
//    public static string ComputeMD5Hash(string input)
//    {
//        using (MD5 md5 = MD5.Create())
//        {
//            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
//            byte[] hashBytes = md5.ComputeHash(inputBytes);
//            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
//        }
//    }

//    public static string ComputeSHA256Hash(string input)
//    {
//        using (SHA256 sha256 = SHA256.Create())
//        {
//            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
//            byte[] hashBytes = sha256.ComputeHash(inputBytes);
//            return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
//        }
//    }
//}

//17
//public static class NotificationService
//{
//    public static event Action<string> OnMessage;
//    public static event Action<string, DateTime> OnTimedMessage;

//    public static void SendMessage(string message) => OnMessage?.Invoke(message);
//    public static void SendTimedMessage(string message) => OnTimedMessage?.Invoke(message, DateTime.Now);
//}

//18
//public static class ConversionHelper
//{
//    public static int StringToInt(string input) => int.TryParse(input, out int result) ? result : 0;
//    public static double StringToDouble(string input) => double.TryParse(input, out double result) ? result : 0.0;
//    public static DateTime StringToDateTime(string input) => DateTime.TryParse(input, out DateTime result) ? result : DateTime.MinValue;
//    public static string BytesToHex(byte[] bytes) => BitConverter.ToString(bytes).Replace("-", "");
//}

//19
//public static class ExecutionTimer
//{
//    public static TimeSpan MeasureAction(Action action)
//    {
//        var startTime = DateTime.Now;
//        action();
//        return DateTime.Now - startTime;
//    }

//    public static async Task<TimeSpan> MeasureAsyncAction(Func<Task> action)
//    {
//        var startTime = DateTime.Now;
//        await action();
//        return DateTime.Now - startTime;
//    }
//}

//20
//public static class RandomGenerator
//{
//    private static readonly Random random = new Random();

//    public static int NextInt(int min = 0, int max = 100) => random.Next(min, max);
//    public static double NextDouble(double min = 0, double max = 1) => random.NextDouble() * (max - min) + min;
//    public static bool NextBool() => random.Next(2) == 0;

//    public static string NextString(int length = 10)
//    {
//        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
//        return new string(Enumerable.Repeat(chars, length)
//            .Select(s => s[random.Next(s.Length)]).ToArray());
//    }
//}
//21
//public static class Utils
//{
//    public static bool IsNullOrEmpty(string value) => string.IsNullOrEmpty(value);
//    public static T CloneObject<T>(T obj) where T : class => MemberwiseClone(obj) as T;
//    private static object MemberwiseClone(object obj) => System.Runtime.FormatterServices.GetUninitializedObject(obj.GetType());
//}

//22
//public static class Extensions
//{
//    public static string Reverse(this string input) => new string(input.ToCharArray().Reverse().ToArray());
//    public static bool IsNumeric(this string input) => int.TryParse(input, out _);
//    public static string Truncate(this string input, int maxLength) => input.Length <= maxLength ? input : input.Substring(0, maxLength);
//}

//23
//public static class DatabaseHelper
//{
//    public static string ConnectionString { get; set; }
//    public static void ExecuteQuery(string query) => Console.WriteLine($"Executing: {query}");
//    public static object GetScalar(string query) => null;
//}

//24
//public static class CryptographyHelper
//{
//    public static string Encrypt(string plainText) => Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
//    public static string Decrypt(string encryptedText) => Encoding.UTF8.GetString(Convert.FromBase64String(encryptedText));
//}

//25
//public static class HttpHelper
//{
//    public static string Get(string url) => $"GET response from {url}";
//    public static string Post(string url, string data) => $"POST response from {url}";
//    public static async Task<string> GetAsync(string url) => await Task.Run(() => Get(url));
//}

//26
//public static class JsonHelper
//{
//    public static string Serialize(object obj) => System.Text.Json.JsonSerializer.Serialize(obj);
//    public static T Deserialize<T>(string json) => System.Text.Json.JsonSerializer.Deserialize<T>(json);
//}

//27
//public static class RegexHelper
//{
//    public static readonly System.Text.RegularExpressions.Regex EmailRegex = new System.Text.RegularExpressions.Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//    public static readonly System.Text.RegularExpressions.Regex PhoneRegex = new System.Text.RegularExpressions.Regex(@"^\d{10,15}$");
//    public static bool IsValidEmail(string email) => EmailRegex.IsMatch(email);
//}

//28
//public static class ImageProcessor
//{
//    public static void Resize(string imagePath, int width, int height) => Console.WriteLine($"Resizing {imagePath} to {width}x{height}");
//    public static void Compress(string imagePath, int quality) => Console.WriteLine($"Compressing {imagePath} with quality {quality}");
//}

//29
//public static class EmailValidator
//{
//    public static bool IsValidEmail(string email) =>
//        !string.IsNullOrEmpty(email) &&
//        email.Contains("@") &&
//        email.Contains(".") &&
//        email.Length > 5;

//    public static bool IsValidDomain(string email) => email.EndsWith(".com") || email.EndsWith(".ru") || email.EndsWith(".org");
//}

//30
//public static class PasswordGenerator
//{
//    private static readonly Random random = new Random();
//    private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*";

//    public static string Generate(int length = 12) =>
//        new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
//}

//31
//public static class XmlHelper
//{
//    public static string Serialize(object obj)
//    {
//        var serializer = new System.Xml.Serialization.XmlSerializer(obj.GetType());
//        using var writer = new StringWriter();
//        serializer.Serialize(writer, obj);
//        return writer.ToString();
//    }

//    public static T Deserialize<T>(string xml)
//    {
//        var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
//        using var reader = new StringReader(xml);
//        return (T)serializer.Deserialize(reader);
//    }
//}

//32
//public static class NetworkHelper
//{
//    public static bool IsConnected() => true;
//    public static string GetLocalIP() => "127.0.0.1";
//    public static bool PingHost(string host) => true;
//}

//33
//public static class SecurityHelper
//{
//    public static string GenerateSalt() => Guid.NewGuid().ToString();
//    public static string HashPassword(string password, string salt) =>
//        Convert.ToBase64String(System.Security.Cryptography.SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password + salt)));
//}

//34
//public static class PathHelper
//{
//    public static string Combine(params string[] paths) => Path.Combine(paths);
//    public static string GetFileName(string path) => Path.GetFileName(path);
//    public static string GetDirectoryName(string path) => Path.GetDirectoryName(path);
//}

//35
//public static class ColorHelper
//{
//    public static string RgbToHex(int r, int g, int b) => $"#{r:X2}{g:X2}{b:X2}";
//    public static (int r, int g, int b) HexToRgb(string hex) => (255, 255, 255);
//    public static string InvertColor(string hexColor) => "#000000";
//}

//36
//public static class CompressionHelper
//{
//    public static byte[] Compress(byte[] data) => data;
//    public static byte[] Decompress(byte[] compressedData) => compressedData;
//    public static void CompressFile(string sourceFile, string compressedFile) => File.Copy(sourceFile, compressedFile);
//}

//37
//public static class EnvironmentHelper
//{
//    public static string GetVariable(string variableName) => Environment.GetEnvironmentVariable(variableName);
//    public static void SetVariable(string variableName, string value) => Environment.SetEnvironmentVariable(variableName, value);
//    public static bool Is64BitProcess() => Environment.Is64BitProcess;
//}

//38
//public static class UrlHelper
//{
//    public static string Combine(string baseUrl, string relativeUrl) => $"{baseUrl.TrimEnd('/')}/{relativeUrl.TrimStart('/')}";
//    public static Dictionary<string, string> ParseQueryString(string url) => new Dictionary<string, string>();
//    public static bool IsValidUrl(string url) => Uri.TryCreate(url, UriKind.Absolute, out _);
//}

//39
//public static class TextProcessor
//{
//    public static string RemoveExtraSpaces(string text) => System.Text.RegularExpressions.Regex.Replace(text, @"\s+", " ");
//    public static int WordCount(string text) => text.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
//    public static string CapitalizeFirstLetter(string text) => char.ToUpper(text[0]) + text.Substring(1);
//}

//40
//public static class SystemInfo
//{
//    public static string OSVersion => Environment.OSVersion.ToString();
//    public static string MachineName => Environment.MachineName;
//    public static long TotalMemory => GC.GetGCMemoryInfo().TotalAvailableMemoryBytes;
//    public static int ProcessorCount => Environment.ProcessorCount;
//}
//41
//public static class StringExtensions
//{
//    public static bool IsPalindrome(this string str)
//    {
//        if (string.IsNullOrEmpty(str)) return false;
//        string clean = new string(str.Where(char.IsLetterOrDigit).ToArray()).ToLower();
//        return clean.SequenceEqual(clean.Reverse());
//    }
//}

//42
//public static class ArrayExtensions
//{
//    private static Random rnd = new Random();
//    public static T GetRandomElement<T>(this T[] array) => array.Length == 0 ? default : array[rnd.Next(array.Length)];
//}

//43
//public static class IntExtensions
//{
//    public static bool IsEven(this int number) => number % 2 == 0;
//}

//44
//public static class DateTimeExtensions
//{
//    public static int GetAge(this DateTime birthDate)
//    {
//        var today = DateTime.Today;
//        int age = today.Year - birthDate.Year;
//        if (birthDate.Date > today.AddYears(-age)) age--;
//        return age;
//    }
//}

//45
//public static class StringExtensions
//{
//    public static string RemoveAllSpaces(this string str) => str.Replace(" ", "");
//}

//46
//public static class ListExtensions
//{
//    private static Random rnd = new Random();
//    public static void Shuffle<T>(this IList<T> list)
//    {
//        for (int i = list.Count - 1; i > 0; i--)
//        {
//            int j = rnd.Next(i + 1);
//            (list[i], list[j]) = (list[j], list[i]);
//        }
//    }
//}

//47
//public static class StringExtensions
//{
//    public static string ToTitleCase(this string str) =>
//        System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
//}

//48
//public static class IntExtensions
//{
//    public static string ToRoman(this int number)
//    {
//        if (number < 1 || number > 3999) return number.ToString();

//        var romanNumerals = new[]
//        {
//            new { Value = 1000, Symbol = "M" }, new { Value = 900, Symbol = "CM" },
//            new { Value = 500, Symbol = "D" }, new { Value = 400, Symbol = "CD" },
//            new { Value = 100, Symbol = "C" }, new { Value = 90, Symbol = "XC" },
//            new { Value = 50, Symbol = "L" }, new { Value = 40, Symbol = "XL" },
//            new { Value = 10, Symbol = "X" }, new { Value = 9, Symbol = "IX" },
//            new { Value = 5, Symbol = "V" }, new { Value = 4, Symbol = "IV" },
//            new { Value = 1, Symbol = "I" }
//        };

//        string result = "";
//        foreach (var numeral in romanNumerals)
//        {
//            while (number >= numeral.Value)
//            {
//                result += numeral.Symbol;
//                number -= numeral.Value;
//            }
//        }
//        return result;
//    }
//}

//49
//public static class CollectionExtensions
//{
//    public static bool IsNotEmpty<T>(this ICollection<T> collection) => collection?.Count > 0;
//}

//50
//public static class StringExtensions
//{
//    public static int WordCount(this string str) =>
//        string.IsNullOrEmpty(str) ? 0 : str.Split(new[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
//}

//51
//public static class ArrayExtensions
//{
//    public static double Median(this int[] array)
//    {
//        if (array == null || array.Length == 0)
//            throw new ArgumentException("Массив не может быть пустым.");

//        var sortedArray = array.OrderBy(x => x).ToArray();
//        int length = sortedArray.Length;

//        if (length % 2 == 0)
//            return (sortedArray[length / 2 - 1] + sortedArray[length / 2]) / 2.0;
//        else
//            return sortedArray[length / 2];
//    }
//}


//52
//public static class DateTimeExtensions
//{
//    public static DateTime StartOfWeek(this DateTime date)
//    {
//        int diff = date.DayOfWeek - DayOfWeek.Monday;
//        if (diff < 0)
//            diff += 7;
//        return date.AddDays(-diff).Date;
//    }
//}


//53
//public static class StringExtensions
//{
//    public static string StripNonHtmlTags(this string input)
//    {
//        return Regex.Replace(input, @"<[^>]+>|[^<]+", match =>
//            match.Value.StartsWith("<") ? match.Value : string.Empty);
//    }
//}


//54
//public static class IntExtensions
//{
//    public static bool IsPrime(this int number)
//    {
//        if (number <= 1) return false;
//        if (number == 2) return true;
//        if (number % 2 == 0) return false;

//        for (int i = 3; i * i <= number; i += 2)
//            if (number % i == 0)
//                return false;

//        return true;
//    }
//}


//55
//public static class CollectionExtensions
//{
//    public static ILookup<int, T> GroupBySize<T>(this IEnumerable<T> collection, Func<T, int> sizeSelector)
//    {
//        return collection.ToLookup(sizeSelector);
//    }
//}


//56
//public static class StringExtensions
//{
//    public static string ToBase64(this string input)
//    {
//        byte[] bytes = Encoding.UTF8.GetBytes(input);
//        return Convert.ToBase64String(bytes);
//    }
//}


//57
//public static class ArrayExtensions
//{
//    public static int SecondMax(this int[] array)
//    {
//        if (array == null || array.Length < 2)
//            throw new ArgumentException("Массив должен содержать хотя бы два элемента.");

//        int max = int.MinValue;
//        int secondMax = int.MinValue;

//        foreach (int num in array)
//        {
//            if (num > max)
//            {
//                secondMax = max;
//                max = num;
//            }
//            else if (num > secondMax && num != max)
//            {
//                secondMax = num;
//            }
//        }

//        return secondMax;
//    }
//}


//58
//public static class DateTimeExtensions
//{
//    public static string ToReadableFormat(this DateTime date)
//    {
//        return date.ToString("dd MMMM yyyy, dddd, HH:mm");
//    }
//}


//59
//public static class StringExtensions
//{
//    public static string NormalizeSpaces(this string input)
//    {
//        return Regex.Replace(input, @"\s+", " ").Trim();
//    }
//}


//60
//public static class LongExtensions
//{
//    public static string ToReadableSize(this long bytes)
//    {
//        string[] sizes = { "B", "KB", "MB", "GB", "TB" };
//        int order = 0;
//        double len = bytes;

//        while (len >= 1024 && order < sizes.Length - 1)
//        {
//            order++;
//            len /= 1024;
//        }

//        return $"{len:0.##} {sizes[order]}";
//    }
//}


//61
//public class Car
//{
//    public string Brand { get; set; }

//    public class Engine
//    {
//        public string Type { get; set; }
//        public int Power { get; set; }
//    }

//    public Engine CarEngine { get; set; }
//}




//62
//public class Library
//{
//    public string Name { get; set; }

//    public class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//    }

//    public List<Book> Books { get; set; } = new List<Book>();
//}



//63
//public class Computer
//{
//    private class CPU
//    {
//        public string Model { get; set; }
//    }

//    private class RAM
//    {
//        public int Size { get; set; }
//    }

//    private CPU Processor { get; set; }
//    private RAM Memory { get; set; }
//}



//64
//public class University
//{
//    protected class Student
//    {
//        public string Name { get; set; }
//        public int Course { get; set; }
//    }
//}


//65
//public class BankAccount
//{
//    public string AccountNumber { get; set; }

//    public class Transaction
//    {
//        public decimal Amount { get; set; }
//        public DateTime Date { get; set; }
//    }
//}


//66
//public class Game
//{
//    public static class Rules
//    {
//        public static string Description { get; set; }
//    }
//}


//67
//public class TreeNode<T>
//{
//    public T Value { get; set; }

//    public class PreOrderTraversal
//    {
//        public void Traverse(TreeNode<T> node)
//        {
//            if (node != null)
//            {
//                // Process node
//                Traverse(node.Left);
//                Traverse(node.Right);
//            }
//        }
//    }

//    public TreeNode<T> Left { get; set; }
//    public TreeNode<T> Right { get; set; }
//}


//68
//public class Calculator
//{
//    public class Addition
//    {
//        public static int Perform(int a, int b)
//        {
//            return a + b;
//        }
//    }

//    public class Multiplication
//    {
//        public static int Perform(int a, int b)
//        {
//            return a * b;
//        }
//    }
//}



//69
//public class Document
//{
//    public class Page
//    {
//        public int Number { get; set; }
//        public string Content { get; set; }
//    }

//    public List<Page> Pages { get; set; } = new List<Page>();
//}


//70
//public class Network
//{
//    public class Node
//    {
//        public string Name { get; set; }
//    }

//    public class Connection
//    {
//        public Node From { get; set; }
//        public Node To { get; set; }
//    }

//    public List<Node> Nodes { get; set; } = new List<Node>();
//    public List<Connection> Connections { get; set; } = new List<Connection>();
//}


//71
//public class House
//{
//    public class Room
//    {
//        public string Name { get; set; }
//    }

//    public class Furniture
//    {
//        public string Type { get; set; }
//    }

//    public List<Room> Rooms { get; set; } = new List<Room>();
//}


//72
//public class Phone
//{
//    public class Contact
//    {
//        public string Name { get; set; }
//        public string Number { get; set; }
//    }

//    public class Message
//    {
//        public string Text { get; set; }
//    }

//    public List<Contact> Contacts { get; set; } = new List<Contact>();
//    public List<Message> Messages { get; set; } = new List<Message>();
//}


//73
//public class Restaurant
//{
//    public class Dish
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//    }

//    public class Order
//    {
//        public List<Dish> Items { get; set; } = new List<Dish>();
//    }

//    public List<Dish> Menu { get; set; } = new List<Dish>();
//}


//74
//public class School
//{
//    public class Teacher
//    {
//        public string Name { get; set; }
//    }

//    public class Class
//    {
//        public string Name { get; set; }
//    }

//    public List<Teacher> Teachers { get; set; } = new List<Teacher>();
//    public List<Class> Classes { get; set; } = new List<Class>();
//}


//75
//public class LinkedList<T>
//{
//    public class Node
//    {
//        public T Value { get; set; }
//        public Node Next { get; set; }
//    }

//    public Node Head { get; set; }
//}


//76
//public class Email
//{
//    public class Attachment
//    {
//        public string FileName { get; set; }
//    }

//    public class Header
//    {
//        public string Subject { get; set; }
//    }

//    public Header EmailHeader { get; set; } = new Header();
//    public List<Attachment> Attachments { get; set; } = new List<Attachment>();
//}


//77
//public class Team
//{
//    public class Player
//    {
//        public string Name { get; set; }
//    }

//    public class Coach
//    {
//        public string Name { get; set; }
//    }

//    public List<Player> Players { get; set; } = new List<Player>();
//    public Coach HeadCoach { get; set; }
//}


//78
//public class Shape
//{
//    public class Circle
//    {
//        public double Radius { get; set; }
//    }

//    public class Rectangle
//    {
//        public double Width { get; set; }
//        public double Height { get; set; }
//    }
//}


//79
//public class Database
//{
//    public class Column
//    {
//        public string Name { get; set; }
//    }

//    public class Table
//    {
//        public string Name { get; set; }
//        public List<Column> Columns { get; set; } = new List<Column>();
//    }

//    public List<Table> Tables { get; set; } = new List<Table>();
//}


//80
//public class Shop
//{
//    public class Product
//    {
//        public string Name { get; set; }
//        public decimal Price { get; set; }
//    }

//    public class Category
//    {
//        public string Name { get; set; }
//        public List<Product> Products { get; set; } = new List<Product>();
//    }

//    public List<Category> Categories { get; set; } = new List<Category>();
//}


//81
//public sealed class DatabaseConnection
//{
//    private static DatabaseConnection _instance;
//    private static readonly object _lock = new object();

//    private DatabaseConnection() { }

//    public static DatabaseConnection Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new DatabaseConnection();
//                }
//                return _instance;
//            }
//        }
//    }
//}


//82
//public sealed class Logger
//{
//    private static volatile Logger _instance;
//    private static readonly object _lock = new object();

//    private Logger() { }

//    public static Logger Instance
//    {
//        get
//        {
//            if (_instance == null)
//            {
//                lock (_lock)
//                {
//                    if (_instance == null)
//                    {
//                        _instance = new Logger();
//                    }
//                }
//            }
//            return _instance;
//        }
//    }
//}


//83
//public sealed class ExampleClass
//{
//    private static readonly Lazy<ExampleClass> _instance =
//        new Lazy<ExampleClass>(() => new ExampleClass(), isThreadSafe: true);

//    private ExampleClass() { }

//    public static ExampleClass Instance => _instance.Value;
//}


//84
//public sealed class ExampleClass
//{
//    private static volatile ExampleClass _instance;
//    private static readonly object _lock = new object();

//    private ExampleClass() { }

//    public static ExampleClass Instance
//    {
//        get
//        {
//            if (_instance == null)
//            {
//                lock (_lock)
//                {
//                    if (_instance == null)
//                    {
//                        _instance = new ExampleClass();
//                    }
//                }
//            }
//            return _instance;
//        }
//    }
//}


//85
//public sealed class ConfigurationManager
//{
//    private static readonly Lazy<ConfigurationManager> _instance =
//        new Lazy<ConfigurationManager>(() => new ConfigurationManager(), isThreadSafe: true);

//    private ConfigurationManager() { }

//    public static ConfigurationManager Instance => _instance.Value;
//}


//86
//public sealed class ExampleClass
//{
//    private static readonly ExampleClass _instance = new ExampleClass();

//    static ExampleClass() { }

//    private ExampleClass() { }

//    public static ExampleClass Instance => _instance;
//}


//87
//public sealed class ApplicationSettings
//{
//    public static ApplicationSettings Instance { get; } = new ApplicationSettings();

//    static ApplicationSettings() { }

//    private ApplicationSettings() { }
//}


//88
//public abstract class Singleton<T> where T : class
//{
//    private static readonly Lazy<T> _instance = new Lazy<T>(() => CreateInstance(), isThreadSafe: true);

//    public static T Instance => _instance.Value;

//    private static T CreateInstance()
//    {
//        return Activator.CreateInstance(typeof(T), true) as T;
//    }
//}


//89
//public sealed class ExampleClass
//{
//    private static ExampleClass _instance;
//    private static readonly object _lock = new object();

//    private ExampleClass() { }

//    public static ExampleClass Instance
//    {
//        get
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new ExampleClass();
//                }
//                return _instance;
//            }
//        }
//    }

//    public void Reset()
//    {
//        lock (_lock)
//        {
//            _instance = null;
//        }
//    }
//}


//90
//public sealed class CacheManager
//{
//    private static readonly Lazy<CacheManager> _instance =
//        new Lazy<CacheManager>(() => new CacheManager(), isThreadSafe: true);

//    private Dictionary<string, object> _cache = new Dictionary<string, object>();

//    private CacheManager() { }

//    public static CacheManager Instance => _instance.Value;

//    public void Add(string key, object value)
//    {
//        _cache[key] = value;
//    }

//    public object Get(string key)
//    {
//        _cache.TryGetValue(key, out object value);
//        return value;
//    }
//}


//91
//public sealed class FileManager
//{
//    private static readonly Lazy<FileManager> _instance =
//        new Lazy<FileManager>(() => new FileManager(), isThreadSafe: true);

//    private FileManager() { }

//    public static FileManager Instance => _instance.Value;

//    public bool FileExists(string path)
//    {
//        return File.Exists(path);
//    }
//}


//92
//public sealed class RandomNumberGenerator
//{
//    private static readonly Lazy<RandomNumberGenerator> _instance =
//        new Lazy<RandomNumberGenerator>(() => new RandomNumberGenerator(), isThreadSafe: true);

//    private readonly Random _random = new Random();

//    private RandomNumberGenerator() { }

//    public static RandomNumberGenerator Instance => _instance.Value;

//    public int GenerateRandomNumber(int min, int max)
//    {
//        lock (_random)
//        {
//            return _random.Next(min, max);
//        }
//    }
//}


//93
//public sealed class ApplicationStateManager
//{
//    private static readonly Lazy<ApplicationStateManager> _instance =
//        new Lazy<ApplicationStateManager>(() => new ApplicationStateManager(), isThreadSafe: true);

//    private ApplicationStateManager() { }

//    public static ApplicationStateManager Instance => _instance.Value;

//    public void SaveState(string state, string filePath)
//    {
//        File.WriteAllText(filePath, state);
//    }

//    public string LoadState(string filePath)
//    {
//        return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
//    }
//}


//94
//public sealed class SecurityManager
//{
//    private static readonly Lazy<SecurityManager> _instance =
//        new Lazy<SecurityManager>(() => new SecurityManager(), isThreadSafe: true);

//    private SecurityManager() { }

//    public static SecurityManager Instance => _instance.Value;

//    public bool Authenticate(string username, string password)
//    {
//        // Логика аутентификации
//        return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
//    }
//}


//95
//public sealed class PerformanceCounterManager
//{
//    private static readonly Lazy<PerformanceCounterManager> _instance =
//        new Lazy<PerformanceCounterManager>(() => new PerformanceCounterManager(), isThreadSafe: true);

//    private PerformanceCounterManager() { }

//    public static PerformanceCounterManager Instance => _instance.Value;

//    public long GetMemoryUsage()
//    {
//        return Process.GetCurrentProcess().PrivateMemorySize64;
//    }
//}


//96
//public sealed class EmailService
//{
//    private static readonly Lazy<EmailService> _instance =
//        new Lazy<EmailService>(() => new EmailService(), isThreadSafe: true);

//    private EmailService() { }

//    public static EmailService Instance => _instance.Value;

//    public void SendEmail(string to, string subject, string body)
//    {
//        using (var client = new SmtpClient())
//        {
//            var message = new MailMessage("from@example.com", to, subject, body);
//            client.Send(message);
//        }
//    }
//}


//97
//public sealed class PrintManager
//{
//    private static readonly Lazy<PrintManager> _instance =
//        new Lazy<PrintManager>(() => new PrintManager(), isThreadSafe: true);

//    private Queue<string> _printQueue = new Queue<string>();

//    private PrintManager() { }

//    public static PrintManager Instance => _instance.Value;

//    public void AddToQueue(string document)
//    {
//        _printQueue.Enqueue(document);
//    }

//    public string PrintNext()
//    {
//        return _printQueue.Count > 0 ? _printQueue.Dequeue() : null;
//    }
//}


//98
//public sealed class SessionManager
//{
//    private static readonly Lazy<SessionManager> _instance =
//        new Lazy<SessionManager>(() => new SessionManager(), isThreadSafe: true);

//    private Dictionary<string, object> _sessions = new Dictionary<string, object>();

//    private SessionManager() { }

//    public static SessionManager Instance => _instance.Value;

//    public void AddSession(string sessionId, object sessionData)
//    {
//        _sessions[sessionId] = sessionData;
//    }

//    public object GetSession(string sessionId)
//    {
//        _sessions.TryGetValue(sessionId, out object sessionData);
//        return sessionData;
//    }
//}


//99
//public sealed class NotificationService
//{
//    private static readonly Lazy<NotificationService> _instance =
//        new Lazy<NotificationService>(() => new NotificationService(), isThreadSafe: true);

//    private NotificationService() { }

//    public static NotificationService Instance => _instance.Value;

//    public void SendNotification(string message)
//    {
//        Console.WriteLine($"Notification: {message}");
//    }
//}


//100
//public sealed class ResourcePoolManager<T> where T : class, new()
//{
//    private static readonly Lazy<ResourcePoolManager<T>> _instance =
//        new Lazy<ResourcePoolManager<T>>(() => new ResourcePoolManager<T>(), isThreadSafe: true);

//    private Queue<T> _resourcePool = new Queue<T>();

//    private ResourcePoolManager()
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            _resourcePool.Enqueue(new T());
//        }
//    }

//    public static ResourcePoolManager<T> Instance => _instance.Value;

//    public T GetResource()
//    {
//        return _resourcePool.Count > 0 ? _resourcePool.Dequeue() : new T();
//    }

//    public void ReturnResource(T resource)
//    {
//        _resourcePool.Enqueue(resource);
//    }
//}
