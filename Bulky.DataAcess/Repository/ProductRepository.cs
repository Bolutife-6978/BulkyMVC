using Bulky.DataAcess.Data;
using Bulky.DataAcess.Repository.IRepository.cs;
using Bulky.Models;

namespace Bulky.DataAcess.Repository;

public class ProductRepository : Repository<Product>, IProductRepository
{
    private ApplicationDbContext _db;
    public ProductRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Product obj)
    {
        _db.Products.Update(obj);
    }
}