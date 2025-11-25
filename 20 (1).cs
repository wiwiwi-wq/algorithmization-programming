//using System.Text.Json;
//using System.Collections.ObjectModel;

////1
//using System;

//// Общий класс с ограничением T : class
//public class ReferenceTypeContainer<T> where T : class
//{
//    private T _value;

//    public ReferenceTypeContainer(T value)
//    {
//        _value = value;
//    }

//    public void PrintType()
//    {
//        Console.WriteLine($"Тип: {typeof(T).Name}");
//    }

//    public T GetValue()
//    {
//        return _value;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        ReferenceTypeContainer<string> stringContainer = new ReferenceTypeContainer<string>("Привет, мир!");
//        stringContainer.PrintType();
//        Console.WriteLine($"Значение: {stringContainer.GetValue()}");

//        // ReferenceTypeContainer<int> intContainer = new ReferenceTypeContainer<int>(10); // Ошибка: int — значимый тип
//    }
//}


////2
//using System;

//// Общий класс с ограничением T : struct
//public class ValueTypeContainer<T> where T : struct
//{
//    private T _value;

//    public ValueTypeContainer(T value)
//    {
//        _value = value;
//    }

//    public void PrintType()
//    {
//        Console.WriteLine($"Тип: {typeof(T).Name}");
//    }

//    public T GetValue()
//    {
//        return _value;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        ValueTypeContainer<int> intContainer = new ValueTypeContainer<int>(42);
//        intContainer.PrintType();
//        Console.WriteLine($"Значение: {intContainer.GetValue()}");

//        // ValueTypeContainer<string> stringContainer = new ValueTypeContainer<string>("Ошибка"); // Ошибка: string — ссылочный тип
//    }
//}


////3
//using System;

//// Класс с универсальным методом и ограничением T : new()
//public class Creator<T> where T : new()
//{
//    public T CreateInstance()
//    {
//        return new T();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Creator<MyClass> creator = new Creator<MyClass>();
//        MyClass instance = creator.CreateInstance();
//        instance.SayHello();
//    }
//}

//public class MyClass
//{
//    public void SayHello()
//    {
//        Console.WriteLine("Привет!");
//    }
//}


////4
//using System;

//// Общий класс с ограничением T : IComparable
//public class ComparableContainer<T> where T : IComparable<T>
//{
//    private T _value;

//    public ComparableContainer(T value)
//    {
//        _value = value;
//    }

//    public int CompareTo(T other)
//    {
//        return _value.CompareTo(other);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        ComparableContainer<int> intContainer = new ComparableContainer<int>(10);
//        Console.WriteLine(intContainer.CompareTo(5));  // 1
//        Console.WriteLine(intContainer.CompareTo(20)); // -1
//    }
//}


////5
//using System;
//using System.Collections.Generic;

//// Класс с универсальным методом и ограничением T : IEnumerable<T>
//public class EnumerablePrinter
//{
//    public void PrintAll<T>(IEnumerable<T> collection)
//    {
//        foreach (var item in collection)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        EnumerablePrinter printer = new EnumerablePrinter();
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        printer.PrintAll(numbers);
//    }
//}


////6
//using System;

//// Базовый класс
//public class BaseClass
//{
//    public virtual void Print()
//    {
//        Console.WriteLine("Это BaseClass");
//    }
//}

//// Производный класс
//public class DerivedClass : BaseClass
//{
//    public override void Print()
//    {
//        Console.WriteLine("Это DerivedClass");
//    }
//}

//// Общий класс с ограничением T : BaseClass
//public class InheritanceConstraint<T> where T : BaseClass
//{
//    private T _instance;

//    public InheritanceConstraint(T instance)
//    {
//        _instance = instance;
//    }

//    public void CallPrint()
//    {
//        _instance.Print();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        DerivedClass derived = new DerivedClass();
//        InheritanceConstraint<DerivedClass> container = new InheritanceConstraint<DerivedClass>(derived);
//        container.CallPrint(); // Выведет: "Это DerivedClass"
//    }
//}


////7
//using System;

//// Универсальный метод с ограничением T : class, IDisposable
//public class DisposableHandler
//{
//    public void HandleResource<T>(T resource) where T : class, IDisposable
//    {
//        try
//        {
//            Console.WriteLine("Работаем с ресурсом...");
//        }
//        finally
//        {
//            resource.Dispose();
//            Console.WriteLine("Ресурс освобождён.");
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        DisposableHandler handler = new DisposableHandler();
//        using (var disposableObject = new System.IO.MemoryStream())
//        {
//            handler.HandleResource(disposableObject);
//        }
//    }
//}


