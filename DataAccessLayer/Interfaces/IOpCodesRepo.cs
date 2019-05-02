using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IOpCodesRepo
    {
        OperatorCodes GetCurrent(int id);
        Task<OperatorCodes> Get(string number);
    }
}
