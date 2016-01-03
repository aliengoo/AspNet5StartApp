using System.Threading.Tasks;
using AspNet5StartApp.Models;

namespace AspNet5StartApp.Repositories
{
    public interface IRepository<T> where T : ModelBase
    {
        Task<T> FindById(string id);

        Task<T> Update(T t);

        Task<T> Insert(T t);

        Task Delete(string id);
    }
}