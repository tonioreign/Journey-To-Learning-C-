namespace C_Classes 
{
        class Wizard
    {
        public string name;
        public string favoriteSpell;
        public int spellSlots;
        public float experience; 

        public void CastSpell()
        {

            if (spellSlots > 0) 
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                 spellSlots--;
                 experience += .03f;
            }
            else 
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditate()
        {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots = 2;
        }

    }

    class Program 
    {
        static void Main(string[] args) 
        {
            Wizard wizard1 = new Wizard();
            wizard1.name = "Tonio Reign";
            wizard1.favoriteSpell = "Fire Ball";
            wizard1.spellSlots = 2;
            wizard1.experience = 0f; //always use "f" on numbers using float

            Console.WriteLine("Spell slots: " + wizard1.spellSlots);
            
            wizard1.CastSpell();
            wizard1.CastSpell();
            wizard1.CastSpell();

            Console.WriteLine("Experience: " + wizard1.experience);

            Console.WriteLine("Spell slots: " + wizard1.spellSlots);




            Console.ReadKey();
        }
    }


}
