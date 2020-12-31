using System;
using System.Collections.Generic;
using System.Text;

namespace Chart_Sample
{
    public class Model
    {
        public Model(DateTime year, double export, double import)
        {
            Year = year;
            Export = export;
            Import = import;
        }

        public DateTime Year { get; set; }

        public double Export { get; set; }

        public double Import { get; set; }
    }
}