////8
//using System;

//// Общий интерфейс с ограничением T : IEquatable<T>
//public interface IEquatableContainer<T> where T : IEquatable<T>
//{
//    bool AreEqual(T a, T b);
//}

//// Реализация интерфейса
//public class EquatableContainer<T> : IEquatableContainer<T> where T : IEquatable<T>
//{
//    public bool AreEqual(T a, T b)
//    {
//        return a.Equals(b);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        EquatableContainer<int> container = new EquatableContainer<int>();
//        Console.WriteLine(container.AreEqual(5, 5)); // True
//        Console.WriteLine(container.AreEqual(5, 10)); // False
//    }
//}


////9
//using System;
//using System.Collections.Generic;

//// Общий класс Репозиторий с ограничением T : class, new()
//public class Repository<T> where T : class, new()
//{
//    private List<T> _items = new List<T>();

//    public void Add(T item)
//    {
//        _items.Add(item);
//    }

//    public T CreateNew()
//    {
//        T newItem = new T();
//        _items.Add(newItem);
//        return newItem;
//    }

//    public void PrintAll()
//    {
//        foreach (var item in _items)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Repository<MyEntity> repo = new Repository<MyEntity>();
//        repo.Add(new MyEntity { Id = 1, Name = "Сущность 1" });
//        repo.CreateNew();
//        repo.PrintAll();
//    }
//}

//public class MyEntity
//{
//    public int Id { get; set; }
//    public string Name { get; set; }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}";
//    }
//}


////10
//using System;

//// Универсальный метод для сравнения с ограничением T : IComparable<T>
//public class Comparer
//{
//    public int Compare<T>(T a, T b) where T : IComparable<T>
//    {
//        return a.CompareTo(b);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Comparer comparer = new Comparer();
//        Console.WriteLine(comparer.Compare(10, 5));  // 1
//        Console.WriteLine(comparer.Compare(5, 10));  // -1
//        Console.WriteLine(comparer.Compare(5, 5));   // 0
//    }
//}


////11
//using System;
//using System.IO;

//// Общий класс с ограничением на конкретный тип T : Stream
//public class StreamProcessor<T> where T : Stream
//{
//    public void Process(T stream)
//    {
//        if (stream.CanRead)
//        {
//            Console.WriteLine("Поток поддерживает чтение.");
//        }
//        if (stream.CanWrite)
//        {
//            Console.WriteLine("Поток поддерживает запись.");
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        using (var memoryStream = new MemoryStream())
//        {
//            StreamProcessor<MemoryStream> processor = new StreamProcessor<MemoryStream>();
//            processor.Process(memoryStream);
//        }
//    }
//}


////12
//using System;

//// Универсальный метод Clone с ограничением T : class, ICloneable
//public class Cloner
//{
//    public T Clone<T>(T obj) where T : class, ICloneable
//    {
//        return (T)obj.Clone();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var original = new MyCloneableClass { Value = 42 };
//        Cloner cloner = new Cloner();
//        var cloned = cloner.Clone(original);

//        Console.WriteLine($"Оригинал: {original.Value}");
//        Console.WriteLine($"Клон: {cloned.Value}");
//    }
//}

//public class MyCloneableClass : ICloneable
//{
//    public int Value { get; set; }

//    public object Clone()
//    {
//        return new MyCloneableClass { Value = this.Value };
//    }
//}


////13
//using System;
//using System.Collections.Generic;

//// Общий класс для работы с коллекциями с ограничением T : ICollection<T>
//public class CollectionHelper<T> where T : ICollection<int>
//{
//    public void PrintCollection(T collection)
//    {
//        foreach (var item in collection)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        CollectionHelper<List<int>> helper = new CollectionHelper<List<int>>();
//        helper.PrintCollection(numbers);
//    }
//}


////14
//using System;
//using System.Collections.Generic;

//// Универсальный метод для поиска с ограничением T : IEquatable<T>
//public class Searcher
//{
//    public bool Contains<T>(IEnumerable<T> collection, T item) where T : IEquatable<T>
//    {
//        foreach (var element in collection)
//        {
//            if (element.Equals(item))
//                return true;
//        }
//        return false;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        Searcher searcher = new Searcher();
//        Console.WriteLine(searcher.Contains(numbers, 3)); // True
//        Console.WriteLine(searcher.Contains(numbers, 10)); // False
//    }
//}


