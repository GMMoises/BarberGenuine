using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Repository.IRepository;

namespace APIBarberGenuine.Repository
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {
        private readonly BarberGenuineContext _db;
        public ClientRepository(BarberGenuineContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Client> Update(Client entity)
        {
           _db.Clients.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
