namespace SoftwareDevelopment2.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public int ItemId { get; set; }

        public Reservation() { }
    }
}
