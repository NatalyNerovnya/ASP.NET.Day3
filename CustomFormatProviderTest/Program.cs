using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomFormatProvider;


namespace CustomFormatProviderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer jeff = new Customer("Jeffrey Richter", "+1 (425) 555-0100", 1000000);
            Console.WriteLine(jeff.ToString());
            Console.WriteLine(jeff.ToString("n"));
            Console.WriteLine('\n');
            Console.WriteLine(jeff.ToString("R"));
            Console.WriteLine('\n');
            Console.WriteLine(jeff.ToString("p"));
            Console.WriteLine('\n');
            Console.WriteLine(jeff.ToString("NR"));
            Console.WriteLine('\n');
            Console.WriteLine(jeff.ToString("rnp"));
            Console.Read();
        }
    }
}
