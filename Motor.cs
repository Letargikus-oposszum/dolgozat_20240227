using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleGroupping
{
    public class Motor : Vehicle, IVehicle
    {
        public MotorEnum motortype { get; set; }
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public string ToString()
        {
            return $"Id: {id} Név: {name} Sebesség: {speed} Utasok száma: {passangers} Fogyasztás: {consumption} Ajzók száma: {Doors} Kerekek száma: {Wheels}";
        }
    }

    
}
