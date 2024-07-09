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
 
        
        static void Main(string[] args)
        {
            //Exercise One
            ShortStory();

        }
    }
}
