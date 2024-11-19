using Microsoft.EntityFrameworkCore;
using PocLasyVsEagerLoading.Data;
using PocLasyVsEagerLoading.Models;

namespace PocLasyVsEagerLoading.Repositories
{
    public class Repository : IRepository
    {
        private readonly Context _context;

        public Repository(Context context)
        {
            _context = context;
        }
        public List<Author> EagerlyGetAll()
        {
            var authors = _context.Authors.Include(x=>x.books).ToList(); //Here we have included books so this is early loading
            return authors;                                              //While Executing It will automatically show book details
        }

        public List<Author> LazilyGetAll()
        {
            var authors = _context.Authors.ToList();                   //Here we have not included books so this is lasy loading
            foreach (var author in authors)                            //While Executing It will not show book details directly 
            {                                                          //Evenif we have added books here we need to seperately access the books
                var books = author.books;
            }
            return authors;
        }
    }
}
