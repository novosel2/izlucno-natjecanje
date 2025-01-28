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

        public void Update(MetodaDostave current, MetodaDostave updated)
        {
            _db.Entry(current).CurrentValues.SetValues(updated);
        }

        public async Task<bool> IsSavedAsync()
        {
            int saved = await _db.SaveChangesAsync();

            return saved > 0;
        }
    }
}
