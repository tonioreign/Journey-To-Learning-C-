namespace C_Arrays 
{
    class Program 
    {
        static void Main(string[] args) 
        {

                string[] drinks = new string[4];

                Console.WriteLine("What is your four favorite drinks?");

                drinks[0] = Console.ReadLine();
                drinks[1] = Console.ReadLine();
                drinks[2] = Console.ReadLine();
                drinks[3] = Console.ReadLine();
                

                Array.Sort(drinks);

            Console.ReadKey();

        }
    }
}