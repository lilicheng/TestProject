using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs ={ "aa", "bb", "cc" };

            foreach (var tmp in strs.Where(n=>n.Length==2))
                Console.Write(tmp);
            Console.ReadLine();
            
        }
    }
}
