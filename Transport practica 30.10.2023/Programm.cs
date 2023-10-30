﻿using System;
using System.Collections.Generic;
using TransportManagement; // Подразумевается, что классы Boat, Car, Bicycle, Motorcycle и Scooter наследуют класс Transport

class Program
{
    static void Main(string[] args)
    {
        List<Transport> transports = new List<Transport>();

        transports.Add(new Boat { Model = "Boat1", Color = "Blue", Speed = 30, IsRented = false });
        transports.Add(new Car { Model = "Volga", Color = "Red", Speed = 150, IsRented = true, Category = "B", NumberOfWheels = 4 });
        transports.Add(new Bicycle { Model = "Stels", Color = "Green", Speed = 20, IsRented = false, NumberOfWheels = 2 });
        transports.Add(new Motorcycle { Model = "Olimp", Color = "Black", Speed = 200, IsRented = true, LicenseCategory = "A", HasMotor = true, NumberOfWheels = 2 });
        transports.Add(new Scooter { Model = "Stern", Color = "Yellow", Speed = 15, IsRented = false, NumberOfWheels = 2 });

        Console.WriteLine("Выберите тип транспорта (Boat, Car, Bicycle, Motorcycle, Scooter):");
        string selectedType = Console.ReadLine();

        Console.WriteLine($"Аренда для выбранного типа транспорта {selectedType}:");
        foreach (Transport transport in transports)
        {
            if (transport.GetType().Name == selectedType)
            {
                Console.WriteLine($"{transport.Model} - {(transport.IsRented ? "Арендован" : "Не арендован")}");
            }
        }
    }
}