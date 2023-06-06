namespace SoftwareDevelopment2.Models
{
    public class Book : Item
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int YearOfRelease { get; set; }
        public string Location { get; set; }

        //contructor
        public Book()
        {
            
        }
    }
}
