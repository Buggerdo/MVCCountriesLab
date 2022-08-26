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
            string colors = string.Join(", ", DisplayCountry.Colors);
            Console.Clear();
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{DisplayCountry.Name}");
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{DisplayCountry.Continent}");
            Console.ForegroundColor = NextColor();
            Console.WriteLine($"{colors}");
            Console.ResetColor();
        }

        private ConsoleColor NextColor()
        {
            if(currentColor < DisplayCountry.Colors.Count - 1) currentColor++;
            else currentColor = 0;
            return (ConsoleColor)Enum.Parse(typeof(ConsoleColor), DisplayCountry.Colors[currentColor]);
        }
    }
}