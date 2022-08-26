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
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{DisplayCountry.Name}");
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{DisplayCountry.Continent.ToString().Replace('_', ' ')}");
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{string.Join(", ", DisplayCountry.Colors)}");
            Console.ResetColor();
        }

        /// <summary>
        /// Get the next color from the country color
        /// </summary>
        /// <returns></returns>
        private ConsoleColor NextColor()
        {
            if(currentColor < DisplayCountry.Colors.Count - 1) currentColor++;
            else currentColor = 0;
            return (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[currentColor]);
        }
    }
}