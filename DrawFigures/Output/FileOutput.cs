using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DrawFigures
{
    internal class FileOutput : Output
    {
        public override void Write(char[,] f)
        {                  
            using (StreamWriter st = File.AppendText($"..\\..\\..\\..\\{DateTime.Now.ToString("dd.mm.yyyy")}_picture.txt"))
            {
                for (int i = 0; i < f.GetLength(0); i++)
                {
                    for (int j = 0; j < f.GetLength(1); j++)
                    {
                        st.Write(f[i, j] + " ");                      
                    }
                    st.WriteLine();                   
                }
            }
        }
    }
}
