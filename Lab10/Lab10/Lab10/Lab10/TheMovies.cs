using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class TheMovies
    {

        public void Horror()
        {
            ArrayList horror = new ArrayList();
            horror.Add("Saw");
            horror.Add("Alien");
            horror.Add("Friday The 13th");
            horror.Add("Holloween");
            horror.Add("Jason");
            horror.Add("The Ginger Dead Man");
            horror.Add("Sharknado");
            horror.Add("Childs Play");
            horror.Add("Pet Cemetary");
            horror.Add("Hellraiser");
            horror.Add("HandyMan");
            horror.Add("The Lawnmower Man");


            HList(horror);
        }

        public void HList(ArrayList horror)
        {
            foreach (string i in horror)
            {
                Console.WriteLine(i);
            }

        }

        public void Animation()
        {
            ArrayList Animation = new ArrayList();
            Animation.Add("Toy Story");
            Animation.Add("Finding Nemo");
            Animation.Add("The Incredibles");
            Animation.Add("The Beauty and the Beast");
            Animation.Add("Paddington 2");
            Animation.Add("Inside Out");
            Animation.Add("Coco");
            Animation.Add("Snow White and the Seven Dwarves");
            Animation.Add("Zootopia");
            Animation.Add("Up");
            Animation.Add("Pinocchio");
            Animation.Add("The LEGO Movie");


            AList(Animation);
        }

        public void AList(ArrayList Animation)
        {
            foreach (string i in Animation)
            {
                Console.WriteLine(i);
            }

        }

        public void Drama()
        {
            ArrayList drama = new ArrayList();
            drama.Add("Citizen Kane");
            drama.Add("Call Me By Your Name");
            drama.Add("All About Eve");
            drama.Add("Metropolis");
            drama.Add("Moonlight");
            drama.Add("Casablanca");
            drama.Add("Splotlight");
            drama.Add("The Godfather");
            drama.Add("Lady Bird");
            drama.Add("La Grande Illusion");
            drama.Add("Boyhood");
            drama.Add("The battle of Algiers");


            DList(drama);
        }

        public void DList(ArrayList drama)
        {
            foreach (string i in drama)
            {
                Console.WriteLine(i);
            }

        }

        public void SciFi()
        {
            ArrayList SciFi = new ArrayList();
            SciFi.Add("Wizard of Oz");
            SciFi.Add("Mad Max: Fury Road");
            SciFi.Add("Metropolis");
            SciFi.Add("E.T. The Extra-Terrestrial");
            SciFi.Add("Nosferatu, a Symphony of Horror");
            SciFi.Add("Wonder Woman");
            SciFi.Add("Gravity");
            SciFi.Add("Star Wars VII: The Force Awakens");
            SciFi.Add("Logan");
            SciFi.Add("Arrival");
            SciFi.Add("Star Wars: The Last Jedi");
            SciFi.Add("The Dark Knight");


            SList(SciFi);
        }

        public void SList(ArrayList SciFi)
        {
            foreach (string i in SciFi)
            {
                Console.WriteLine(i);
            }

        }

    }
}


