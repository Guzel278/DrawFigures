using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    internal class CircleDraw : IDraw
    {
        int i, j;
        char[,] f;

        public void SetCanvas(char[,] f)
        {
            this.f = f ?? throw new ArgumentNullException(nameof(f));
        }
        public void Create()
        {
            int r = f.GetLength(0) / 2;
            for (i = 0; i < 2 * r; i++)
            {
                for (j = 0; j < 2 * r; j++)
                {
                    if ((i - r) * (i - r) + (j - r) * (j - r) < r * r)
                       f[i,j] = '*' ;
                    else f[i,j] = ' '; 
                }              
            }
        }      
    }


}
