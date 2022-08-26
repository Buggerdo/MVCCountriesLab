namespace MVCCountriesLab
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public List<Country> Countries { get; set; }


        /// <summary>
        /// Print the name of each country in the list along with the index for each country
        /// </summary>
        public void Display()
        {
            foreach(var country in Countries)
            {
                Console.WriteLine($"{Countries.IndexOf(country) + 1}: {country.Name}");
            }
        }
    }
}