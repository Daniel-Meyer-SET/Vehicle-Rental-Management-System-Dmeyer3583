using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class RentalAgency
    {
        // initialize fleet
        Vehicle[] fleet = new Vehicle[20];
        
        private double totalRevenue;
        public double TotalRevenue {get { return totalRevenue;} set {  totalRevenue = value; } }
        int fleetSize = 0;
        public Vehicle[] Fleet { get {  return fleet; } set {  fleet = value; } }
        
        public void addVehicle(Vehicle newVehicle) {
            fleet[fleetSize++] = newVehicle;
        }

        public void RemoveVehicle(int vehicleNumber)
        {

            fleet[vehicleNumber] = null;
            
            fleetSize--;
        }

        public void RentVeicle(int vehicleNumber)
        {
            // vehicle is removed from the fleet when rented
            totalRevenue +=fleet[vehicleNumber].RentalPrice;
            RemoveVehicle(vehicleNumber);
        } 

    }
}
