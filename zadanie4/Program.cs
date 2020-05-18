using System;
using System.Collections;
namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, "K", "i", "T", "t", "Y" };
            list.Remove("K");
            list.Remove("i");
            list.Remove("T");
            list.Remove("t");
            list.Remove("Y");
          
            for(int i=0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("\n");
            ArrayList list2 = new ArrayList() { "K", "T","Y" };
            foreach (object o2 in list2)
            {
                Console.WriteLine(o2);
            }
            Console.ReadLine();
        }
    }
}