////15
//using System;
//using System.Text.Json;

//// Общий класс Сериализатор с ограничением T : class, new()
//public class Serializer<T> where T : class, new()
//{
//    public string Serialize(T obj)
//    {
//        return JsonSerializer.Serialize(obj);
//    }

//    public T Deserialize(string json)
//    {
//        return JsonSerializer.Deserialize<T>(json);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var original = new MySerializableClass { Name = "Тест", Value = 123 };
//        Serializer<MySerializableClass> serializer = new Serializer<MySerializableClass>();

//        string json = serializer.Serialize(original);
//        Console.WriteLine(json);

//        var deserialized = serializer.Deserialize(json);
//        Console.WriteLine($"Имя: {deserialized.Name}, Значение: {deserialized.Value}");
//    }
//}

//public class MySerializableClass
//{
//    public string Name { get; set; }
//    public int Value { get; set; }
//}


////16
//using System;

//// Интерфейс для валидации
//public interface IValidatable
//{
//    bool IsValid();
//}

//// Универсальный метод для валидации с ограничением T : IValidatable
//public class Validator
//{
//    public bool Validate<T>(T obj) where T : IValidatable
//    {
//        return obj.IsValid();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var validObject = new MyValidatableClass { Age = 25 };
//        var invalidObject = new MyValidatableClass { Age = -5 };

//        Validator validator = new Validator();
//        Console.WriteLine(validator.Validate(validObject));   // True
//        Console.WriteLine(validator.Validate(invalidObject)); // False
//    }
//}

//public class MyValidatableClass : IValidatable
//{
//    public int Age { get; set; }

//    public bool IsValid()
//    {
//        return Age >= 0;
//    }
//}


////17
//using System;

//// Интерфейс для парсинга
//public interface IParsable<T>
//{
//    T Parse(string input);
//}

//// Общий класс Parser с ограничением T : IParsable<T>
//public class Parser<T> where T : IParsable<T>, new()
//{
//    public T ParseString(string input)
//    {
//        T parser = new T();
//        return parser.Parse(input);
//    }
//}

//// Пример реализации IParsable<T>
//public class IntParser : IParsable<int>
//{
//    public int Parse(string input)
//    {
//        return int.Parse(input);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Parser<IntParser> intParser = new Parser<IntParser>();
//        int result = intParser.ParseString("123");
//        Console.WriteLine($"Результат парсинга: {result}");
//    }
//}


////18
//using System;

//// Универсальный интерфейс Factory с ограничением T : class, new()
//public interface IFactory<T> where T : class, new()
//{
//    T Create();
//}

//// Реализация интерфейса
//public class Factory<T> : IFactory<T> where T : class, new()
//{
//    public T Create()
//    {
//        return new T();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        IFactory<MyClass> factory = new Factory<MyClass>();
//        MyClass instance = factory.Create();
//        instance.SayHello();
//    }
//}

//public class MyClass
//{
//    public void SayHello()
//    {
//        Console.WriteLine("Привет!");
//    }
//}


////19
//using System;
//using System.Collections.Generic;

//// Общий класс для кеша с ограничением T : class
//public class Cache<T> where T : class
//{
//    private Dictionary<string, T> _cache = new Dictionary<string, T>();

//    public void Add(string key, T value)
//    {
//        if (!_cache.ContainsKey(key))
//            _cache.Add(key, value);
//    }

//    public T Get(string key)
//    {
//        if (_cache.TryGetValue(key, out T value))
//            return value;
//        return null;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Cache<string> stringCache = new Cache<string>();
//        stringCache.Add("key1", "Значение 1");
//        stringCache.Add("key2", "Значение 2");

//        Console.WriteLine(stringCache.Get("key1")); // Значение 1
//        Console.WriteLine(stringCache.Get("key3")); // null
//    }
//}


////20
//using System;
//using System.Collections.Generic;

//// Универсальный метод для сортировки с ограничением T : IComparable<T>
//public class Sorter
//{
//    public void Sort<T>(List<T> list) where T : IComparable<T>
//    {
//        list.Sort();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };
//        Sorter sorter = new Sorter();
//        sorter.Sort(numbers);

//        foreach (var number in numbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//}


////21
//using System;
//using System.Collections.Generic;

//// Общий класс Observer с ограничением T : class
//public class Observer<T> where T : class
//{
//    private List<Action<T>> _observers = new List<Action<T>>();

