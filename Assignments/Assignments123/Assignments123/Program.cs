using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments123
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Assignment 1 - Friendly conversation with C#

            var input = 0;
            DateTime thisyear = DateTime.Today;
            string yearonly = string.Format("{0: yyyy }", thisyear);
            int intTemp = Convert.ToInt32(yearonly);
            int csharpold = intTemp - 2002;

            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name + ", my name is C#. How old are you?");

            if (int.TryParse(Console.ReadLine(), out input))
            { Console.WriteLine(input + ", good. As for me, I was born on 2002, which makes me " + csharpold + " now."); }

            else
            {
                Console.WriteLine("Please type in a number");
                int newinput = int.Parse(Console.ReadLine());
                Console.WriteLine(newinput + ", good. As for me, I was born on 2002, which makes me " + csharpold + " now.");
            }

            //Assignment 2 - Time machine

            Console.WriteLine("Enter the day of the month.");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the month of the year.");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the year.");
            int year = int.Parse(Console.ReadLine());

            DateTime inputDate = new DateTime(year, month, day);

            string exactday = string.Format("{0: dddd}", inputDate);

            Console.WriteLine("The day of this exact date should be{0}.", exactday);

            //Assignment 3 - Weekdays and colors

            DateTime date = DateTime.Today;
            string daycolor = string.Format("{0:dddd}", date);

            switch (daycolor)
            {
                case "Monday":Console.WriteLine("Blue"); break;
                case "Tuesday": Console.WriteLine("Grey"); break;
                case "Wednesday":Console.WriteLine("Red"); break;
                case "Thursday": Console.WriteLine("Orange"); break;
                case "Friday": Console.WriteLine("White"); break;
                case "Saturday": Console.WriteLine("Yellow"); break;
                case "Sunday": Console.WriteLine("Green"); break;
            }
          
        

        }
    }
}
