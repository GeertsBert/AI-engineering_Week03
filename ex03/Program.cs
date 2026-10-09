
List<Vehicle> vehicles = new List<Vehicle>
{
    new Car(120,"red",4),
    new Car(40,"blue",4),
    new Car(60,"yellow",3),
    new Boat(80,"Green","Shallow Water")
};
foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.DescribeVehicle());
    if (vehicle is IRefuelable refuelableVehicle)
        refuelableVehicle.Refuel();
}

List<IRefuelable> refuelables = new List<IRefuelable>
{
    new Generator(5000),
    new Generator(10000)
};

foreach (var refuelable in refuelables)
{
    refuelable.Refuel();
}