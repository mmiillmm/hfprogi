using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas123132415246346373
{
    class Program
    {
        static void Main(string[] args)
        {
            string adatok = "10;5;7";

            //foreach (var betu in adatok)
            //{
            //    if (betu == ';')
            //    {
            //        Console.WriteLine();
            //    }

            //    else
            //    {
            //        Console.Write(betu);
            //    }
            //}


            // Házi megoldás: 

            for (int i = 0; i < adatok.Length; i++)
            {
                if (adatok[i] == ';')
                {
                    Console.WriteLine();
                }

                else
                {
                    Console.Write(Convert.ToInt32(adatok[i].ToString()) * 2);
                }
            }


            Console.ReadKey();
        }
    }
}
