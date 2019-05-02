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
    public class OperatorCodesRepository : IOpCodesRepo
    {
        private ApplicationContext db;
        public OperatorCodesRepository(ApplicationContext db)
        {
            this.db = db;
        }

        public OperatorCodes GetCurrent(int id)
        {
            var model = db.OperatorCodes.Find(id);
            return model;
        }

        public async Task<OperatorCodes> Get(string number)
        {
            var model = await db.OperatorCodes.Include(op => op.Operators).Where(code => code.OperCode == number).FirstOrDefaultAsync();

            return model;
        }
    }
}
