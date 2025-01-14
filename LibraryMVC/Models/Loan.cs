namespace SoftwareDevelopment2.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ItemId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Loan() { }
    }
}
