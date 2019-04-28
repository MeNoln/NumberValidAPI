using DataAccessLayer.EF;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class PatternRepository : IRepository<Patterns>, IPatternRepository
    {
        private ApplicationContext db;
        public PatternRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public IEnumerable<Patterns> GetAllCountries()
        {
            return db.Patterns.ToList();
        }

        public Patterns GetCurrent(int id)
        {
            var model = db.Patterns.Find(id);
            return model;
        }

        public Patterns Get(int code)
        {
            var model = db.Patterns.Where(c => c.CountryCode == code).FirstOrDefault();

            return model;
        }
    }
}
