using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class OperatorCodes
    {
        public int Id { get; set; }
        public string OperCode { get; set; }
        public int CoutryCode { get; set; }
        public int OperatorsId { get; set; }

        public Operators Operators { get; set; }
    }
}
