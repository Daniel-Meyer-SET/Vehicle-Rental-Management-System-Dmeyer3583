using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class RentalAgency
    {

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
            int index = -1;
            for (int i = index; i < fleetSize - 1; i++)
            {

                if (i == vehicleNumber){
                    index = i;

                }
                fleet[fleetSize] = null; fleetSize--;

            }
            fleet[index] = null;
            for (int i = index; i < fleetSize - 1; i++)
            {
                fleet[i] = fleet[i + 1];
            }
            fleetSize--;
        }

        public void RentVeicle(int vehicleNumber)
        {
            totalRevenue +=fleet[vehicleNumber].RentalPrice;
            RemoveVehicle(vehicleNumber);
        } 

    }
}
