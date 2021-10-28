using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Neto_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite su sueldo: ");
            double sb = Convert.ToDouble(Console.ReadLine());            
            Console.WriteLine($"De Seguro de salud:   {(claNomina.DescARS(sb)).ToString("N2")}");
            Console.WriteLine($"De AFP se descontará: {(claNomina.DescAFP(sb)).ToString("N2")}");
            Console.WriteLine($"De ISR:               {(claNomina.DescISR(sb)).ToString("N2")}");
            Console.WriteLine("Total a descontar:    " + (claNomina.DescARS(sb) + claNomina.DescAFP(sb) + claNomina.DescISR(sb)).ToString("N2"));
            Console.WriteLine("El Sueldo Neto es:    " + (sb - (claNomina.DescAFP(sb) + claNomina.DescARS(sb) + claNomina.DescISR(sb))).ToString("N2"));
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
