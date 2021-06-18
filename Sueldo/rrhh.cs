using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    class rrhh
    {

        public double Calculo_Nomina(int sueldo)
        {
            double gratificacion = sueldo * 0.25;
            double total_imponible = sueldo + gratificacion;
            double afp = total_imponible * 0.11;
            double fonasa = total_imponible * 0.7;
            double cesantia = total_imponible * 0.06;
            double total_final = total_imponible - afp - fonasa - cesantia;
            return total_final;
        }
    }

}
