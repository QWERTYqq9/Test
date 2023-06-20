using System;
using System.Collections.Generic;

// Базовий клас для смартфонів
class Smartphone
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public double DisplaySize { get; set; }
    public double Price { get; set; }

    public virtual void DisplayDetails()
    {
        Console.Write($"Модель: {Model}, ");
        Console.Write($"Виробник: {Manufacturer}, ");
        Console.Write($"Розмір дисплея: {DisplaySize} дюймів ");
        Console.WriteLine($"Ціна: ${Price}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення списку смартфонів
        List<Smartphone> smartphones = new List<Smartphone>();

        // Додавання смартфонів до списку
        smartphones.Add(new Smartphone
        {
            Model = "iPhone 12",
            Manufacturer = "Apple",
            DisplaySize = 6.1,
            Price = 999.99
        });

        smartphones.Add(new Smartphone
        {
            Model = "Galaxy S21",
            Manufacturer = "Samsung",
            DisplaySize = 6.2,
            Price = 899.99
        });

        smartphones.Add(new Smartphone
        {
            Model = "Pixel 5",
            Manufacturer = "Google",
            DisplaySize = 6.0,
            Price = 699.99
        });

        // Сортування смартфонів за моделлю
        smartphones.Sort((x, y) => x.Model.CompareTo(y.Model));

        // Виведення відсортованих смартфонів
        Console.WriteLine("Відсортовано за моделлю:");
        foreach (var smartphone in smartphones)
        {
            smartphone.DisplayDetails();
        }
        Console.WriteLine();

        // Сортування смартфонів за виробником
        smartphones.Sort((x, y) => x.Manufacturer.CompareTo(y.Manufacturer));

        // Виведення відсортованих смартфонів
        Console.WriteLine("Відсортовано за виробником:");
        foreach (var smartphone in smartphones)
        {
            smartphone.DisplayDetails();
        }
        Console.WriteLine();

        // Сортування смартфонів за розміром дисплея
        smartphones.Sort((x, y) => x.DisplaySize.CompareTo(y.DisplaySize));

        // Виведення відсортованих смартфонів
        Console.WriteLine("Відсортовано за розміром дисплея:");
        foreach (var smartphone in smartphones)
        {
            smartphone.DisplayDetails();
        }
        Console.WriteLine();

        // Пошук смартфону за заданими параметрами
        double searchDisplaySize = 6.1;
        Smartphone foundSmartphone = smartphones.Find(x => x.DisplaySize == searchDisplaySize);
        if (foundSmartphone != null)
        {
            Console.WriteLine("Знайдений смартфон:");
            foundSmartphone.DisplayDetails();
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Смартфон не виявлено.");
        }

        // Підрахунок загальної кількості смартфонів на складі
        int totalDevices = smartphones.Count;
        Console.WriteLine($"Всього пристроїв на складі: {totalDevices}");

        // Пошук смартфонів за діапазоном цін
        double minPrice = 800.00;
        double maxPrice = 1000.00;
        List<Smartphone> phonesInRange = smartphones.FindAll(x => x.Price >= minPrice && x.Price <= maxPrice);

        Console.WriteLine($"Смартфони в ціновому діапазоні (${minPrice} - ${maxPrice}):");
        foreach (var smartphone in phonesInRange)
        {
            smartphone.DisplayDetails();
        }
    }
}
