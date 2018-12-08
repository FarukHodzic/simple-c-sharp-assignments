using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            DateTime Time = DateTime.Now;

            string TimeNow = string.Format("{0:'It is ' HH 'o-clock,' mm ' minutes and' ss 'seconds. You are welcome.'}", Time);
            

            Console.WriteLine(TimeNow);
            
            
            


        }
    }
}
