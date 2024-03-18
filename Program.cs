// See https://aka.ms/new-console-template for more information

namespace Vehicle_Rental_Management_System
{
    public class Program
    {   // main method and entry point
        static void Main(string[] args)
        {
         Console.WriteLine("Welcome to the Vehicle Rental Management System");
            Console.WriteLine("Options:\n A: Add new vehicle\n R:Rent a vehicle \nX: Remove A vehicle\nS:Show Details");
            
            RentalAgency rental = new RentalAgency();
            switch (Console.ReadKey(false).KeyChar) { 
            case 'a':
                    {
                        Console.WriteLine("c: car\nt:truck\nm:motorcycle");
                        switch (Console.ReadKey(false).KeyChar)
                        {
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
                                    switch (Console.ReadKey(false).KeyChar) { 
                                    case 'a': {

                                    car.Transmission = "Automatic";
                                    break;
                                      }
                                    case 'm': {
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
                        }
                        break;
                    }
            
            }




        }

        static void showVehiclesInFleet(RentalAgency rental) {

            foreach (Vehicle vehicle1 in rental.Fleet)
            {
                vehicle1.DisplayDetails();

            }
        }

    }
}

