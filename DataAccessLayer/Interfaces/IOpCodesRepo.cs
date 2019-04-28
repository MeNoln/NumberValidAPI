using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Interfaces
{
    public interface IOpCodesRepo
    {
        OperatorCodes GetCurrent(int id);
        OperatorCodes Get(string number);
    }
}
