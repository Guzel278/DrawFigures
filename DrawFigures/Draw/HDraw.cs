﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    public class HDraw : IDraw
    {
        int i, j;
        char[,] f;
        public void SetCanvas(char[,] f)
        {
            this.f = f ?? throw new ArgumentNullException(nameof(f));
        }
        public void Create()
        {
            int k = f.GetLength(0);
            //roof
            for (int i = k / 2 - 1; i >= 0; i--)
            {

                for (int j = 0; j <= i; j++)
                    f[i, j] = '*';
                for (int j = k; j < i; j++)
                    f[i, j] = '@';

                //for (int j = 0; j <= k - 1; j++)
                //    f[i, j] = '@';
                //for (int j = 0; j <= i; j++)
                //    f[i, j] = '*';

                //for (j = 0; j <= k - 1 - i; j++)
                //    f[i, j] = '@';
                //for (; j < k; j++)
                //    f[i, j] = '*';

            }

            for (int i = k/2; i < k; i++)
            {
                for (int j = 0; j < k ; j++)
                {
                    f[i, j] = '*';
                }
            }       
        }
    }
}
