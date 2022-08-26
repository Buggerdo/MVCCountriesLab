namespace MVCCountriesLab
{
    public class CountryController
    {

        private CountryController()
        {
            LoadCountries();
            CountryDb = CountryDb.OrderBy(c => c.Name).ToList();
        }

        public static CountryController GetController()
        {
            return _countryController;
        }

        private static CountryController _countryController = new();

        List<Country> CountryDb = new();
  
        /// <summary>
        /// Loads countries from Db
        /// </summary>
        public void LoadCountries()
        {
            StreamReader sr = new("CountriesDb.txt");
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] columns = line.Split(',');
                CountryDb.Add(new Country(columns[0], (Continent)Enum.Parse(typeof(Continent), columns[1]), columns[2].Split(' ').ToList()));
            }
            sr.Close();
        }

        /// <summary>
        /// Starts a new CountryView
        /// </summary>
        /// <param name="c"></param>
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
            CountryAction(CountryDb[GetSelection()]);
        }

        /// <summary>
        /// Gets the user selection
        /// </summary>
        /// <returns></returns>
        public int GetSelection()
        {
            do
            {
                Console.Write("Please select a country from the above list: ");
                if(int.TryParse(Console.ReadLine(), out int index) && index < CountryDb.Count + 1 && index > 0)
                    return --index;
                Console.WriteLine("Sorry that is not a valid section.");
            } while(true);
        }
    }
}