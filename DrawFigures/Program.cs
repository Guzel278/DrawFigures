using System;

namespace DrawFigures
{
    internal class Program
    {          
        static void Main(string[] args)
        {
            CircleDraw circle = new CircleDraw();
            HomeDraw home = new HomeDraw();
            Artist<ConsoleOutput> artist = new Artist<ConsoleOutput>(home, 10);
            artist.Draw();
            Artist<FileOutput> artist2 = new Artist<FileOutput>(circle, 10);
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
