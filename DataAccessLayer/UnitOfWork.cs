using DataAccessLayer.EF;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private PatternRepository patRepo;
        private OperatorCodesRepository opcodeRepo;
        public UnitOfWork()
        {
            db = new ApplicationContext();
        }

        public IRepository<Patterns> PatternsRepo
        {
            get
            {
                if (patRepo == null)
                    patRepo = new PatternRepository(db);
                return patRepo;
            }
        }

        public IRepository<OperatorCodes> OpCodesRepo
        {
            get
            {
                if (opcodeRepo == null)
                    opcodeRepo = new OperatorCodesRepository(db);
                return opcodeRepo;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
