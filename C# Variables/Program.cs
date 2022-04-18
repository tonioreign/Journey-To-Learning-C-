namespace C_Variables 
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");


            //Creating user Inputs
            string userName = Console.ReadLine();


            //concatening strings and variables
            Console.WriteLine("Hello " + userName + ", nice to meet you!");
            
            int age;
            int bAge;
            int cAge;


            // "Write" inputs same line "WriteLine" inputs next line
            Console.Write("Input your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is one of your sibling age?");
            bAge = Convert.ToInt32(Console.ReadLine());

            int total = bAge + age;
            Console.WriteLine("You and your sibling are " + total + " years old together" );

            Console.Write("Input another siblings age please: ");
            cAge = Convert.ToInt32(Console.ReadLine());

            double avg = (age+bAge+cAge)/3;

            Console.WriteLine("You guys have an average age of " + avg + " years old");

            
            
            
            //Wait before closing
            Console.ReadKey();



        }

    }
}