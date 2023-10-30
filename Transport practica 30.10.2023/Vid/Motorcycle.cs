using System.Drawing;
using System.Reflection;
using TransportManagement;

class Motorcycle : Transport
{
    public string LicenseCategory { get; set; }

    public bool HasMotor { get; set; }

    public int NumberOfWheels { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine("Motorcycle:");
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Is Rented: " + IsRented);
        Console.WriteLine("License Category: " + LicenseCategory);
        Console.WriteLine("Has Motor: " + HasMotor);
        Console.WriteLine("Number of Wheels: " + NumberOfWheels);
        Console.WriteLine();
    }
}