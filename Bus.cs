using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGroupping
{
    public class Bus : Vehicle, IVehicle
    {
    
        public BusEnum bustype { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string ToString()
        {
            return $"Id: {id} Név: {name} Sebesség: {speed} Utasok száma: {passangers} Fogyasztás: {consumption} Ajtók száma: {Doors} Kerekek száma: {Wheels}";
        }
    }
    
}
