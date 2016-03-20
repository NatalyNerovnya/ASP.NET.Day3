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
            Console.WriteLine($"-12235 = {(-12235).ConvertToHex()}");
            Console.WriteLine($"73243 = {(73243).ConvertToHex()}");
            Console.WriteLine($"16 = {(16).ConvertToHex()}");
            Console.WriteLine($"15 = {(15).ConvertToHex()}");

            Console.Read();
        }
    }
}
