using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Bonus2
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;

            Console.WriteLine("What is your birthdate?");
            string sBDay = Console.ReadLine();
            var BDay = Convert.ToDateTime(sBDay);

            if(BDay.Day == today.Day && BDay.Month == today.Month)
            {
                Console.WriteLine("Happy Birthday!");
            }
            var time = today - BDay;
            int days = time.Days;
            int years = days / 365;

          

            Console.WriteLine("You are " + years + " years old!");
            Console.ReadLine();

            
        }
    }
}
