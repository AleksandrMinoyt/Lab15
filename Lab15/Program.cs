using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression ap = new ArithProgression(1,2);
            
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());

            Console.WriteLine();

            ap.Reset();
            ap.SetStart(3);          
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());
            Console.WriteLine(ap.GetNext());

            Console.WriteLine();

            GeomProgression gp = new GeomProgression(1, 2);

            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());

            gp.Reset();
            gp.SetStart(3);
            Console.WriteLine();
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());
            Console.WriteLine(gp.GetNext());

            Console.ReadKey();

        }
    }
}
