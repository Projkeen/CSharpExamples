using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Interface
{
    internal class Transport
    {
        public int Number { get; set; }
        public string Model { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("Have fun!");
        }
        
    }

    internal class Plane : Transport, MainFunctions
    {        
        public string Moving()
        {
            return "This plane is flying";
        }
    }

    internal class Car : Transport, MainFunctions, SecondFunctions
    {
        public string AnotherService()
        {
            return "You may choose a time of the ride";
        }

        public string Moving()
        {
            return "This car is moving";
        }
    }
    internal class Ship : Transport, MainFunctions
    {
        public string Moving()
        {
            return "This ship is sailing";
        }
    }
}
