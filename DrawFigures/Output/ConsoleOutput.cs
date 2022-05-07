using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    public class ConsoleOutput : Output
    {
        public override void Write(char[,] f)
        {
            int k = f.GetLength(0);
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write($"{f[i,j]}");
                }
                Console.WriteLine();
            }
          
        }
    }
}
