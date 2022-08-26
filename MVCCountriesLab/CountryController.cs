namespace MVCCountriesLab
{
    public class CountryController
    {
        string filePath = "CountriesDb.txt";

        public CountryController()
        {
            LoadCountries();
        }

        List<Country> CountryDb = new();
            //new Country("USA", Continent.North_America,new List<string> {"Red", "White", "blue" }),
            //new Country("Canada", Continent.North_America,new List<string> {"Red", "White" })


        //load the countries from the file into the CountryDb list
        public void LoadCountries()
        {
            StreamReader sr = new(filePath);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] columns = line.Split(',');
                CountryDb.Add(new Country(columns[0], (Continent)Enum.Parse(typeof(Continent), columns[1]), columns[2].Split(' ').ToList()));
            }
        }

        public void CountryAction(Country c)
        {
            CountryView country = new(c);
            country.Display();
        }

        /// <summary>
        /// Welcome menu
        /// </summary>
        public void WelcomeAction()
        {
            Console.Clear();
            CountryListView countryListView = new(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.");
            countryListView.Display();
            int index = GetSelection();
            CountryAction(CountryDb[index - 1]);
        }

        /// <summary>
        /// Gets the user selection
        /// </summary>
        /// <returns></returns>
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