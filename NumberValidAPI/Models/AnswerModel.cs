using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NumberValidAPI.Models
{
    public class AnswerModel
    {
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
