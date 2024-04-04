using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task1
    {
        public static void DrawSquare(string str, int lengthSide)
        {
            for (int i = 0; i < lengthSide; i++)
            {
                for (int j = 0; j < lengthSide; j++)
                {
                    if (i == 0 || i == lengthSide - 1 || j == 0 || j == lengthSide - 1)
                    {
                        Console.Write(str);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
