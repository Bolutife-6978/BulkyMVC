namespace Bulky.DataAcess.Repository.IRepository.cs;

public interface IUnitOfWork
{
    ICategoryRepository Category { get; }
    void Save();
}