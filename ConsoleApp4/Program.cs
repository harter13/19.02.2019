using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new dbq() )
            {
                //Console.WriteLine(ctx.Countries.Count());
                //Console.ReadKey();


                //1

                var contriii = ctx.Producers.Select(p => p.Adress.Country.Name).Distinct().ToList();
            }
        }
    }

}
