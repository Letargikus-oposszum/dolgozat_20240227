using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGroupping
{
    public class Car : Vehicle, IVehicle
    {
        public int backpackCapacity;
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string ToString()
        {
            return $"ID: {id} Név: {name} Sebesség: {speed} UTasok: {passangers} Fogyasztás: {consumption} Ajtók száma: {Doors} Kerekek száma: {Wheels} Csomagtartó űrtartalma: {backpackCapacity}";
        }
    }
    
}