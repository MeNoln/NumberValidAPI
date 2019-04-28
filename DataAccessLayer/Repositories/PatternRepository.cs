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

        public Patterns GetCurrent(Patterns context)
        {
            var model = db.Patterns.Where(code => code.CountryCode == context.CountryCode).FirstOrDefault();
            return model;
        }
    }
}
