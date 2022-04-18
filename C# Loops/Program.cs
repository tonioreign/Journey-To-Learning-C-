namespace Loops 
{
    class Program 
    {
        static void Main(string[] args) 
        {       

            // Console.Write("How many cool numbers do you want: ");
            // int count = Convert.ToInt32(Console.ReadLine());

            // for (int i = 1; i  <= count; i++) 
            // {
            //     double result = Math.Pow(2,  i);
            //     Console.WriteLine(result );

            // }

           Random numberGen = new Random();

           numberGen.Next(0, 6);

           int roll = 0;
           int attempts = 0;

           Console.WriteLine("Press enter to roll the die...");

            while (roll != 6) {

                Console.ReadKey();
                
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }
            Console.WriteLine("You took " + attempts + " times.");


            Console.ReadKey();


        }

    }

}