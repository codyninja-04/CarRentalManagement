namespace CarRentalManagement.Domain
{
    public class Customer : basedomainmodel
    {
        public String? DrivingLicense {  get; set; }
        public String? Address { get; set; }
        public String? ContactNumber { get; set; }
        public String? EmailAddress { get; set; }

    }
}
