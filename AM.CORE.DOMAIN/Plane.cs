using System;
namespace AM.CORE.DOMAIN
{
    public class Plane
    {
        public Plane() { }
        public Plane(PlaneType pt, int capacity, DateTime date) {

            this.MyPlaneType = pt;
            this.Capacity = capacity;
            this.ManufactureDate = date;

        }
               public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "Capacity:" + Capacity + ";"
                + "ManufactureDate:" + ManufactureDate + ";"
                + "PlaneId:" + PlaneId + ";"
                + "PlaneType:" + MyPlaneType;
        }
    }
    }


