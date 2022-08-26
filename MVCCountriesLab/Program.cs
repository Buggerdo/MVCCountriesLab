namespace MVCCountriesLab
{
    internal class Program
    {
        static void Main()
        {
            CountryController countryController = new();
            countryController.WelcomeAction();
        }
    }
}