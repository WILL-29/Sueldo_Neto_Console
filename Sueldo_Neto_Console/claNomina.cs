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
            if (Total_Desc >= 4098.53)
            {
                Total_Desc = 4098.53;
                return Total_Desc;
            }
            return Total_Desc;
        }
        public static double DescAFP(double sb)
        {
            Double Total_Desc;
            Total_Desc = sb - (sb * 0.9713);
            if (Total_Desc >= 7738.67)
            {
                Total_Desc = 7738.67;
                return Total_Desc;
            }
            return Total_Desc;
        }
        public static double DescISR(double sb)
        {
            double Total_Desc, Rest;
            Rest = sb - DescAFP(sb) - DescARS(sb);
            if (Rest <= 34685.0 )
            {
                return 0;
            }
            else if (Rest > 34685.0 && Rest < 52027.42)
            {
                Total_Desc = ((Rest - 34685) * 15) / 100;
                return Total_Desc;
            }
            else if (Rest > 52027.42 && Rest < 72260.25)
            {
                Total_Desc = 2601.33 + ((Rest - 52027.42) * 0.20);
                return Total_Desc;
            }
            else
            {
                Total_Desc = 6648 + ((Rest - 72260.25) * 0.25);
                return Total_Desc;
            }

        }
    }
}
