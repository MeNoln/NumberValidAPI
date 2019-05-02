using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IPatternRepository
    {
        Task<IEnumerable<Patterns>> GetAllCountries();
        Task<Patterns> Get(int code);
    }
}
