namespace MethodsExercise
{
    public class Program
    {
        //Exercise One
        public static void ShortStory()
        {
            Console.WriteLine("What is your Name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your Favorite Color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite Video Game?");
            string favGame = Console.ReadLine();
            Console.WriteLine("What is your Favorite Animal?");
            string favAnimal = Console.ReadLine();
            Console.Clear(); 
            
            Console.WriteLine($"One Day, {userName} was walking down the street. {userName} saw a {favAnimal} wearing {favColor} pants, playing {favGame}! How crazy is that!!Ste");
            Console.WriteLine("Ready to clear?");
            Console.ReadLine();
            Console.Clear();
        }
        
        //Exercise Two
        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public static int Divide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        
        //Challenge
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }
        
        
        static void Main(string[] args)
        {
            //Exercise One
            ShortStory();
            
            
            //Exercise Two
            int added = Add(2,5);
            Console.WriteLine(added);
            
            int subtracted = Subtract(320548,39215);
            Console.WriteLine(subtracted);
            
            int multiplied = Multiply(14,19);
            Console.WriteLine(multiplied);
            
            int divided = Divide(295,5);
            Console.WriteLine(divided);

            
            //Challenge
            int result = Sum(5, 5, 5, 5, 5, 5);
            Console.WriteLine(result);

        }
    }
}
