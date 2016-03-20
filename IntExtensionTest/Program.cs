using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntExtension;

namespace IntExtensionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"-12235 = {(-12235).ToHexToString()}");
            Console.WriteLine($"73243 = {(73243).ToHexToString()}");
            Console.WriteLine($"16 = {(16).ToHexToString()}");
            Console.WriteLine($"15 = {(15).ToHexToString()}");
            Console.WriteLine($"7 = {(7).ToHexToString()}");

            Console.Read();
        }
    }
}
