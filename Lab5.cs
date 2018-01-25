using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Lab5
    {

        string ask1, ask2;
        public void RandomDice()
        {


                Console.WriteLine("How many sides does your first dice need?");
                ask1 = Console.ReadLine(); int sides1 = Convert.ToInt16(ask1) + 1;
                Console.WriteLine("How many sides does your second dice need?");
                ask2 = Console.ReadLine(); int sides2 = Convert.ToInt16(ask2);
                Random dice = new Random((int)DateTime.Now.Ticks);
                int dN1 = dice.Next(1, sides1); int dN2 = dice.Next(1, sides2);
                Console.WriteLine("Dice 1 was " + dN1 + " & dice 2 was " + dN2);
                Console.WriteLine("Would you like to roll again?");
                String answer = Console.ReadLine().ToUpper();
                if(answer == "Y")
                {
                    RandomDice();
                }
                else
                {
                    Console.WriteLine("Then we'll end here.");
                }
            

        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Would you like to roll two dice?");
                string Answer = Console.ReadLine().ToUpper();
                if (Answer == "Y")
                {
                    Lab5 L5 = new Lab5();
                    L5.RandomDice();
                }
                Console.ReadLine();
            }
            catch
            {

            }
        }
    }
}    
    
