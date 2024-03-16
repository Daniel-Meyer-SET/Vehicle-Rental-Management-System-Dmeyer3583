using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class Car : Vehicle
    {
        private int seats;
        private string transmission;
        private bool convertible;

        public int Seats { get { return seats; } set { seats = value; } }

        public string Transmission { get { return transmission; } set { transmission = value; } }  
        public bool Convertible { get { return convertible; } set { convertible = value; } }


        public override void  DisplayDetails()
        {
            Console.WriteLine("Year: " + Year + "\nManufacturer: " + Manufacturer + "\nModel: " + Model + "\nRental Price:" + RentalPrice);



        }
    }
}
