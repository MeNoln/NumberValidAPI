using AutoMapper;
using BusinessLogic.Entities;
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

        public IEnumerable<SupportedCountries> GetCountries()
        {
            List<SupportedCountries> list = new List<SupportedCountries>();
            
            foreach (var item in db.CurrentPattern.GetAllCountries())
                list.Add(new SupportedCountries { Country = item.Country});

            return list;
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
