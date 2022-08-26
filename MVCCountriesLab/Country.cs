using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVCCountriesLab
{
    public class Country
    {
        public string Name { get; set; }

        public Continent Continent { get; set; }

        public List<string> Colors { get; set; }
    }
}