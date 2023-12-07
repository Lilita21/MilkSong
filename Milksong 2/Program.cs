using static System.Net.Mime.MediaTypeNames;

namespace Milksong_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milksleft = 99;
            while (milksleft > 2)
            {
                Console.WriteLine ( milksleft + " bottles of milk on the wall, " + milksleft + " bottles of milk ");
                milksleft--;
                Console.WriteLine( "Take one down and pass it around , " + milksleft + " Bottles of milk ");
                

            }
            Console.WriteLine(milksleft + " bottles of milk on the wall, " + milksleft + " bottles of milk ");
            milksleft--;
            Console.WriteLine("Take one down and pass it around , " + milksleft + " Bottle of milk ");

            Console.WriteLine(milksleft + " bottle of milk on the wall, " + milksleft + " bottle of milk ");
        }
    }
}
