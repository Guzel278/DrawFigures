using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    public interface IDraw
    {   
        void Create();
        void SetCanvas(char[,] f);
    }
}
