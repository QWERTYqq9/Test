public abstract class TransportVehicle
{
    public int Speed { get; protected set; }
    public bool AreDoorsOpen { get; protected set; }
    public int NumberOfWheels { get; protected set; }

    public TransportVehicle(int speed, bool areDoorsOpen, int numberOfWheels)
    {
        Speed = speed;
        AreDoorsOpen = areDoorsOpen;
        NumberOfWheels = numberOfWheels;
    }

    public abstract void Start();
    public abstract void Stop();
    public abstract void Accelerate();
    public abstract void Decelerate();
}
public class Motorcycle : TransportVehicle
{
    public Motorcycle(int speed, bool areDoorsOpen) : base(speed, areDoorsOpen, 2)
    {
        // Додаткові налаштування для мотоциклу
    }

    public override void Start()
    {
        // Логіка запуску мотоцикла
    }

    public override void Stop()
    {
        // Логіка зупинки мотоцикла
    }

    public override void Accelerate()
    {
        // Логіка прискорення мотоцикла
    }

    public override void Decelerate()
    {
        // Логіка зменшення швидкості мотоцикла
    }
}

public class Bicycle : TransportVehicle
{
    public Bicycle(int speed, int numberOfWheels) : base(speed, false, numberOfWheels)
    {
        // Додаткові налаштування для велосипеда
    }

    public override void Start()
    {
    }

    public override void Stop()
    {
    }

    public override void Accelerate()
    {
    }

    public override void Decelerate()
    {
    }
}

public class Moped : TransportVehicle
{
    public Moped(int speed, bool areDoorsOpen) : base(speed, areDoorsOpen, 2)
    {
        // Додаткові налаштування для мопеда
    }

    public override void Start()
    {
    }

    public override void Stop()
    {
    }

    public override void Accelerate()
    {
    }

    public override void Decelerate()
    {
    }
}

public class Car : TransportVehicle
{
    public Car(int speed, bool areDoorsOpen, int numberOfWheels) : base(speed, areDoorsOpen, numberOfWheels)
    {
        // Додаткові налаштування для автомобіля
    }

    public override void Start()
    {
    }

    public override void Stop()
    {
    }

    public override void Accelerate()
    {
    }

    public override void Decelerate()
    {
    }
}

public class Train : TransportVehicle
{
    public Train(int speed, bool areDoorsOpen, int numberOfWheels) : base(speed, areDoorsOpen, numberOfWheels)
    {
        // Додаткові налаштування для потяга
    }

    public override void Start()
    {
    }

    public override void Stop()
    {
    }

    public override void Accelerate()
    {
    }

    public override void Decelerate()
    {
    }
}

public class TwoWheeledTransport : TransportVehicle
{
    public TwoWheeledTransport(int speed, bool areDoorsOpen) : base(speed, areDoorsOpen, 2)
    {
        // Додаткові налаштування для двоколісного транспорту
    }

    public override void Start()
    {
    }

    public override void Stop()
    {
    }

    public override void Accelerate()
    {
    }

    public override void Decelerate()
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Створення об'єктів різних типів транспортних засобів
        Motorcycle motorcycle = new Motorcycle(100, false);
        Bicycle bicycle = new Bicycle(20, 2);
        Moped moped = new Moped(50, true);
        Car car = new Car(120, true, 4);
        Train train = new Train(200, true, 12);
        TwoWheeledTransport scooter = new TwoWheeledTransport(30, false);

        // Виклик методів для кожного засобу
        motorcycle.Start();
        motorcycle.Accelerate();
        motorcycle.Decelerate();
        motorcycle.Stop();

        bicycle.Start();
        bicycle.Accelerate();
        bicycle.Decelerate();
        bicycle.Stop();

        moped.Start();
        moped.Accelerate();
        moped.Decelerate();
        moped.Stop();

        car.Start();
        car.Accelerate();
        car.Decelerate();
        car.Stop();

        train.Start();
        train.Accelerate();
        train.Decelerate();
        train.Stop();

        scooter.Start();
        scooter.Accelerate();
        scooter.Decelerate();
        scooter.Stop();

        // Перевірка властивостей кожного засобу
        Console.WriteLine($"Motorcycle: Speed - {motorcycle.Speed}, Doors Open - {motorcycle.AreDoorsOpen}, Wheels - {motorcycle.NumberOfWheels}");
        Console.WriteLine($"Bicycle: Speed - {bicycle.Speed}, Doors Open - {bicycle.AreDoorsOpen}, Wheels - {bicycle.NumberOfWheels}");
        Console.WriteLine($"Moped: Speed - {moped.Speed}, Doors Open - {moped.AreDoorsOpen}, Wheels - {moped.NumberOfWheels}");
        Console.WriteLine($"Car: Speed - {car.Speed}, Doors Open - {car.AreDoorsOpen}, Wheels - {car.NumberOfWheels}");
        Console.WriteLine($"Train: Speed - {train.Speed}, Doors Open - {train.AreDoorsOpen}, Wheels - {train.NumberOfWheels}");
        Console.WriteLine($"Scooter: Speed - {scooter.Speed}, Doors Open - {scooter.AreDoorsOpen}, Wheels - {scooter.NumberOfWheels}");

        Console.ReadLine();
    }
}