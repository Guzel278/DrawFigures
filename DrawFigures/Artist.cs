using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFigures
{
    internal class Artist<T>  where T : Output, new()
    {
        private char[,] Canvans;
        private T output;
        private IDraw draw;

        public Artist()
        {
        }

        public Artist(IDraw draw, int size)
        {          
            this.draw = draw ?? throw new ArgumentNullException(nameof(draw));
            this.Canvans = new char[size, size];
            this.output = new T();
        }

        public void Draw()
        {
            draw.SetCanvas(this.Canvans);
            draw.Create();
            output.Write(this.Canvans);
        }
    }
}
