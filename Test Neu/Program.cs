using System;

namespace TestNeu 
{
    class Wizard 
    {
        public string name;
        public string favouriteSpell;
        public int spellslots;
        public float experience;

        public static int Count;

        public Wizard(string _name, string _favoriteSpell) 
        {
            name = _name;
            favouriteSpell = _favoriteSpell;
            spellslots = 2;
            experience = 0f;

            Count++;
        }

        public void CastSpell() 
        {
            if (spellslots > 0) 
            {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellslots--;
                experience += 0.5f;
            } else 
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditation() 
        {
            Console.WriteLine(name + " meditates to regain spell slots");
            spellslots = 5;
        }
    }

    class Program 
    {
        static void Main(string[] args) 
        {   Wizard wizard01 = new Wizard("Rom Tiddl","Avocado Kebabra");

            wizard01.CastSpell();
            Console.WriteLine(wizard01.name + " get " + wizard01.experience + " experience");

            Wizard wizard02 = new Wizard("Professor Seltsam", "Random Zauber");

            wizard02.CastSpell();
            Console.WriteLine(wizard02.name + " get " + wizard02.experience + " experience");

            Console.WriteLine(Wizard.Count);

            // Wait before closing
            Console.ReadKey();
        }
    }
}