using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Repository.IRepository;

namespace APIBarberGenuine.Repository
{
    public class CitaRepository : Repository<Cita>, ICitaRepository
    {
        private readonly BarberGenuineContext _db;

        public CitaRepository(BarberGenuineContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Cita> Update(Cita entity)
        {
            _db.Citas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
