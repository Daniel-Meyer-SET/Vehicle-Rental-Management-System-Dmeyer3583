using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_Management_System
{
    internal class Truck : Vehicle
    {
        private int capacity;
        private string truckType;
        private bool fourWheelDrive;

        public int Capacity { get { return capacity; } set { capacity = value; } }
        public string TruckType { get {  return truckType; } set {  truckType = value; } }
        public bool FourWheelDrive { get { return fourWheelDrive; } set { fourWheelDrive = value; } }

        public override void DisplayDetails()
        {
            // call base class method
            base.DisplayDetails();

            Console.WriteLine("Capacity:"+Capacity);
            Console.WriteLine("Truck Type" + truckType);
            Console.WriteLine("Four Wheel Drive" + fourWheelDrive);


        }

    }
}
