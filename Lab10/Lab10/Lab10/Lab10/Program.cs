﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {


        static void Main(string[] args)
        {
            TheStart:

            TheMovies Movies = new TheMovies();

            Console.WriteLine("Choose a catagory: \n H - Horror \n A - Animation \n S - SciFi \n D - Drama");
            string input = Console.ReadLine().ToLower();



            if(input == "h")
            {
                Movies.Horror();
            }
            if (input == "a")
            {
                Movies.Animation();
            }
            if (input == "d")
            {
                Movies.Drama();
            }
            if (input == "s")
            {
                Movies.SciFi();
            }

            DoAgain:
            Console.WriteLine("Would you like to see another catagory?");
            string again = Console.ReadLine().ToLower();
            if (again == "y")
            {
                goto TheStart;
            }
            if(again == "n")
            {
                Console.WriteLine("Goodbye.");
                System.Environment.Exit(1);
            }
            else
            {
                Console.WriteLine("Y for yes or n exit.\n");
                goto DoAgain;
            }
        }
    }
}
