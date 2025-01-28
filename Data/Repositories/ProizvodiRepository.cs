using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlucnoNatjecanje.Data.Repositories
{
    public class ProizvodiRepository
    {
        private readonly AppDbContext _db;

        public ProizvodiRepository()
        {
            _db = new AppDbContext();
        }

        public async Task<List<Proizvod>> GetAllAsync()
        {
            return await _db.Proizvodi
                .Include(p => p.Potkategorija)
                .ToListAsync();
        }
    }
}
