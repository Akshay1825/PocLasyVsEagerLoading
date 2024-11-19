using PocLasyVsEagerLoading.Data;
using PocLasyVsEagerLoading.Models;

namespace PocLasyVsEagerLoading.Repositories
{
    public interface IRepository
    {
        public List<Author> EagerlyGetAll();
        public List<Author> LazilyGetAll();
        
    }
}
