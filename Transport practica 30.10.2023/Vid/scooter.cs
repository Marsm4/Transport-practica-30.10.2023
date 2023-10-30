using System.Drawing;
using System.Reflection;
using TransportManagement;

class Scooter : Transport
{
    public override void PrintInfo()
    {
        Console.WriteLine("Scooter:");
        Console.WriteLine("Model: " + Model);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Speed: " + Speed);
        Console.WriteLine("Is Rented: " + IsRented);
        Console.WriteLine();
    }
}