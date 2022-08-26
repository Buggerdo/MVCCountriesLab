using System.ComponentModel.DataAnnotations;

namespace MVCCountriesLab
{
    public enum Continent
    {
        Asia,
        Africa,
        [Display(Name = "North America")]
        NorthAmerica,
        [Display(Name = "South America")]
        SouthAmerica,
        Antarctica,
        Europe,
        Australia
    }
}