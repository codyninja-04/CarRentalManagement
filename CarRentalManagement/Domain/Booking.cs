﻿namespace CarRentalManagement.Domain
{
    public class Booking: basedomainmodel
    {
        public DateTime DateOut { get; set; } 
        
        public DateTime DateIn { get; set; }       

        public int VehicleId { get; set; }

        public int CustomerId { get; set; }     
    }
}