//    public void Subscribe(Action<T> observer)
//    {
//        _observers.Add(observer);
//    }

//    public void Notify(T data)
//    {
//        foreach (var observer in _observers)
//        {
//            observer(data);
//        }
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Observer<string> observer = new Observer<string>();
//        observer.Subscribe(data => Console.WriteLine($"Получено сообщение: {data}"));

//        observer.Notify("Привет, наблюдатели!");
//    }
//}


////22
//using System;
//using System.Collections.Generic;

//// Интерфейс для узла дерева
//public interface ITreeNode<T>
//{
//    T Value { get; }
//    IEnumerable<ITreeNode<T>> Children { get; }
//}

//// Универсальный метод для обхода дерева с ограничением T : ITreeNode<T>
//public class TreeTraverser
//{
//    public void Traverse<T>(ITreeNode<T> node, Action<T> action) where T : ITreeNode<T>
//    {
//        action((T)node);
//        foreach (var child in node.Children)
//        {
//            Traverse((T)child, action);
//        }
//    }
//}

//// Пример реализации ITreeNode<T>
//public class TreeNode<T> : ITreeNode<T>
//{
//    public T Value { get; set; }
//    public List<ITreeNode<T>> Children { get; } = new List<ITreeNode<T>>();

//    IEnumerable<ITreeNode<T>> ITreeNode<T>.Children => Children;
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var root = new TreeNode<int> { Value = 1 };
//        root.Children.Add(new TreeNode<int> { Value = 2 });
//        root.Children.Add(new TreeNode<int> { Value = 3 });

//        TreeTraverser traverser = new TreeTraverser();
//        traverser.Traverse(root, node => Console.WriteLine(node.Value));
//    }
//}


////23
//using System;
//using System.Collections.Generic;

//// Общий класс Graph с ограничением T : class, IEquatable<T>
//public class Graph<T> where T : class, IEquatable<T>
//{
//    private Dictionary<T, List<T>> _adjacencyList = new Dictionary<T, List<T>>();

//    public void AddVertex(T vertex)
//    {
//        if (!_adjacencyList.ContainsKey(vertex))
//            _adjacencyList[vertex] = new List<T>();
//    }

//    public void AddEdge(T from, T to)
//    {
//        if (!_adjacacyList.ContainsKey(from))
//            AddVertex(from);

//        if (!_adjacacyList.ContainsKey(to))
//            AddVertex(to);

//        _adjacencyList[from].Add(to);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Graph<string> graph = new Graph<string>();
//        graph.AddVertex("A");
//        graph.AddVertex("B");
//        graph.AddEdge("A", "B");
//    }
//}


////24
//using System;
//using System.Collections.Generic;

//// Универсальный метод для мэпирования типов
//public class Mapper
//{
//    public List<TResult> Map<TSource, TResult>(IEnumerable<TSource> source, Func<TSource, TResult> mapper)
//    {
//        var result = new List<TResult>();
//        foreach (var item in source)
//        {
//            result.Add(mapper(item));
//        }
//        return result;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        Mapper mapper = new Mapper();
//        List<string> strings = mapper.Map(numbers, n => $"Число: {n}");

//        foreach (var str in strings)
//        {
//            Console.WriteLine(str);
//        }
//    }
//}


////25
//using System;

//// Общий класс для работы с событиями с ограничением T : EventArgs
//public class EventHandler<T> where T : EventArgs
//{
//    public event System.EventHandler<T> OnEvent;

//    public void RaiseEvent(object sender, T args)
//    {
//        OnEvent?.Invoke(sender, args);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        EventHandler<MyEventArgs> eventHandler = new EventHandler<MyEventArgs>();
//        eventHandler.OnEvent += (sender, args) => Console.WriteLine($"Событие: {args.Message}");

//        eventHandler.RaiseEvent(null, new MyEventArgs { Message = "Привет!" });
//    }
//}

//public class MyEventArgs : EventArgs
//{
//    public string Message { get; set; }
//}


////26
//using System;
//using System.Collections.Generic;

//// Универсальный метод Sum с ограничением T : struct, IComparable
//public class SumCalculator
//{
//    public T Sum<T>(IEnumerable<T> collection) where T : struct, IComparable
//    {
//        dynamic sum = default(T);
//        foreach (var item in collection)
//        {
//            sum += (dynamic)item;
//        }
//        return sum;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
//        SumCalculator calculator = new SumCalculator();
//        int result = calculator.Sum(numbers);
//        Console.WriteLine($"Сумма: {result}");
//    }
//}


