﻿// See https://aka.ms/new-console-template for more information

namespace Vehicle_Rental_Management_System
{
    public class Program
    {   // main method and entry point
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vehicle Rental Management System");
            Console.WriteLine("Options:\n A: Add new vehicle\n R:Rent a vehicle \nX: Remove A vehicle\nS:Show Details");

            RentalAgency rental = new RentalAgency();
            switch (Console.ReadKey(false).KeyChar)
            {
                case 'a':{
                                Console.WriteLine("c: car\nt:truck\nm:motorcycle");
                                 switch (Console.ReadKey(false).KeyChar) {
                            case 'c':
                                {
                                    Console.WriteLine("Car:");
                                    Car car = new Car();
                                    Console.WriteLine("enter year:");
                                    car.Year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter manufacturer");
                                    car.Manufacturer = Console.ReadLine();
                                    Console.WriteLine("Enter model");
                                    car.Model = Console.ReadLine();
                                    Console.WriteLine("enter number of seats:");
                                    car.Seats = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Automatic Or Manual Transmission:");
                                    switch (Console.ReadKey(false).KeyChar)
                                    {
                                        case 'a':
                                            {

                                                car.Transmission = "Automatic";
                                                break;
                                            }
                                        case 'm':
                                            {
                                                car.Transmission = "Manual";
                                                break;
                                            }

                                    }
                                    Console.WriteLine("is the car a convertible?");
                                    switch (Console.ReadKey(false).KeyChar)
                                    {
                                        case 'y':
                                            {

                                                car.Convertible = true;
                                                break;
                                            }
                                        case 'n':
                                            {
                                                car.Convertible = false;
                                                break;
                                            }


                                    }



                                    break;
                                }
                            case 't':
                                {
                                    Console.WriteLine("Truck:");
                                    Truck truck = new Truck();
                                    Console.WriteLine("enter year:");
                                    truck.Year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter manufacturer");
                                    truck.Manufacturer = Console.ReadLine();
                                    Console.WriteLine("Enter model");
                                    truck.Model = Console.ReadLine();
                                    Console.WriteLine("enter capacity:");
                                    truck.Capacity = int.Parse(Console.ReadLine());

                                    Console.WriteLine("is the truck four wheel drive?");
                                    Console.WriteLine("what type of truck:");
                                    truck.TruckType = Console.ReadLine();
                                    switch (Console.ReadKey(false).KeyChar)
                                    {
                                        case 'y':
                                            {

                                                truck.FourWheelDrive = true;
                                                break;
                                            }
                                        case 'n':
                                            {
                                                truck.FourWheelDrive = false;
                                                break;
                                            }
                                    }
                                    break;
                                }
                            case 'm':
                                {
                                    Console.WriteLine("Motorcycle:");
                                    Motorcycle motorcycle = new Motorcycle();
                                    Console.WriteLine("enter year:");
                                    motorcycle.Year = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter manufacturer");
                                    motorcycle.Manufacturer = Console.ReadLine();
                                    Console.WriteLine("Enter model");
                                    motorcycle.Model = Console.ReadLine();
                                    Console.WriteLine("Enter fuel type");
                                    motorcycle.FuelType = Console.ReadLine();
                                    Console.Write("Does The Motorcyle have a fairing?");
                                    switch (Console.ReadKey(false).KeyChar)
                                    {
                                        case 'y':
                                            {

                                                motorcycle.HasFairing = true;
                                                break;
                                            }
                                        case 'n':
                                            {
                                                motorcycle.HasFairing = false;
                                                break;
                                            }

                                    }
                                    break;
                                
                                }

                        }
                        break;
                    }
                case 'r': {
                      Console.Write
                        
                        break;
                    }

                    

            }
        }
        static void showVehiclesInFleet(RentalAgency rental)
        {

            foreach (Vehicle vehicle1 in rental.Fleet)
            {
                vehicle1.DisplayDetails();

            }
        }
    }
}

