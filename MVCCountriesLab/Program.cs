namespace MVCCountriesLab
{
    internal class Program
    {
        static void Main()
        {
            CountryController countryController = CountryController.GetController();
            do
            {
                countryController.WelcomeAction();
            } while(Validator.Continue());
        }
    }
}