////27
//using System;
//using System.Collections.Generic;

//// Общий класс Comparer с ограничением T : IComparable<T>
//public class GenericComparer<T> where T : IComparable<T>
//{
//    public int Compare(T a, T b)
//    {
//        return a.CompareTo(b);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        GenericComparer<int> comparer = new GenericComparer<int>();
//        Console.WriteLine(comparer.Compare(5, 3));  // 1
//        Console.WriteLine(comparer.Compare(3, 5));  // -1
//        Console.WriteLine(comparer.Compare(3, 3));  // 0
//    }
//}


////28
//using System;

//// Универсальный интерфейс с множеством ограничений
//public interface IMultiConstraint<T, U> where T : class, new() where U : struct, IComparable
//{
//    void Process(T obj, U value);
//}

//// Реализация интерфейса
//public class MultiConstraintProcessor<T, U> : IMultiConstraint<T, U> where T : class, new() where U : struct, IComparable
//{
//    public void Process(T obj, U value)
//    {
//        Console.WriteLine($"Обработка: {obj.GetType().Name}, Значение: {value}");
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        IMultiConstraint<MyClass, int> processor = new MultiConstraintProcessor<MyClass, int>();
//        processor.Process(new MyClass(), 42);
//    }
//}

//public class MyClass { }


////29
//using System;

//// Универсальный метод для преобразования типов с ограничениями
//public class Converter
//{
//    public TResult Convert<TSource, TResult>(TSource source, Func<TSource, TResult> converter)
//    {
//        return converter(source);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Converter converter = new Converter();
//        string result = converter.Convert(123, num => num.ToString());
//        Console.WriteLine($"Результат: {result}");
//    }
//}


////30
//using System;
//using System.Collections.Generic;

//// Базовый класс для сущностей
//public class EntityBase
//{
//    public int Id { get; set; }
//}

//// Общий класс для работы с базой данных с ограничением T : EntityBase
//public class Database<T> where T : EntityBase
//{
//    private List<T> _entities = new List<T>();

//    public void Add(T entity)
//    {
//        _entities.Add(entity);
//    }

//    public T GetById(int id)
//    {
//        return _entities.Find(e => e.Id == id);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Database<User> userDatabase = new Database<User>();
//        userDatabase.Add(new User { Id = 1, Name = "Иван" });
//        userDatabase.Add(new User { Id = 2, Name = "Мария" });

//        User user = userDatabase.GetById(1);
//        Console.WriteLine($"Пользователь: {user.Name}");
//    }
//}

//public class User : EntityBase
//{
//    public string Name { get; set; }
//}


////31
//using System;

//// Интерфейс для валидации
//public interface IValidatable
//{
//    bool IsValid();
//}

//// Общий класс Validator с ограничением T : IValidatable
//public class Validator<T> where T : IValidatable
//{
//    public bool Validate(T obj)
//    {
//        return obj.IsValid();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var validObject = new MyValidatableClass { Age = 25 };
//        Validator<MyValidatableClass> validator = new Validator<MyValidatableClass>();
//        Console.WriteLine(validator.Validate(validObject)); // True
//    }
//}

//public class MyValidatableClass : IValidatable
//{
//    public int Age { get; set; }

//    public bool IsValid()
//    {
//        return Age >= 0;
//    }
//}


////32
//using System;

//// Универсальный метод для создания объекта с ограничением T : class, new()
//public class ObjectCreator
//{
//    public T Create<T>() where T : class, new()
//    {
//        return new T();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        ObjectCreator creator = new ObjectCreator();
//        MyClass instance = creator.Create<MyClass>();
//        instance.SayHello();
//    }
//}

//public class MyClass
//{
//    public void SayHello()
//    {
//        Console.WriteLine("Привет!");
//    }
//}


////33
//using System;
//using System.Collections.Generic;

//// Общий класс для кеширования с ограничением T : Enum
//public class EnumCache<T> where T : Enum
//{
//    private Dictionary<T, string> _cache = new Dictionary<T, string>();

//    public void Add(T key, string value)
//    {
//        _cache[key] = value;
//    }

//    public string Get(T key)
//    {
//        if (_cache.TryGetValue(key, out string value))
//            return value;
//        return null;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        EnumCache<MyEnum> cache = new EnumCache<MyEnum>();
//        cache.Add(MyEnum.First, "Первое значение");
//        cache.Add(MyEnum.Second, "Второе значение");

