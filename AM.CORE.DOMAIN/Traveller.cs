using System;
namespace AM.CORE.DOMAIN
{
    public class Traveller:Passenger
    {
        public string HealthInformation { get; set; }
        public string Nationality { get; set; }
        public override string ToString()
        {
            return base.ToString() //l'appellation de la classe passenger
                + "HealthInformation:" + HealthInformation + ";"
                + "Nationality:" + Nationality;
        }
        //question 12 Polymorphisme par héritage
        public override string GetPassengerType()
        {
            return "I am a Traveller";
        }
    }
}

