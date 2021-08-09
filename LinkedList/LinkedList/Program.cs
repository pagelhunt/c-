using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<string> sList = new List<string>();
             sList.Add("Hello");
             sList.Add("World");*/
            LinkedList list = new LinkedList();

            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");
            list.Add(1, "test5");

            Console.WriteLine("Is empty? - " + list.Empty);
            Console.WriteLine("Count - " + list.Count);
            Console.WriteLine("Is test5 in the list? - " + list.Contains("test5"));
            Console.WriteLine("What index? - " + list.IndexOf("test5"));
            Console.WriteLine("What is in index 4? - " + list.Get(4));
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Here is the current order of the list:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
            Console.Clear();

            list.Remove(1);
            
            Console.WriteLine("Is empty? - " + list.Empty);
            Console.WriteLine("Count - " + list.Count);
            Console.WriteLine("Is test5 in the list? - " + list.Contains("test5"));

            if (list.Contains("test5"))
                Console.WriteLine("What index? - " + list.IndexOf("test5"));
            else
                Console.WriteLine("New value in index 1 is " + list[1]);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Here is the current order of the list:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadLine();
            Console.Clear();

            list.Clear();


            Console.WriteLine("Is empty? - " + list.Empty);
            Console.WriteLine("Count - " + list.Count);

            Console.ReadLine();
        }
    }
}
