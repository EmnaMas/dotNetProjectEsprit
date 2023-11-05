// See https://aka.ms/new-console-template for more information
using AM.CORE.DOMAIN;

Console.WriteLine("Hello, World!");

Plane plane = new Plane(PlaneType.BOING, 100, new DateTime(2000, 1, 1));
Console.WriteLine(plane.ToString());

Plane plane1 = new Plane();
plane1.Capacity = 100;
plane1.ManufactureDate = new DateTime(2000, 1, 1);
plane1.MyPlaneType = PlaneType.BOING;

Console.WriteLine(plane1.ToString());

//initialiseur d'objets
Plane plane3 = new Plane()
{
    Capacity = 100,
    ManufactureDate = new DateTime(2000, 1, 1),
    MyPlaneType = PlaneType.BOING
};
Console.WriteLine(plane3.ToString());


Passenger p = new Passenger();
Console.WriteLine(p.GetPassengerType());

Passenger p2 = new Passenger();
p2.BirthDate = new DateTime(1999, 09, 02);
 int Age=0;
p2.GetAge(p2.BirthDate, out  Age);
Console.WriteLine(Age);


Passenger passenger = new Passenger();
passenger.BirthDate = new DateTime(1990, 5, 1);
//passenger.GetAge1();
Console.WriteLine(passenger.Age);