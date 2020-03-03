﻿using System;
using System.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] list1 = new int[] { 1, 2, 3, 4, 5 };
            int[] list2 = new int[] { 3, 4, 5, 6, 7 };

            //a. Show the common elements in both lists.  E.g the common elements are "3 4 5", because they are contained in both lists.
            var list3 = list1.Intersect(list2);
            Console.WriteLine(string.Join(" ", list3));

            //b. Show the elements from list 1, but is not found in list2.  E.g 1 2"
            var list4 = list1.Where(itemInList1 => !list2.Any(itemInList2 => itemInList2 == itemInList1));
            Console.WriteLine(string.Join(" ", list4));

            //c. Complete here
            var list5 = list2.Except(list1);


            //Show the elements from list 2, but is not found in list1.  E.g 6 7"
            Console.WriteLine(string.Join(" ", list5));

            Console.WriteLine("Press <ENTER> to continue");
            Console.ReadLine();
        }
    }
}
