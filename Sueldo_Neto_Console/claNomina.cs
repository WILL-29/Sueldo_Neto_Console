using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo_Neto_Console
{
    class claNomina
    {
        public static double DescARS(double sb)
        {
            //Esto en realidad se llama SFS, Seguro Familiar de Salud
            double Total_Desc;
            Total_Desc = sb - (sb * 0.9696);
            return Total_Desc;
        }
        public static double DescAFP(double sb)
        {
            Double Total_Desc;
            Total_Desc = sb - (sb * 0.9713);
            return Total_Desc;
        }
        public static double DescISR(double sb)
        {
            double Total_Desc, Rest;
            Rest = sb - DescAFP(sb) - DescARS(sb);
            if (Rest > 34685.0 && Rest < 52027.42)
            {
                Total_Desc = ((Rest - 34685) * 15) / 100;
                return Total_Desc;
            }
            else
            {
                return 9;
            }

        }
    }
}
