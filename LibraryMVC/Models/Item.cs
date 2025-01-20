namespace SoftwareDevelopment2.Models
{
    // de reden dat deze klasse bestaat is omdat we eerst de intentie
    // hadden om andere items dan boeken te kunnen reserveren. 
    // Deze klasse zou dan zorgen voor polymorphisme, omdat
    // er dan een table zou zijn met alle items in de database,
    // zonder dat het uitmaakt of het een boek of iets anders is.

    public class Item
    {
        public int Id { get; set; }

    }
}
