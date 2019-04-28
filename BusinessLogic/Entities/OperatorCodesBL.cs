using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
    public class OperatorCodesBL
    {
        public int Id { get; set; }
        public string OperCode { get; set; }
        public int CoutryCode { get; set; }
        public int OperatorsId { get; set; }

        public OperatorsBL Operators { get; set; }
    }
}
