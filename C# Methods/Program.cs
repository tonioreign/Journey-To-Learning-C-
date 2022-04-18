namespace C_Methods 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            
            int result = Multiply(5, 20);

            int result1= Multiply(407, 39);

            Console.WriteLine("Here is your results: " + result);
            Console.WriteLine("Here is your results: " + result1);

            if (result % 2 == 0) {
                Console.WriteLine("This number is even!");
            }
            else {
                Console.WriteLine("This number is odd...");
            }
            if (result1 % 2 == 0) {
                Console.WriteLine("This number is even!");
            }
            else {
                Console.WriteLine("This number is odd...");
            }

            Console.WriteLine("---------");

            Console.ReadKey();
        }


        static int Multiply (int num1, int num2) 
        {
            int result = num1 * num2;
            return result;
        }






        // //Gets you thinking in components
        // static void MeetAliens() 
        // {
        //     Random numberGen = new Random(); //Random Number function

        //     string name = "X-" + numberGen.Next(10, 9999);
        //     int age =   numberGen.Next(10, 500);
        //     Console.WriteLine("Hi, I am "+ name);
        //     Console.WriteLine("I'm " + age + " years old.");
        //     Console.WriteLine("Oh, and I am an alien.");
        // }

    }

}