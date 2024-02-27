using VehicleGroupping;

var cars = new List<Car>();
var motors = new List<Motor>();
var busses = new List<Bus>();

var hondaCivic = new Car
{
    id = 1,
    name = "Honda Civic",
    speed = 120,
    passangers = 4,
    consumption = 5,
    backpackCapacity = 6,
    Wheels = 4,
    Doors = 4
    
};
cars.Add(hondaCivic);

var koenigseggRegera = new Car
{
    id = 2,
    name = "Koenigsegg Regera",
    speed = 435,
    passangers = 2,
    consumption = 6,
    backpackCapacity = 9,
    Wheels = 4,
    Doors = 2
};
cars.Add(koenigseggRegera);

var KawasakiNinja = new Motor
{
    id = 3,
    name = "Kawasaki Ninja",
    speed = 350,
    passangers = 4,
    consumption = 5,
    Wheels = 2,
    Doors = 0,
    motortype = MotorEnum.sport
};
motors.Add(KawasakiNinja);

var Ducati = new Motor
{
    id = 4,
    name = "Ducati",
    speed = 435,
    passangers = 2,
    consumption = 6,
    Wheels = 2,
    Doors = 0,
    motortype = MotorEnum.kross
};
motors.Add(Ducati);

var ikarus = new Bus
{
    id = 5,
    name = "Ikarus",
    speed = 85,
    passangers = 50,
    consumption = 22,
    Wheels = 6,
    Doors = 3,
    bustype = BusEnum.doublefloor
};
busses.Add(ikarus);

var Volan = new Bus
{
    id = 6,
    name = "Volan",
    speed = 80,
    passangers = 60,
    consumption = 24,
    Wheels = 4,
    Doors = 4,
    bustype = BusEnum.normal
};
busses.Add(Volan);

Console.WriteLine($"Az összes adat egyszerre kiíratva:{Environment.NewLine}");
Console.WriteLine(hondaCivic.ToString());
Console.WriteLine(koenigseggRegera.ToString());
Console.WriteLine(Ducati.ToString());
Console.WriteLine(KawasakiNinja.ToString());
Console.WriteLine(ikarus.ToString());
Console.WriteLine(Volan.ToString());


