using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            StringDisplay();
            Numbers();
        }

        static void Numbers()
        {
            
            Console.WriteLine();

            Console.ReadLine();
        }
        static void StringDisplay()
        {
            string phrase = "A bunch of things";

            Console.WriteLine(phrase.Substring(phrase.IndexOf("bunch")));

            Console.ReadLine();
        }
    }
}
