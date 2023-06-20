using APIBarberGenuine.Models;

namespace APIBarberGenuine.Repository.IRepository
{
    public interface IFacturaRepository : IRepository<Factura>
    {
        Task<Factura> Update(Factura entity);
    }
}
