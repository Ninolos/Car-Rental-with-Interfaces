﻿using System;
using System.Globalization;
using LocacaoInterface.Entities;

namespace LocacaoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup Data (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return Data (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

        }
    }
}
