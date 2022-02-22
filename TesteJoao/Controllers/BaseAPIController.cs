using Microsoft.AspNetCore.Mvc;
using TesteJoaoLib.DAL;

namespace TesteJoao.Controllers
{
    public abstract class BaseRepositoryAPIController<T>: ControllerBase where T : BaseDbEntity
    {
        private readonly ILogger<BaseRepositoryAPIController<T>> _logger;
        private readonly IBaseRepository<T> repo;

        protected BaseRepositoryAPIController(ILogger<BaseRepositoryAPIController<T>> logger, IBaseRepository<T> blogRepository)
        {
            _logger = logger;
            repo = blogRepository;
        }

        [HttpGet(Name = "GetAll")]
        public IEnumerable<T> GetAll()
        {
            return repo.Get();
        }

        [HttpGet(Name = "Get")]
        public IEnumerable<T> Get(int id)
        {
            return repo.Get(e => e.Id == id);
        }

        [HttpPost(Name = "Add")]
        public string Add(T entity)
        {
            repo.Insert(entity);
        }
    }
}
