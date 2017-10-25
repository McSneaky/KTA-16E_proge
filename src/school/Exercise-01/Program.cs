using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Hello world!");
            
            Matrix matrix = Matrix.init();

            Console.Out.WriteLine("Generated matrix with "
                + Environment.NewLine
                + "X: " + matrix.x_len
                + Environment.NewLine
                + "Y: " + matrix.y_len
            );

            pause();
        }

        static void pause()
        {
            Console.Out.WriteLine("Press any key..");
            Console.ReadKey();
        }
    }
}