//        Console.WriteLine(cache.Get(MyEnum.First)); // Первое значение
//    }
//}

//public enum MyEnum
//{
//    First,
//    Second
//}


////34
//using System;
//using System.Runtime.Serialization;

//// Интерфейс для сериализации
//public interface ISerializable
//{
//    string Serialize();
//}

//// Универсальный метод для сериализации с ограничением T : class, ISerializable
//public class Serializer<T> where T : class, ISerializable
//{
//    public string Serialize(T obj)
//    {
//        return obj.Serialize();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var obj = new MySerializableClass { Name = "Тест" };
//        Serializer<MySerializableClass> serializer = new Serializer<MySerializableClass>();
//        string serialized = serializer.Serialize(obj);
//        Console.WriteLine(serialized);
//    }
//}

//public class MySerializableClass : ISerializable
//{
//    public string Name { get; set; }

//    public string Serialize()
//    {
//        return $"Name: {Name}";
//    }
//}


////35
//using System;
//using System.Collections.Generic;

//// Общий класс Pipeline с ограничением T : class
//public class Pipeline<T> where T : class
//{
//    private List<Func<T, T>> _steps = new List<Func<T, T>>();

//    public Pipeline<T> AddStep(Func<T, T> step)
//    {
//        _steps.Add(step);
//        return this;
//    }

//    public T Execute(T input)
//    {
//        T result = input;
//        foreach (var step in _steps)
//        {
//            result = step(result);
//        }
//        return result;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var pipeline = new Pipeline<string>();
//        string result = pipeline
//            .AddStep(s => s.ToUpper())
//            .AddStep(s => s + "!")
//            .Execute("привет");

//        Console.WriteLine(result); // ПРИВЕТ!
//    }
//}


////36
//using System;
//using System.Collections.Generic;

//// Интерфейс для фильтрации
//public interface IFilterable
//{
//    bool IsMatch(string filter);
//}

//// Универсальный метод для фильтрации с ограничением T : IFilterable
//public class Filter<T> where T : IFilterable
//{
//    public List<T> Apply(List<T> items, string filter)
//    {
//        var result = new List<T>();
//        foreach (var item in items)
//        {
//            if (item.IsMatch(filter))
//                result.Add(item);
//        }
//        return result;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var items = new List<MyFilterableClass>
//        {
//            new MyFilterableClass { Name = "Яблоко" },
//            new MyFilterableClass { Name = "Банан" }
//        };

//        Filter<MyFilterableClass> filter = new Filter<MyFilterableClass>();
//        var filtered = filter.Apply(items, "Банан");

//        foreach (var item in filtered)
//        {
//            Console.WriteLine(item.Name); // Банан
//        }
//    }
//}

//public class MyFilterableClass : IFilterable
//{
//    public string Name { get; set; }

//    public bool IsMatch(string filter)
//    {
//        return Name.Contains(filter);
//    }
//}


////37
//using System;

//// Общий класс для работы с конвертером типа
//public class TypeConverter<TSource, TDestination>
//{
//    private Func<TSource, TDestination> _converter;

//    public TypeConverter(Func<TSource, TDestination> converter)
//    {
//        _converter = converter;
//    }

//    public TDestination Convert(TSource source)
//    {
//        return _converter(source);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var converter = new TypeConverter<int, string>(num => num.ToString());
//        string result = converter.Convert(123);
//        Console.WriteLine(result); // "123"
//    }
//}


////38
//using System;

//// Универсальный интерфейс Mapper<TSource, TDestination>
//public interface IMapper<TSource, TDestination>
//{
//    TDestination Map(TSource source);
//}

//// Реализация интерфейса
//public class Mapper<TSource, TDestination> : IMapper<TSource, TDestination>
//{
//    private Func<TSource, TDestination> _mapFunc;

//    public Mapper(Func<TSource, TDestination> mapFunc)
//    {
//        _mapFunc = mapFunc;
//    }

//    public TDestination Map(TSource source)
//    {
//        return _mapFunc(source);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        IMapper<int, string> mapper = new Mapper<int, string>(num => $"Число: {num}");
//        string result = mapper.Map(42);
//        Console.WriteLine(result); // "Число: 42"
//    }
//}


////39
//using System;

