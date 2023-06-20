using APIBarberGenuine.Models;

namespace APIBarberGenuine.Repository.IRepository
{
    public interface IClientRepository : IRepository<Client>
    {
        Task<Client> Update(Client entity);
    }
}
