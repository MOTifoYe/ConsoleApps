using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дататабл
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(new DataTable().Compute(Console.ReadLine().Replace(",", "."), null));
            }
        }
    }
}
