namespace MVCCountriesLab
{
    public class CountryController
    {
        List<Country> CountryDb = new()
        {
            new Country("USA", Continent.North_America,new List<string> {"Red", "White", "blue" }),
            new Country("Canada", Continent.North_America,new List<string> {"Red", "White" })
        };

        public void CountryAction(Country c)
        {
            CountryView country = new(c);
            country.Display();
        }

        public void WelcomeAction()
        {
            CountryListView countryListView = new(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.");
            countryListView.Display();
            int index = GetSelection();
            CountryAction(CountryDb[index - 1]);
        }

        public int GetSelection()
        {
            do
            {
                Console.Write(" Please select a country from the above list: ");
                string userinput = Console.ReadLine();
                if(int.TryParse(userinput, out int index) && index < CountryDb.Count + 1 && index > 0)
                    return index;
                Console.WriteLine("Sorry that is not a valid section.");
            } while(true);
        }

    }
}