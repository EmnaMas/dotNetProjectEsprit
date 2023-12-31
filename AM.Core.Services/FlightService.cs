﻿using System;
using AM.CORE.DOMAIN;
namespace AM.Core.Services
    
{
    public class FlightService:IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            IList<DateTime> listeDate=new List<DateTime>(); 
            foreach (var flight in Flights)
            {
                if (flight.Destination==destination)
                {
                    listeDate.Add(flight.FlightDate);
                }
           }
            return listeDate;
        }



        public void GetFlights(string filterType, string filterValue)
        {

            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "Departure":
                    foreach (var flight in Flights)
                    {
                        if (flight.Departure == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightId":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightId.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EffectiveArrival":

                    foreach (var flight in Flights)
                    {
                        // if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        if (flight.EffectiveArrival.ToString() == filterValue)
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    try
                    {
                        foreach (var flight in Flights)
                        {
                            if (flight.EstimatedDuration == int.Parse(filterValue))
                            {
                                Console.WriteLine(flight);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("la valeur du filter n'est pas un int : ", ex.ToString());
                    }
                    break;
            }
        }

        //methode de linq : 
        public IList<DateTime> GetFlightDatess(string destination) // linqIntegre
        {
            //return (from f in Flights 
            //       where f.Destination == destination
            //       select f.FlightDate).ToList();
            return Flights.Where(f => f.Destination == destination) //Methoded'extention
                .Select(f => f.FlightDate).ToList();

        }



        public void ShowFlightDetails(Plane plane)
        {
            var result = from f in Flights
                         where f.MyPlane.PlaneId == plane.PlaneId
                         select new { f.Destination, f.FlightDate }; //type anonyme
            foreach (var item in result)
            {
                Console.WriteLine("destination : " + item.Destination +
                    "date :" + item.FlightDate);
            }
        }


        public int GetWeeklyFlightNumber(DateTime date)
        {
            return (from f in Flights
                    where f.FlightDate >= date
                    && f.FlightDate < date.AddDays(7)
                    select f).Count(); //type anonyme

        }


        public double GetDurationAverage(string destination)
        {
            return (from f in Flights
                    where f.Destination == destination
                    select f.EstimatedDuration).Average();
        }



        public IList<Flight> SortFlights()
        {
            return (from f in Flights
                    orderby f.EstimatedDuration descending
                    select f).ToList();
        }


        public IList<Passenger> GetThreeOlderTravellers(Flight flight)
        {
            return (from p in flight.passengers
                    orderby p.Age descending //orderby p.BirthDate
                    select p).Take(3).ToList();
           
        }


        public void ShowGroupedFlights()
        {
            /*var */
            IEnumerable<IGrouping<string, Flight>> result = from f in Flights
                                                            group f by f.Destination;
            foreach (var grp in result)
            {
                Console.WriteLine(grp.Key);
                foreach (var f in grp)
                {
                    Console.WriteLine(f);

                }
            }
        }



        public Passenger GetSeniorPassenger(IFlightService.GetScore meth)
        {
            var result = (from f in Flights
                          from p in f.passengers
                          orderby meth(p) descending
                          select p).First();
            return result;
            //return null;
        }























    }
}
