using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class ClienteVIP : ICliente
    {
        public int CostoServicio { get; set; }
        public int Descuento { get; set; }
        public decimal CalcularDeuda()
        {

            return CostoServicio - Descuento;
            
        }
    }
}
