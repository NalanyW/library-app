namespace SoftwareDevelopment2.Models
{
    public enum AgeGroup
    {
        Under18,
        Over18
    }

    public class Subscription
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public AgeGroup AgeGroup { get; set; }
        public int ItemsPerYear { get; set; }
        public int ItemsAtSameTime { get; set; }
        public int LoanPeriodInDays { get; set; }
        public int ExtendsInARow { get; set; }
        public float ReservationCost { get; set; }
        public float FinePerItemPerDay { get; set; }
        public float SubscriptionCostPerMonth { get; set; }

        public Subscription() { }
    }
}
