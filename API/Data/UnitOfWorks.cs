using API.Data.Repositories;

namespace API.Data
{
    public class UnitOfWorks : IUnitOfWorks
    {
        private readonly StoreContext _context;

        public IProductRepository Product { get; }

        public UnitOfWorks(StoreContext context)
        {
            _context = context;
            Product = new ProductRepository(_context);
        }
    }
}
