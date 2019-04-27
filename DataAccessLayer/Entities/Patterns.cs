using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public partial class Patterns
    {
        public int Id { get; set; }
        public int CountryCode { get; set; }
        public string Country { get; set; }
        public string CountryShort { get; set; }
    }
}
