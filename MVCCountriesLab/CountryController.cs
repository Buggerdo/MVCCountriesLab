namespace MVCCountriesLab
{
    public class CountryController
    {
        List<Country> CountryDb = new()
        {
            new Country("USA", "North America",new List<string> {"Red", "White", "blue" }),
            new Country("Canada", "North America",new List<string> {"Red", "White", "blue" })
        };

        public void CountryAction(Country c)
        {
            CountryView country = new(c);
        }

        /// <summary>
        /// This will take no parameter and pass CountryDb into the CountryListView class. Then, it will print “Hello, welcome to the country app. Please select a country from the following list:” Then it will call Display() on the CountryListView. Next allow the user to select a country by index.Upon getting the country out of CountryDb, pass that country along to the CountryAction() method. After that’s done, ask if the user would like to learn about another country.
        /// </summary>
        public void WelcomeAction()
        {
            CountryListView countryListView = new(CountryDb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            countryListView.Display();           
        }

        public int GetSelection()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}