using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Entities
{
    public class AnswerBL
    {
        public bool valid { get; set; }
        public string number { get; set; }
        public string e164format { get; set; }
        public string internationalFormat { get; set; }
        public string nationalFormat { get; set; }
        public int CountryCode { get; set; }
        public string Country { get; set; }
        public string CountryShort { get; set; }
        public string OperatorName { get; set; }
        public string OperCode { get; set; }
    }
}
