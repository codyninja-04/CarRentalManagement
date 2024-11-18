namespace CarRentalManagement.Domain
{
    public class basedomainmodel
    {
        public int Id {  get; set; } 
        public DateTime CreatedDate { get; set; } 
        public DateTime UpdatedDate { get; set; }   
        public string? CreatedBy { get; set; } 
        public string? UpdatedBy { get; set; }    

    }
}
