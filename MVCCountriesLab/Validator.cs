namespace MVCCountriesLab
{
    public static class Validator
    {
        public static bool Continue()
        {
            Console.Clear();
            Console.Write("Would you like learn about another country? (y/n): ");
            string userinput = Console.ReadLine();
            if("yes".Contains(userinput.ToLower()))
                return true;
            else
                return false;
        }
    }
}
