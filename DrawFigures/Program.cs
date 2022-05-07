using System;

namespace DrawFigures
{
    internal class Program
    {          
        static void Main(string[] args)
        {
            CDraw circle = new CDraw();
            HDraw home = new HDraw();
            Artist<COutput> artist = new Artist<COutput>(home, 10);
            artist.Draw();
            Artist<FOutput> artist2 = new Artist<FOutput>(circle, 10);
            artist2.Draw();
            //for (int i = 0; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10 - i; j++)
            //        Console.Write(" ");
            //    for (int j = 1; j <= 2 * i - 1; j++)
            //        Console.Write("*");
            //    Console.Write("\n");
            //}


            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j < 10 * 2; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
