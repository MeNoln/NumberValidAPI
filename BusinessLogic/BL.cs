using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class BL : IDisposable
    {
        private UnitOfWork db;
        public BL()
        {
            db = new UnitOfWork();
        }



        public void Dispose()
        {
            db.Dispose();
        }
    }
}
