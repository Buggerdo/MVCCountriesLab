namespace MVCCountriesLab
{
    internal class Program
    {
        static void Main()
        {
            CountryController countryController = new();
            do
            {
                countryController.WelcomeAction(); 
            } while(Validator.Continue());
        }
    }
}