using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzlucnoNatjecanje.Data.Repositories
{
    public class DostavaRepository
    {
        private readonly AppDbContext _db;

        public DostavaRepository()
        {
            _db = new AppDbContext();
        }


        public async Task<List<MetodaDostave>> GetAllAsync()
        {
            return await _db.MetodeDostave.ToListAsync();
        }

        public async Task<MetodaDostave> GetByIdAsync(int id)
        {
            return await _db.MetodeDostave.SingleOrDefaultAsync(m => m.MetodaDostaveId == id);
        }

        public void Update(MetodaDostave current, MetodaDostave updated)
        {
            _db.Entry(current).CurrentValues.SetValues(updated);
            _db.Entry(current).State = EntityState.Modified;
        }

        public async Task<bool> IsSavedAsync()
        {
            int saved = await _db.SaveChangesAsync();

            return saved > 0;
        }
    }
}
