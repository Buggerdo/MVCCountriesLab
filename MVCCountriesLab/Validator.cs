namespace MVCCountriesLab
{
    public static class Validator
    {
        /// <summary>
        /// Asks the user if they would like to continue
        /// </summary>
        /// <returns>True if user wants to continue</returns>
        public static bool Continue()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Would you like learn about another country? (y/n): ");
            if("yes".StartsWith(Console.ReadLine().ToLower()))
                return true;
            else
                return false;
        }
    }
}
