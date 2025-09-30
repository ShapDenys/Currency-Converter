using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class Currency
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public double Rate { get; set; }

        public Currency(string name, string code, double rate)
        {
            this.Name = name;
            this.Code = code;
            this.Rate = rate;

        }
    }
}
