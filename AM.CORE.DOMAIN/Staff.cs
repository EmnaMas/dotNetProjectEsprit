﻿using System;
namespace AM.CORE.DOMAIN
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return base.ToString() //l'appellation de la classe passenger
                + "EmployementDate:" + EmployementDate + ";"
                + "Function:" + Function + ";"
                + "Salary:" + Salary;
        }
        //question 12 Polymorphisme par héritage
        public override string GetPassengerType()
        {
            return base.GetPassengerType() // elle affiche I m passanger
                + "I am a Staff Member";
        }

    }



}

