namespace MVCCountriesLab
{
    public class CountryView
    {
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }

        public void Display()
        {
            string colors = string.Join(", ", DisplayCountry.Colors);

            //This method will print out the Name, Continent, and Colors of the Country DisplayCountry property
            Console.WriteLine($"{DisplayCountry.Name}" +
                $"\n{DisplayCountry.Continent}" +
                $"\n{colors}");
        }
    }
}