using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResolvingTheNplus1QueryProblem
{
    class ResolvingTheNplus1QueryProblem
    {
        private static void PrintCountriesAndCitiesWithQueryProblem(CountriesEntities countriesEntities)
        {
            string separatorLine = new string('-', 30);
            foreach (var country in countriesEntities.Countries)
            {
                // Console.WriteLine(country.CountryName + "\nCities:");
                foreach (var city in country.Cities)
                {
                    //          Console.WriteLine("      {0}", city.CityName);
                }
                // Console.WriteLine(SeparatorLine);
            }
        }

        private static void PrintCountriesWithoutQueryProblem(CountriesEntities countriesEntities)
        {
            string separatorLine = new string('-', 30);
            foreach (var country in countriesEntities.Countries.Include("Cities"))
            {
                // Console.WriteLine(country.CountryName + "\nCities:");
                foreach (var city in country.Cities)
                {
                    //        Console.WriteLine("      {0}", city.CityName);
                }
                // Console.WriteLine(SeparatorLine);
            }
        }

        private static void AddNewCountry(CountriesEntities countriesEntities)
        {
            Country country = new Country();
            country.CountryName = "Greece";
            country.Population = 500000;
            country.Cities.Add(new City{ CityName = "Athens" });
            country.Cities.Add(new City{ CityName = "Alexandroupoli" });
            country.Cities.Add(new City{ CityName = "Sparta" });
            countriesEntities.Countries.AddObject(country);
            countriesEntities.SaveChanges();
        }

        private static void AddCities(Country country)
        {
            for (int i = 0; i < 100; i++)
            {
                country.Cities.Add(new City{ CityName = country.CountryName + i });
            }
        }

        static void Main()
        {
            using (CountriesEntities countriesEntities = new CountriesEntities())
            {
                DateTime start = DateTime.Now;
                
                PrintCountriesAndCitiesWithQueryProblem(countriesEntities);
                Console.WriteLine(DateTime.Now - start);
                start = DateTime.Now;
                PrintCountriesWithoutQueryProblem(countriesEntities);
                Console.WriteLine(DateTime.Now - start);

                //AddNewCountry(countriesEntities);
                //foreach (var country in countriesEntities.Countries)
                //{
                //    AddCities(country);
                //}
                //countriesEntities.SaveChanges();
            }
        }
    }
}
