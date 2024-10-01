using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase12
{
    public class Producto
    {
        public int TipoProducto { get; set; }

        public int Descuento { get; set; }

        public void Enviar()
        {
            if (TipoProducto==1)
            {
                Console.WriteLine("Enviar producto a proveedor A");

            }
            if (TipoProducto == 2)
            {
                Console.WriteLine("Enviar producto a proveedor B");
            }
            if (TipoProducto == 3)
            {
                Console.WriteLine("Enviar producto a proveedor C");
                Console.WriteLine("Aplicar Descuento: " + Descuento);

            }
        }
    }
}
