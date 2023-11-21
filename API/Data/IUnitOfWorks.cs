using API.Data.Repositories;

namespace API.Data
{
    public interface IUnitOfWorks
    {
        IProductRepository Product { get; }
    }
}
