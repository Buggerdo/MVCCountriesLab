namespace MVCCountriesLab
{
    public class Country
    {
        public Country(string name, Continent continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}