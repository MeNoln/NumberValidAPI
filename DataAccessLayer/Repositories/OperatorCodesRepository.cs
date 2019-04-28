using DataAccessLayer.EF;
using DataAccessLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public OperatorCodes Get(string number)
        {
            var model = db.OperatorCodes.Include(op => op.Operators).Where(code => code.OperCode == number).FirstOrDefault();

            return model;
        }
    }
}
