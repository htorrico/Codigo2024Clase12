using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class EmpleadoPorHoras : IPagable
    {
        public int NumeroHoras { get; set; }
        public int CostoPorHora { get; set; }
        public decimal CalcularPago()
        {
            return NumeroHoras * CostoPorHora;
        }
    }
}
