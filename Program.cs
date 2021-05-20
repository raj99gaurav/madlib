using System;

namespace drawashape
{
    class Program
    {
        //mad lib game
        static void Main(string[] args)
        {
            string color, pluralNoun, celeb;
            
            Console.WriteLine("Enter a color : ");
            color = Console.ReadLine();

            Console.WriteLine("Enter a plural noun : ");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Enter a celeb : ");
            celeb = Console.ReadLine();

            Console.WriteLine("Roses are {0}",color);
            Console.WriteLine("{0} are blue", pluralNoun);
            Console.WriteLine("I Love {0}", celeb);
            
            Console.ReadLine();
        }
    }
}
