using TransportManagement;

class Program
{
    static void Main(string[] args)
    {
        List<Transport> transports = new List<Transport>();

        // Добавляем транспорт в список
        transports.Add(new Boat { Model = "Boat1", Color = "Blue", Speed = 30, IsRented = false });
        transports.Add(new Car { Model = "Car1", Color = "Red", Speed = 150, IsRented = true, Category = "B" });
        transports.Add(new Bicycle { Model = "Bicycle1", Color = "Green", Speed = 20, IsRented = false, NumberOfWheels = 2 });
        transports.Add(new Motorcycle { Model = "Motorcycle1", Color = "Black", Speed = 200, IsRented = true, LicenseCategory = "A", HasMotor = true });
        transports.Add(new Scooter { Model = "Scooter1", Color = "Yellow", Speed = 15, IsRented = false });

        // Выводим транспорт в консоль по типам
        Console.WriteLine("Boats:");
        foreach (Transport transport in transports)
        {
            if (transport is Boat)
            {
                transport.PrintInfo();
            }
        }

        Console.WriteLine("Cars:");
        foreach (Transport transport in transports)
        {
            if (transport is Car)
            {
                transport.PrintInfo();
            }
        }

        Console.WriteLine("Bicycles:");
        foreach (Transport transport in transports)
        {
            if (transport is Bicycle)
            {
                transport.PrintInfo();
            }
        }

        Console.WriteLine("Motorcycles:");
        foreach (Transport transport in transports)
        {
            if (transport is Motorcycle)
            {
                transport.PrintInfo();
            }
        }

        Console.WriteLine("Scooters:");
        foreach (Transport transport in transports)
        {
            if (transport is Scooter)
            {
                transport.PrintInfo();
            }
        }
    }
}
