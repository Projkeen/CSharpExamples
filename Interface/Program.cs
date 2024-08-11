// See https://aka.ms/new-console-template for more information
using Interface;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection;

Transport transport = new Transport();

Console.WriteLine("select the transport: <Car>, <Plane>, <Ship>");

string input = Console.ReadLine();
try
{
    if (input.ToLower() == "car")
    {
        Car car = new Car();
        Console.WriteLine(car.Moving());
        Console.WriteLine(car.AnotherService());
    }
    else if (input.ToLower() == "plane")
    {
        Plane plane = new Plane();
        Console.WriteLine(plane.Moving());        
    }
    else if (input.ToLower() == "ship")
    {
        Ship ship = new Ship();
        Console.WriteLine(ship.Moving());
    }
    else
    {
        Console.WriteLine("unknown transport!");
        transport.ShowInfo();
    }
}
catch(Exception ex)
{
    Console.WriteLine("unknown transport!");
    Console.WriteLine($"Непредвиденная ошибка: {ex.Message}");        
}
//transport.ShowInfo();

