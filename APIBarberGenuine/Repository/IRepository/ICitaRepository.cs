using APIBarberGenuine.Models;

namespace APIBarberGenuine.Repository.IRepository
{
    public interface ICitaRepository : IRepository<Cita>
    {
        Task<Cita> Update(Cita entity);
    }
}
