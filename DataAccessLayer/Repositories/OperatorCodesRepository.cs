using DataAccessLayer.EF;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class OperatorCodesRepository : IRepository<OperatorCodes>
    {
        private ApplicationContext db;
        public OperatorCodesRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public OperatorCodes GetCurrent(OperatorCodes context)
        {
            var model = db.OperatorCodes.Include(op => op.Operators).Where(code => code.OperCode == context.OperCode).FirstOrDefault();
            return model;
        }
    }
}
