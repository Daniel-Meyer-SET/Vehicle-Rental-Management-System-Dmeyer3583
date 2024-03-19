using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class Vehicle
    {

        private string model;
        private string manufacturer;
        private int year;
        private double rentalPrice;

       public string Model { 
       get { return model; } 
       set {  model = value; } 
        }
        
        public string Manufacturer { get { return manufacturer; } set { manufacturer = value; } }
        public int Year { get { return year; } set { year = value; } }   
        public double RentalPrice { get {  return rentalPrice; } set {  rentalPrice = value; } }

        public virtual void DisplayDetails() {
           
              // base functionality 
         Console.WriteLine("Year: " + Year + "\nManufacturer: " + Manufacturer + "\nModel: " + Model + "\nRental Price:" + RentalPrice);
            

        }
    }
}
