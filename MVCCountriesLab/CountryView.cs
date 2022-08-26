namespace MVCCountriesLab
{
    public class CountryView
    {
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }

        private int currentColor = -1;

        /// <summary>
        /// Prints out the country
        /// </summary>
        public void Display()
        {
            Console.Clear();
            NextColor();
            Console.WriteLine($"Country:     {DisplayCountry.Name}");
            NextColor();
            Console.WriteLine($"Continent:   {DisplayCountry.Continent.ToString().Replace('_', ' ')}");
            NextColor();
            Console.WriteLine($"Flag colors: {string.Join(", ", DisplayCountry.Colors)}");
            Console.ResetColor();
        }

        /// <summary>
        /// Get the next color from the country color
        /// </summary>
        /// <returns></returns>
        private void NextColor()
        {
            if(currentColor < DisplayCountry.Colors.Count - 1) currentColor++;
            else currentColor = 0;
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[currentColor]);
        }
    }
}