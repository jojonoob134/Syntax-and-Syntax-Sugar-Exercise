namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var movie = "scott pillgram vs the world";
            var times = 7;
            var clock = "7:30";
            Console.WriteLine($"My absolute favoret movie is {movie} and I watched it about {times} and i'm going to watch it again at {clock}pm");

            string interpo = (movie == "scott pillgram vs the world") ? "yes scott pillgram is my favoret movie to" : "no that's not my favoret moive";
            Console.WriteLine(interpo);
        }
    }
}
