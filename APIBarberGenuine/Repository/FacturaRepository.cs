using APIBarberGenuine.Data;
using APIBarberGenuine.Models;
using APIBarberGenuine.Repository.IRepository;

namespace APIBarberGenuine.Repository
{
    public class FacturaRepository : Repository<Factura>, IFacturaRepository
    {
        private readonly BarberGenuineContext _db;
        public FacturaRepository(BarberGenuineContext db):base(db)
        {
            _db = db;
        }

        public async Task<Factura> Update(Factura entity)
        {
            _db.Facturas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
