using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie matrixInstance = new Movie();
            Movie nextFridayInstance = new Movie();

            matrixInstance.MovieName = "Matrix";
            matrixInstance.Rate = 6.7;
            matrixInstance.ReleaseDate = new DateTime(2005, 3, 18);

            matrixInstance.Languages = new Language[3];
            matrixInstance.Languages[0] = Language.French;
            matrixInstance.Languages[1] = Language.Chinese;
            matrixInstance.Languages[2] = Language.English;


            matrixInstance.Countries = new Country[2];
            matrixInstance.Countries[0] = Country.France;
            matrixInstance.Countries[1] = Country.Italy;

            matrixInstance.Genres = new Genre[5];
            matrixInstance.Genres[0] = Genre.Action;
            matrixInstance.Genres[1] = Genre.Comedy;
            matrixInstance.Genres[2] = Genre.Drama;
            matrixInstance.Genres[3] = Genre.Thriller;
            matrixInstance.Genres[4] = Genre.Horror;

            nextFridayInstance.MovieName = "Next Friday";
            nextFridayInstance.Rate = 5.4;
            nextFridayInstance.ReleaseDate = new DateTime(2009, 5, 19);

            nextFridayInstance.Languages = new Language[2];
            nextFridayInstance.Languages[0] = Language.French;
            nextFridayInstance.Languages[1] = Language.Serbian;

            nextFridayInstance.Countries = new Country[1];
            nextFridayInstance.Countries[0] = Country.USA;

            nextFridayInstance.Genres = new Genre[5];
            nextFridayInstance.Genres[0] = Genre.Action;
            nextFridayInstance.Genres[1] = Genre.Comedy;
            nextFridayInstance.Genres[2] = Genre.Drama;
            nextFridayInstance.Genres[3] = Genre.Thriller;
            nextFridayInstance.Genres[4] = Genre.Horror;

            matrixInstance.Display();
            nextFridayInstance.Display();

        }
    }
    struct Movie
    {
        private string movieName;
        private double rate;
        private DateTime releaseDate;
        private Genre[] genres;
        private Language[] languages;
        private Country[] countries;

        public string MovieName { get { return movieName; } set { movieName = value; } }
        public double Rate { get { return rate; } set { rate = value; } }
        public DateTime ReleaseDate { get { return releaseDate; } set { releaseDate = value; } }
        public Genre[] Genres { get { return genres; } set { genres = value; } }
        public Language[] Languages { get { return languages; } set { languages = value; } }
        public Country[] Countries { get { return countries; } set { countries = value; } }

        public void Display()
        {
            Console.Write($"Movie: {movieName}\nRate: {rate} out of 10\nReleased on: {releaseDate.ToShortDateString()}\nLanguages: ");

            for (int i = 0; i < Languages.Length; i++)
            {
                Console.Write(Languages[i]);
                if (i < Languages.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            Console.Write("Countries: ");

            for (int i = 0; i < Countries.Length; i++)
            {
                Console.Write(Countries[i]);
                if (i < Countries.Length - 1)
                    Console.Write(", ");

            }
            Console.Write("\nGenres: ");

            for (int i = 0; i < Genres.Length; i++)
            {
                Console.Write(Genres[i]);
                if (i < Genres.Length - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
            }
            Console.WriteLine("----------------");
        }
    }

    enum Genre
    {
        Comedy,
        Drama,
        Horror,
        Thriller,
        Action,
        Documentary
    }
    enum Language
    {
        English,
        Spanish,
        Serbian,
        Italian,
        Chinese,
        Japanese,
        French
    }
    enum Country
    {
        Italy,
        USA,
        China,
        Japan,
        India,
        France,
        Argentina,
        Spain

    }
}
