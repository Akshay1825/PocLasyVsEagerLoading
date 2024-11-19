using System.ComponentModel.DataAnnotations.Schema;

namespace PocLasyVsEagerLoading.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
