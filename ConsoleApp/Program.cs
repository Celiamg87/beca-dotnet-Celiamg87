using System;
using BusinessCore;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehiculos = new Vehicle[10];

            vehiculos[0] = new Car();
            vehiculos[1] = new Motorcycle();
            
            
            Console.ReadLine();
        }
    }
}
