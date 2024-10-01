using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class ProductoC : IPedido
    {
        public int Descuento { get; set; }

        public void Enviar()
        {
            Console.WriteLine("Enviar producto a proveedor C");
            Console.WriteLine("Aplicar Descuento: " + Descuento);
        }
    }
}
