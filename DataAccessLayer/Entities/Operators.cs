using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class Operators
    {
        public Operators()
        {
            OperatorCodes = new HashSet<OperatorCodes>();
        }

        public int Id { get; set; }
        public string OperatorName { get; set; }

        public ICollection<OperatorCodes> OperatorCodes { get; set; }
    }
}
