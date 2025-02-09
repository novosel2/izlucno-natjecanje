using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlucnoNatjecanje.Data.Repositories
{
    public class KupciRepository
    {
        private readonly AppDbContext _db;

        public KupciRepository()
        {
            _db = new AppDbContext();
        }

        public async Task<List<Kupac>> GetAllAsync()
        {
            return await _db.Kupci
                .Include(k => k.Racun)
                .ToListAsync();
        }
    }
}
