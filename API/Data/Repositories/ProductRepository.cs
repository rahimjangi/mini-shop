using API.Entities;

namespace API.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }
    }
}
