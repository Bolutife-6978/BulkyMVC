using Bulky.Models;

namespace Bulky.DataAcess.Repository.IRepository.cs;

public interface IProductRepository : IRepository<Product>
{
    void Update(Product obj);
}