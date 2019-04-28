using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IPatternRepository
    {
        IEnumerable<Patterns> GetAllCountries();
        Patterns Get(int code);
    }
}