//// Общий класс для логирования с ограничением T : class
//public class Logger<T> where T : class
//{
//    public void Log(T message)
//    {
//        Console.WriteLine($"[{DateTime.Now}] {message}");
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Logger<string> logger = new Logger<string>();
//        logger.Log("Это сообщение для логирования.");
//    }
//}


////40
//using System;

//// Универсальный метод для работы с опциональными типами
//public class Optional<T>
//{
//    public T Value { get; }
//    public bool HasValue { get; }

//    public Optional(T value)
//    {
//        Value = value;
//        HasValue = value != null;
//    }

//    public static Optional<T> OfNullable(T value)
//    {
//        return new Optional<T>(value);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Optional<string> optional1 = Optional<string>.OfNullable("Привет");
//        Optional<string> optional2 = Optional<string>.OfNullable(null);

//        Console.WriteLine(optional1.HasValue); // True
//        Console.WriteLine(optional2.HasValue); // False
//    }
//}


////41
//using System;

//// Интерфейс команды
//public interface ICommand<T>
//{
//    void Execute(T parameter);
//}

//// Общий класс Command
//public class Command<T> : ICommand<T>
//{
//    private readonly Action<T> _action;

//    public Command(Action<T> action)
//    {
//        _action = action;
//    }

//    public void Execute(T parameter)
//    {
//        _action(parameter);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        ICommand<string> command = new Command<string>(message => Console.WriteLine($"Выполняется команда: {message}"));
//        command.Execute("Привет, мир!");
//    }
//}


////42
//using System;
//using System.Threading.Tasks;

//// Универсальный метод для асинхронных операций
//public class AsyncProcessor<T>
//{
//    public async Task ProcessAsync(Func<T, Task> asyncAction, T parameter)
//    {
//        await asyncAction(parameter);
//    }
//}

//// Пример использования
//class Program
//{
//    static async Task Main()
//    {
//        AsyncProcessor<string> processor = new AsyncProcessor<string>();
//        await processor.ProcessAsync(
//            async message =>
//            {
//                await Task.Delay(1000);
//                Console.WriteLine($"Асинхронная операция завершена: {message}");
//            },
//            "Привет, асинхронность!"
//        );
//    }
//}


////43
//using System;

//// Общий класс для работы с результатом с ограничением T : class
//public class Result<T> where T : class
//{
//    public T Data { get; }
//    public bool IsSuccess { get; }

//    public Result(T data, bool isSuccess)
//    {
//        Data = data;
//        IsSuccess = isSuccess;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Result<string> successResult = new Result<string>("Успешно!", true);
//        Result<string> failureResult = new Result<string>(null, false);

//        Console.WriteLine($"Успех: {successResult.IsSuccess}, Данные: {successResult.Data}");
//        Console.WriteLine($"Успех: {failureResult.IsSuccess}, Данные: {failureResult.Data}");
//    }
//}


////44
//using System;

//// Общий интерфейс поставщика с ограничением T : class, new()
//public interface IProvider<T> where T : class, new()
//{
//    T Get();
//}

//// Реализация интерфейса
//public class Provider<T> : IProvider<T> where T : class, new()
//{
//    public T Get()
//    {
//        return new T();
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        IProvider<MyClass> provider = new Provider<MyClass>();
//        MyClass instance = provider.Get();
//        instance.SayHello();
//    }
//}

//public class MyClass
//{
//    public void SayHello()
//    {
//        Console.WriteLine("Привет!");
//    }
//}


////45
//using System;
//using System.Collections.Generic;

//// Общий класс для работы с конфигурацией
//public class Configuration<T>
//{
//    private Dictionary<string, T> _settings = new Dictionary<string, T>();

//    public void Add(string key, T value)
//    {
//        _settings[key] = value;
//    }

//    public T Get(string key)
//    {
//        if (_settings.TryGetValue(key, out T value))
//            return value;
//        return default(T);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Configuration<int> config = new Configuration<int>();
//        config.Add("Timeout", 30);
//        config.Add("Retries", 3);

//        Console.WriteLine($"Timeout: {config.Get("Timeout")}");
//        Console.WriteLine($"Retries: {config.Get("Retries")}");
//    }
//}


////46
//using System;
//using System.Collections.Generic;

//// Универсальный метод FindMin с ограничением T : IComparable<T>
//public class MinFinder
//{
//    public T FindMin<T>(IEnumerable<T> collection) where T : IComparable<T>
//    {
//        if (collection == null)
//            throw new ArgumentNullException(nameof(collection));

//        T min = default(T);
//        bool isFirst = true;

