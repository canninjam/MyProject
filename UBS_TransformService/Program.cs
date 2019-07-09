using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UBS_TransformService.Services;

namespace UBS_TransformService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting 35432 to string:");
            var transformer = new CurrencyTransform();
            Console.WriteLine(transformer.Humanize(35432));
            Console.WriteLine("Press anything to exit.");
            Console.ReadKey();
            Console.WriteLine("Bye.");
        }
    }
}
