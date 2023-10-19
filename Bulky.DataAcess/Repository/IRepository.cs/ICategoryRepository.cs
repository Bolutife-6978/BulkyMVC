using Bulky.Models;

namespace Bulky.DataAcess.Repository.IRepository.cs;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category obj);
    
}