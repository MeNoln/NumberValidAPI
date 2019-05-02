using DataAccessLayer.EF;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PatternRepository : IRepository<Patterns>, IPatternRepository
    {
        private ApplicationContext db;
        public PatternRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public async Task<IEnumerable<Patterns>> GetAllCountries()
        {
            return await db.Patterns.ToListAsync();
        }

        public Patterns GetCurrent(int id)
        {
            var model = db.Patterns.Find(id);
            return model;
        }

        public async Task<Patterns> Get(int code)
        {
            var model = await db.Patterns.Where(c => c.CountryCode == code).FirstOrDefaultAsync();

            return model;
        }
    }
}
