using System.IO.Pipes;

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
        public static int Sub(params int[] numbers)
        {
            int sub = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                sub -= numbers[i];
            }

            return sub;
        }
        public static int Mult(params int[] numbers)
        {
            int mult = 1;
            foreach (int number in numbers)
            {
                mult *= number;
            }

            return mult;
        }
        public static int Div(params int[] numbers)
        {
            int div = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                div /= numbers[i];
            }

            return div;
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
            //ShortStory();
            
            
            //Exercise Two
            int added = Add(2,5);
            Console.WriteLine(added);
            
            int resultSub = Sub(320548,39215,684,2847);
            Console.WriteLine(resultSub);
            
            int resultMult = Mult(14,19,1,7);
            Console.WriteLine(resultMult);
            
            int resultDiv = Div(295,5,5);
            Console.WriteLine(resultDiv);

            
            //Challenge
            int resultSum = Sum(5, 5, 5, 5, 5, 5);
            Console.WriteLine(resultSum);

        }
    }
}
