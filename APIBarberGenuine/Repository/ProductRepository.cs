using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Repository.IRepository;

namespace APIBarberGenuine.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly BarberGenuineContext _db;
        public ProductRepository(BarberGenuineContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Product> Update(Product entity)
        {
            _db.Products.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
