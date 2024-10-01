using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class EmpleadoTiempoCompleto : IPagable
    {
        public decimal SueldoMensual { get; set; }
        
        public decimal CalcularPago()
        {
            return SueldoMensual;
        }
    }
}
