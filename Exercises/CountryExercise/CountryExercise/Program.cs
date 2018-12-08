using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldNamespace;

namespace CountryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Country countryOneInstance = new Country();
            Country countryTwoInstance = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Language.Bosnian.ToString();
            countryLanguages.SecondLanguage = Language.Urdu.ToString();

            countryOneInstance.CountryLanguages = countryLanguages;
            countryOneInstance.PlanetName = "Earth";
            countryOneInstance.CountryName = "Germany";
            countryOneInstance.Currency = Currencies.BAM;
            countryOneInstance.Continents = Continents.Americas;

            countryOneInstance.SayHi();
            countryOneInstance.SayHi(countryOneInstance.CountryName);
            Console.WriteLine($"Planet {countryOneInstance.PlanetName} and country {countryOneInstance.CountryName} and currency {countryOneInstance.Currency}");
           
        }
    }
   
}
namespace WorldNamespace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;
        public string PlanetName { get { return planetName; } set { planetName = value; } }
        public Continents Continents { get { return continents; } set { continents = value; } }

        
    }

    class Country : World
    {
        private string countryName;
        private string capitalName;
        private Currencies currency;
        private CountryLanguages countrylanguages;

        public string CountryName { get { return countryName; } set { countryName = value; } }
        public string Capital { get { return capitalName; } set { capitalName = value; } }
        public Currencies Currency { get { return currency; } set { currency = value; } }
        public CountryLanguages CountryLanguages { get { return countrylanguages; } set { countrylanguages = value; } }

        public Country()
        {
            Capital = "Unknown";
            CountryName = "Unknown";
        }

        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
        public void SayHi(string country)
        {
            Console.WriteLine($"Hi!, {country}");
        }
    }
    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage { get { return firstLanguage; } set { firstLanguage = value; } }
        public string SecondLanguage { get { return secondLanguage; } set { secondLanguage = value; } }
    }

    enum Continents
    {
        Europe,
        Asia,
        Americas
    }
    enum Currencies
        {
            BAM,
            Rupee,
            Dolla
        }
        enum Language
        {
            Bosnian,
            Urdu,
            english
        }
    }


    

   
