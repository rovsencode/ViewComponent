namespace FirelloProject.Models.demo
{
    public class Book
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<BookImages>? BookImages { get; set; }    
    }
}
