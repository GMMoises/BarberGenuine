using APIBarberGenuine.Models;

namespace APIBarberGenuine.Repository.IRepository
{
    public interface IProductRepository: IRepository<Product>
    {
        Task<Product> Update(Product entity);
    }
}
