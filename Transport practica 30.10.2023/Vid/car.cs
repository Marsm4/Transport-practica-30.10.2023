using System.Drawing;
using System.Reflection;
using TransportManagement;

class Car : Transport
{
    public string Category { get; set; }

    public override void PrintInfo()
    {
        Console.WriteLine("Car:");
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Is Rented: " + IsRented);
        Console.WriteLine("Category: " + Category);
        Console.WriteLine();
    }
}