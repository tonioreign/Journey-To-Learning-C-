namespace C_Arrays 
{
    class Program 
    {
        static void Main(string[] args) 
        {   

                List<string> shoppingList = new List<string>();

                shoppingList.Add("Dreams");
                shoppingList.Add("Miracles");
                shoppingList.Add("Rainbows");
                shoppingList.Add("Pony");

                for (int i = 0; i < shoppingList.Count; i++) {
                    int raise = i + 1;
                    Console.WriteLine(shoppingList[i]);
                }

                shoppingList.Remove("Dreams");
                shoppingList.RemoveAt(1);
                Console.WriteLine("-------------");
                for (int i = 0; i < shoppingList.Count; i++) {
                    int raise = i + 1;
                    Console.WriteLine(shoppingList[i]);
                }

                // string[] drinks = new string[4]
                // Console.WriteLine("What is your four favorite drinks?")
                // for (int i = 0; i < drinks.Length; i++) {
                //     drinks[i] = Console.ReadLine();
                // }
                // Console.WriteLine("Here they are alphabetically");
                // Array.Sort(drinks);
                // for (int i = 0; i < drinks.Length; i++) {
                //     Console.WriteLine(drinks[i]);
                // }





            Console.ReadKey();

        }
    }
}