﻿namespace CarRentalManagement.Domain
{
    public class Vehicle : basedomainmodel
    {
        public int  Year { get; set; }  
        public string?LicensePlateNumber { get; set; } 
        public int  MakeId { get; set; }   
        public int ModelId { get; set; }

        public int ColourId { get; set; }
    }
}
