using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class RentalAgency
    {

        Vehicle[] fleet;
        private double totalRevenue;
        public double TotalRevenue {get { return totalRevenue;} set {  totalRevenue = value; } }
        int fleetSize = 0;
        public Vehicle[] Fleet { get {  return fleet; } set {  fleet = value; } }
        
        public void addVehicle(Vehicle newVehicle) {
            fleet[fleetSize++] = newVehicle;
        }

        public void RemoveVehicle()
        {
            fleet[fleetSize] = null; fleetSize--;
        }

        public void RentVeicle(int vehicleNumber)
        {
            totalRevenue +=fleet[vehicleNumber].RentalPrice;
        } 

    }
}
