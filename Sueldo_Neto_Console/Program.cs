using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Neto_Console
{
    class Program : claNomina
    {
        static void Main(string[] args)
        {
            Double sb;
            sb = 175000;
            Console.WriteLine($"De Seguro de salud:   {Convert.ToString(claNomina.DescARS(sb))}");
            Console.WriteLine($"De AFP se descontará: {Convert.ToString(claNomina.DescAFP(sb))}");
            Console.WriteLine($"De ISR:               {Convert.ToString(claNomina.DescISR(sb))}");
            Console.ReadKey();

        }
    }
}
