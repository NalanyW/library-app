namespace SoftwareDevelopment2.Models
{
    public class Book : Item
    {
        //properties
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int YearOfRelease { get; set; }
        public int LocationId { get; set; }
        //contructor
        public Book()
        {

        }
    }
}
