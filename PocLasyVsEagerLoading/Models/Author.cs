namespace PocLasyVsEagerLoading.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book> books { get; set; } 
    }
}
