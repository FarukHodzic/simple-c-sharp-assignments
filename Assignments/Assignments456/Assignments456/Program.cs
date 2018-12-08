using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments456
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upside Down 0 Triangle
            for (int i = 1; i <= 16; i++)
            {
                for (int j = i; j <= 16; j++)
                {
                    Console.Write(0);
                }
                Console.WriteLine();
            }

            // Random Months & Days

            Random months = new Random();
            int x = months.Next(1, 13);
            string y = x.ToString();
            switch (y)
            { case "1": Console.WriteLine(y + " January"); break;
              case "2": Console.WriteLine(y+ " February"); break;
              case "3": Console.WriteLine(y+ " March"); break;
              case "4": Console.WriteLine(y+ " April"); break;
              case "5": Console.WriteLine(y+" May"); break;
              case "6": Console.WriteLine(y+" June"); break;
              case "7": Console.WriteLine(y+" July"); break;
              case "8": Console.WriteLine(y+" August"); break;
              case "9": Console.WriteLine(y+" September"); break;
              case "10": Console.WriteLine(y+" October"); break;
              case "11": Console.WriteLine(y+" November"); break;
              case "12": Console.WriteLine(y+" December"); break;
            }

            //Dice Roller



            do
            {
                Console.WriteLine("Roll dice? (yes/no)");
                string answer = Console.ReadLine();
                answer = answer.ToLower();
                if (answer == "yes")
                {
                    Random rand = new Random();
                    int dice = rand.Next(1, 7);
                    Console.WriteLine(dice);
                }
                else
                    break;
            }
            while (true);




                    

          
        }
    }
}
