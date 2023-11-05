using System;
namespace AM.CORE.DOMAIN
{
    public class Flight
    {
        
            public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane MyPlane { get; set; }
        public IList<Passenger> passengers { get; set; }
        public override string ToString()
        {
            return "Destination:" + Destination + ";"
                + "Departure:" + Departure + ";"
                + "FlightDate:" + FlightDate + ";"
                + "FlightId:" + FlightId + ";"
                + "EffectiveArrival:" + EffectiveArrival + ";"
                + "EstimatedDuration:" + EstimatedDuration;
        }
    }
}

