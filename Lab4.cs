using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Lab4
    {
        string sNum;
        int i, nNum;
        long fact;


        public void Factorial()
        {
            try { 
            Console.WriteLine("Wecome to the factorial calculator! \n" +
                 " \n Enter an integer greater then zero but less then and not including 12!");
            sNum = Console.ReadLine(); nNum = Convert.ToInt32(sNum);
            for (i = nNum - 1; i >= 1; i--)
            {
                nNum = nNum * i;
            }
            fact = nNum;
            Console.WriteLine("The factorial of " + sNum + " is " + fact);
            Console.WriteLine("Would you like to factorize another number?  Y for yes, anything else for no.");
            string answer = Console.ReadLine().ToUpper();


            if (answer == "Y")
            {
                Factorial();
            }
            else
            {
                Console.WriteLine("I'm sad for you.");
            }
        }
                            catch
            { Console.WriteLine("You done and messed up A-A-Ron!"); }

        }

    

        static void Main(string[] args)
        {
            try
            {
                Lab4 L4 = new Lab4();
                L4.Factorial();
                Console.ReadLine();
            }
            catch
            { Console.WriteLine("You done and messed up A-A-Ron!"); }
        }
    }
}