//        foreach (var item in collection)
//        {
//            if (isFirst || item.CompareTo(min) < 0)
//            {
//                min = item;
//                isFirst = false;
//            }
//        }

//        return min;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };
//        MinFinder finder = new MinFinder();
//        int min = finder.FindMin(numbers);
//        Console.WriteLine($"Минимальное значение: {min}");
//    }
//}


////47
//using System;

//// Общий класс для работы с поворотом с ограничением T : class
//public class Rotator<T> where T : class
//{
//    public T Rotate(T obj, Func<T, T> rotationLogic)
//    {
//        return rotationLogic(obj);
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Rotator<string> rotator = new Rotator<string>();
//        string rotated = rotator.Rotate("abc", s => new string(new[] { s[2], s[1], s[0] }));
//        Console.WriteLine(rotated); // "cba"
//    }
//}


////48
//using System;
//using System.Collections.Generic;

//// Универсальный метод Distinct с ограничением T : IEquatable<T>
//public class DistinctFinder
//{
//    public List<T> GetDistinct<T>(IEnumerable<T> collection) where T : IEquatable<T>
//    {
//        List<T> distinctList = new List<T>();
//        foreach (var item in collection)
//        {
//            if (!distinctList.Contains(item))
//                distinctList.Add(item);
//        }
//        return distinctList;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
//        DistinctFinder finder = new DistinctFinder();
//        List<int> distinctNumbers = finder.GetDistinct(numbers);

//        foreach (var number in distinctNumbers)
//        {
//            Console.WriteLine(number);
//        }
//    }
//}


////49
//using System;
//using System.Collections.Generic;

//// Общий класс для работы со стеком с ограничением T : class
//public class Stack<T> where T : class
//{
//    private List<T> _items = new List<T>();

//    public void Push(T item)
//    {
//        _items.Add(item);
//    }

//    public T Pop()
//    {
//        if (_items.Count == 0)
//            return null;

//        T item = _items[_items.Count - 1];
//        _items.RemoveAt(_items.Count - 1);
//        return item;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        Stack<string> stack = new Stack<string>();
//        stack.Push("Первый");
//        stack.Push("Второй");

//        Console.WriteLine(stack.Pop()); // Второй
//        Console.WriteLine(stack.Pop()); // Первый
//    }
//}


////50
//using System;
//using System.Collections.Generic;

//// Интерфейс для агрегации
//public interface IAggregatable<TResult>
//{
//    TResult Aggregate(Func<TResult, TResult, TResult> aggregator);
//}

//// Универсальный метод для агрегации данных с ограничением T : IAggregatable<TResult>
//public class Aggregator<T, TResult> where T : IAggregatable<TResult>
//{
//    public TResult Aggregate(List<T> items, Func<TResult, TResult, TResult> aggregator)
//    {
//        if (items.Count == 0)
//            throw new ArgumentException("Список не может быть пустым.");

//        TResult result = items[0].Aggregate(aggregator);
//        for (int i = 1; i < items.Count; i++)
//        {
//            result = aggregator(result, items[i].Aggregate(aggregator));
//        }
//        return result;
//    }
//}

//// Пример использования
//class Program
//{
//    static void Main()
//    {
//        var items = new List<MyAggregatable>
//        {
//            new MyAggregatable { Value = 1 },
//            new MyAggregatable { Value = 2 },
//            new MyAggregatable { Value = 3 }
//        };

//        Aggregator<MyAggregatable, int> aggregator = new Aggregator<MyAggregatable, int>();
//        int sum = aggregator.Aggregate(items, (a, b) => a + b);
//        Console.WriteLine($"Сумма: {sum}");
//    }
//}

//public class MyAggregatable : IAggregatable<int>
//{
//    public int Value { get; set; }

//    public int Aggregate(Func<int, int, int> aggregator)
//    {
//        return Value;
//    }
//}


////51
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


////52
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


////53
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


////54
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


////55
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


////56
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


////57
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


////58
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


////59
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


////60
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


////61
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


////62
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


////63
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


////64
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


////65
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


////66
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


////67
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


////68
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


////69
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


////70
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


////71
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


////72
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


////73
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


////74
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


////75
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


////76
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


////77
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


////78
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


////79
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


////80
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


////81
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


////82
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


////83
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


////84
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


////85
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


////86
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


////87
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


////88
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


////89
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


////90
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


////91
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


////92
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


////93
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


////94
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


////95
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


////96
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


////97
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


////98
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


////99
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


////100
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