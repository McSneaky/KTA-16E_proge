using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
    class Matrix
    {
        public int x_len { get; set; }
        public int y_len { get; set; }

        public Matrix(int x, int y)
        {
            x_len = x;
            y_len = y;
        }

        public static Matrix init()
        {
            Console.Out.WriteLine(
                "Create new matrix "
                + Environment.NewLine 
                + "Insert msdatrix X and Y size"
            );

            // Get X
            Console.Out.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            // Get Y
            Console.Out.Write("X: ");
            int y = int.Parse(Console.ReadLine());

            return new Matrix(x, y);
        }
    }
}
