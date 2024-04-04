using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task2
    {
        public static bool IsPalindrom(int num)
        {
            int temp =0;
            int origin = 0;

            while(num>0)
            { 
                temp = temp*10 + num%10 ;
                num =num / 10 ;
            }

            return (temp == origin);
        }

    }
}
