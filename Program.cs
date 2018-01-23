using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool program = true, moveOn = true;

            try
            {
                Console.WriteLine("Hello.  This world is full of numbers.  Some of the");
                Console.WriteLine("numbers are large, and some are small.  Before we get");
                Console.WriteLine("started I will need to know your name.");
                string name = Console.ReadLine();
                //getting a number to play the game with
                Console.WriteLine(name + "!  That's great.  I thought I knew you.");
                //program while loops to keep the game going FOREVER!
                while (program == true)
                {
                    while (moveOn == true)
                    {
                        //Introduction and Name

                        Console.WriteLine("Now for the game!  I want you to enter a number");
                        Console.WriteLine("between 1 and 100.");
                        string sNum = Console.ReadLine();
                        double nNum = Convert.ToDouble(sNum);
                        if (nNum >= 1 && nNum <= 100)
                        {
                            Console.WriteLine(name + ", thats a good number that " + nNum);
                            if(nNum%2 != 0 )
                            {
                                Console.WriteLine(nNum + " is odd!  " + name + ", would you like to play again?");
                                string end = Console.ReadLine();
                                if(end == "y" || end == "Y")
                                {
                                    Console.WriteLine("That's great, " + name + ".  Pless enter and let's give it another go.");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("I'm so sad for you, " + name);
                                    program = false;
                                    moveOn = false;
                                    Console.ReadLine();
                                }
                                
                            }
                            else
                            {
                                if(nNum%2==0)
                                {
                                    Console.WriteLine(nNum + " is even, " + name);
                                    if(nNum > 1 && nNum < 26)
                                    {
                                        Console.WriteLine(nNum + " is small at less then 25.  Would you like to play again?");
                                        string end = Console.ReadLine();
                                        if (end == "y" || end == "Y")
                                        {
                                            Console.WriteLine("That's great, " + name + ".  Pless enter and let's give it another go.");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("I'm so sad for you, " + name);
                                            program = false;
                                            moveOn = false;
                                            Console.ReadLine();
                                        }
                                    }
                                    else if(nNum > 26 && nNum < 61)
                                    {
                                        Console.WriteLine(nNum + " is pretty decent " + name + "  Would you like to play again?");
                                        string end = Console.ReadLine();
                                        if (end == "y" || end == "Y")
                                        {
                                            Console.WriteLine("That's great, " + name + ".  Pless enter and let's give it another go.");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("I'm so sad for you, " + name);
                                            program = false;
                                            moveOn = false;
                                            Console.ReadLine();
                                        }
                                    }
                                    else if(nNum > 61)
                                    {
                                        Console.WriteLine(nNum + " is huge!  Would you like to play again?");
                                        string end = Console.ReadLine();
                                        if (end == "y" || end == "Y")
                                        {
                                            Console.WriteLine("That's great, " + name + ".  Pless enter and let's give it another go.");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("I'm so sad for you, " + name);
                                            program = false;
                                            moveOn = false;
                                            Console.ReadLine();
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("you messed up " + name + ".  Would you like to try again?  Y or N?");
                            string messUp = Console.ReadLine();
                            if (messUp == "n" || messUp == "N")
                            {
                                program = false;
                                moveOn = false;
                            }
                            else
                            {
                                program = true;
                                moveOn = true;
                            }
                        }
                    }
                }
            }
            catch { Console.WriteLine("Does not compute."); }
            Console.ReadLine();
        }
    }
}
