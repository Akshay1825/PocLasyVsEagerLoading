using PocLasyVsEagerLoading.Models;
using PocLasyVsEagerLoading.Repositories;

namespace PocLasyVsEagerLoading.Services
{
    public class Service : IService
    {
        private readonly IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository;
        }
        public List<Author> EagerlyGetAll()
        {
            return _repository.EagerlyGetAll();
        }

        public List<Author> LazilyGetAll()
        {
            return _repository.LazilyGetAll();
        }
    }
}
