namespace Bulky.DataAcess.Repository.IRepository.cs;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    IProductRepository Product { get;  }
    void Save();
    
    
}