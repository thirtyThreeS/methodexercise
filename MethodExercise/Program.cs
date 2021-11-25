// See https://aka.ms/new-console-template for more information


namespace Method_Excercise
{

    class Program
    {

        public static int Addition(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Subtract(int sub1, int sub2)
        {
            return sub1 - sub2;
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }

        public static double Divide(double a, double b)
        {
            return a / b;
        }

        public static double Modulus(double r, double s)
        {
            return r % s;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Tell us a few things about yourself!!" + $" What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("Your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("Your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine("And finally your name or whatever it is you like to be called!");
            string name = Console.ReadLine();

            Console.WriteLine("When " + name + " goes to the bar they see all their favorite " + animal + "'s"
                                + " dressed in " + color + " suits and dresses playing songs to their favorite "
                                + "band, " + band + "!");
            Console.WriteLine("---");



            // User/Addition

            Console.WriteLine("Give me a number to add!");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to add to the previous number!");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Addition(num1, num2);
            Console.WriteLine($"The sum of these numbers are {sum}!");
            Console.WriteLine("---");


            //Hard-coding addition examples of multiple param numbers

            Console.WriteLine("Hardcode Examples");
            Console.WriteLine(Addition(2, 4));
            Console.WriteLine(Addition(2, 4, 6));
            Console.WriteLine(Addition(1, 1, 1, 1, 1));
            Console.WriteLine("---");


            // User/Subtraction

            Console.WriteLine("Give me a number to subtract!");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to subtract by!");
            num2 = int.Parse(Console.ReadLine());

            int subtraction = Subtract(num1, num2);
            Console.WriteLine($"The subtraction of these numbers are {subtraction}!");
            Console.WriteLine("---");


            // User/Multiplication

            Console.WriteLine("Give me a number to multiply!");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to multiply to the previous number!");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product of these numbers are {product}!");
            Console.WriteLine("---");


            // User/Division

            Console.WriteLine("Give me a number to divide!");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to divide by!");
            num2 = int.Parse(Console.ReadLine());

            double divide = Divide(num1, num2);
            Console.WriteLine($"The division of these numbers are {divide}!");
            Console.WriteLine("---");


            // User/Modulus

            Console.WriteLine("Find the remainder of a divided number! Give me a number to divide!");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me another number to divide by!");
            num2 = int.Parse(Console.ReadLine());

            double modulus = Modulus(num1, num2);
            Console.WriteLine($"The remainder of these numbers are {modulus}!");
            Console.WriteLine("Thank you for playing!");




        }
    }
}