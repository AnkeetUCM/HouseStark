using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayConcept
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new int[3];
            Numbers [0] = 3;

            var flag = new bool[3];
            flag[0] = true;


            Console.WriteLine(Numbers[0]);
            Console.WriteLine(Numbers[1]);
            Console.WriteLine(Numbers[2]);
            Console.WriteLine(flag[0]);
            Console.WriteLine(flag[1]);
            Console.WriteLine(flag[2]);





        }
    }
}
