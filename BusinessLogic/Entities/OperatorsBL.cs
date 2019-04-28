using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
    public class OperatorsBL
    {
        public OperatorsBL()
        {
            OperatorCodes = new HashSet<OperatorCodesBL>();
        }

        public int Id { get; set; }
        public string OperatorName { get; set; }

        public ICollection<OperatorCodesBL> OperatorCodes { get; set; }
    }
}
