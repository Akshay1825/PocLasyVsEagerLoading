using PocLasyVsEagerLoading.Models;

namespace PocLasyVsEagerLoading.Services
{
    public interface IService
    {
        public List<Author> EagerlyGetAll();

        public List<Author> LazilyGetAll();
    }
}
