using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task3
    {
        public static int[] SortYourArray(int[] array1, int[] array2)
        {
            List<int> Sort = new List<int>();

            for (int i = 0; i < array1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < array2.Length; j++)
                {

                    if (array1[i] == array2[j])
                    {
                        found = true;
                        break;

                    }

                }
                if (!found)
                {
                    Sort.Add(i);
                }

            }

            int[] SortArr = Sort.ToArray();


            return SortArr;
        }

        public static void ShowArr(int[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
