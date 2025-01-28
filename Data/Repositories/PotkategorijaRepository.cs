using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlucnoNatjecanje.Data.Repositories
{
    public class PotkatekorijaRepository
    {
        private readonly AppDbContext _db;

        public PotkatekorijaRepository()
        {
            _db = new AppDbContext();
        }

        public async Task<List<Potkategorija>> GetAllAsync()
        {
            return await _db.Potkategorije
                .ToListAsync();
        }
    }
}
