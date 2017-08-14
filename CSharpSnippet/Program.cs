using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSnippet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers\n");
            Numbers();
            Console.WriteLine("\n");

            Console.WriteLine("references types\n");

            Test1 a = new Test1()
            {
                Name = "test"
            };
            Test1 b = new Test1()
            {
                Name = "test"
            };
            Test1 c = a;

            Console.WriteLine("a == b {0}", a == b);
            Console.WriteLine("a Equals b {0}", a.Equals(b));
            Console.WriteLine("a == c {0}", a == c); // reference er det samme
            Console.WriteLine("a == c {0}", a.EqualsValues(b)); // my own method to equal

            Console.WriteLine("\n");

            // Stop exit application
            Console.ReadLine();
        }

        private static void Numbers()
        {
            // Float, double, decinal - om performance og nøjagtig tal
            float flt = 1F / 3;
            double dbl = 1D / 3;
            decimal dcm = 1M / 3;
            Console.WriteLine("Float, double, decinal - om performance og nøjagtig tal \n");
            Console.WriteLine(" float: {0}\n double: {1}\n decimal: {2}\n", flt, dbl, dcm);

            // Udregning eksempel med divider og afrundning
            decimal tal1 = new decimal(10000000000000.5521);
            decimal tal2 = new decimal(2.1224545434523);

            float flt2 = (float)tal1 / (float)tal2;
            double dbl2 = (double)tal1 / (double)tal2;
            decimal dcm2 = tal1 / tal2;
            Console.WriteLine("Udregning eksempel med divider og afrundning \n");
            Console.WriteLine(" float: {0}\n double: {1}\n decimal: {2}\n", Math.Round(flt2, 2), Math.Round(dbl2, 2), Math.Round(dcm2, 2));
        }
    }
}
