namespace C_Classes 
{
        class Wizard
    {
        public string name;
        public string favoriteSpell; //"public" can be accessed outside of the class
        public int spellSlots;
        private float experience; //"private" can only be accessed through the class
        public static int Count; //static can access general elements

        public Wizard(string _name, string _favoriteSpell)
        {
            name = _name;
            favoriteSpell = _favoriteSpell;
            spellSlots = 2;
            experience = 0f;

            Count++;
        }


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

            


            Console.ReadKey();
        }
    }


}
