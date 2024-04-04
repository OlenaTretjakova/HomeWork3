using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1.DrawSquare("*", 6);
            Console.WriteLine();

            int num = 1234554321;
            Console.WriteLine($"Is {num} a palindrome? {Task2.IsPalindrom(num)}");

            int[] arr1 = { 1,2,3,4,5,6,7,8,9,10,11,12};
            Console.WriteLine("First array :");

            Task3.ShowArr(arr1);

            int[] arr2 = { 1, 2, 3 };
            Console.WriteLine("Second array :");
            Task3.ShowArr(arr2);

            Console.WriteLine("Sort array :");
            int[] arr3 = Task3.SortYourArray(arr1, arr2);
            Task3.ShowArr(arr3);

            Shop shop1 = new Shop();
            Console.WriteLine("Shop 1:");
            shop1.ShowInformShop();

            Shop shop2 = new Shop("Name Shop 2","Dsscription shop 2","address shop 2","phone shop 2","email shop2 email");
            Console.WriteLine("Shop 2:");
            shop2.ShowInformShop();




            Console.ReadLine();

        }


    }

}
