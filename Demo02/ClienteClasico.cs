using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    public class ClienteClasico : ICliente

    {
        public int CostoServicio { get; set; }
        public decimal CalcularDeuda()
        {
            return CostoServicio * 1.25M;
        }
    }
}
