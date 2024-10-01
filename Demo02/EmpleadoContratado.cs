using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class EmpleadoContratado : IPagable
    {
        public decimal PagoPorContrato { get; set; }
      
        public decimal CalcularPago()
        {
            return PagoPorContrato;
        }
    }
}
