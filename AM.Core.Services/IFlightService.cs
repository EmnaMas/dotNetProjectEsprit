using System;
using AM.CORE.DOMAIN;
namespace AM.Core.Services
{
    public interface IFlightService
    {
        IList<DateTime> GetFlightDates(string destination);
        void GetFlights(string filterType, string filterValue);
        void ShowFlightDetails(Plane plane);
        /// <summary>
        /// retourne le nombre de vols programmés pour une semaine à partir d’une date donnée.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        int GetWeeklyFlightNumber(DateTime date);
        double GetDurationAverage(string destination);
        IList<Flight> SortFlights();
        IList<Passenger> GetThreeOlderTravellers(Flight flight);
        void ShowGroupedFlights();
        public delegate int GetScore(Passenger p); // methode annonyme
        Passenger GetSeniorPassenger(GetScore meth);


    }
}

