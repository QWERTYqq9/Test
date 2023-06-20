using System;
using System.IO;
using System.Text.Json;

class MyClass
{
    public int Variable1 { get; set; }
    public string Variable2 { get; set; }

    public MyClass(int value1, string value2)
    {
        Variable1 = value1;
        Variable2 = value2;
    }

    public MyClass()
    {
        Variable1 = 0;
        Variable2 = "";
    }

    ~MyClass()
    {
        Console.WriteLine("Об'єкт MyClass видалено.");
    }

    public void Display()
    {
        Console.WriteLine("Значення Variable1: " + Variable1);
        Console.WriteLine("Значення Variable2: " + Variable2);
    }

    public void SaveToJson(string fileName)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(this, options);
        File.WriteAllText(fileName, json);
        Console.WriteLine("Об'єкт збережено у JSON файл: " + fileName);
    }

    public static MyClass LoadFromJson(string fileName)
    {
        string json = File.ReadAllText(fileName);
        MyClass obj = JsonSerializer.Deserialize<MyClass>(json);
        Console.WriteLine("Об'єкт завантажено з JSON файлу: " + fileName);
        return obj;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Завдання 1: Створення екземплярів класу та демонстрація роботи методів
        MyClass obj1 = new MyClass(10, "Hello");
        MyClass obj2 = new MyClass();

        Console.WriteLine("Об'єкт obj1:");
        obj1.Display();

        Console.WriteLine();

        Console.WriteLine("Об'єкт obj2:");
        obj2.Display();

        // Завдання 2: Серіалізація та десеріалізація об'єктів класу
        obj1.SaveToJson(@"C:\Users\SPL\Desktop\File2\obj1.json");
        MyClass obj3 = MyClass.LoadFromJson(@"C:\Users\SPL\Desktop\File2\obj1.json");

        Console.ReadLine();
    }
}